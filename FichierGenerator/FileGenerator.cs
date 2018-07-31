using FichierGenerator.Template;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace FichierGenerator
{
    public class FileGenerator
    {
        ArchiDocument archiDocument;
        XElement doc;
        XNamespace NP;
        XNamespace xmlns_xsi = "http://www.w3.org/2001/XMLSchema-instance";

        public FileGenerator(string file_path)
        {
            this.File_path = file_path;
            doc = XElement.Load(file_path);
            NP = doc.GetDefaultNamespace();
            archiDocument = new ArchiDocument(file_path);            
        }

        public static readonly string[] all_types = {
            "Product",
            "BusinessObject",
            "Contract",
            "Representation",
            "DataObject",
            "ApplicationInterface",
            "ApplicationService",
            "ApplicationFunction",
            "ApplicationComponent",
            "ApplicationEvent",
            "ApplicationProcess"};

        public string File_path { get; set; }

        [STAThread]
        /// <summary>
        ///     Method to run the t4 template
        /// </summary>
        /// <param name="output_name"> The name of the fichier created</param>
        /// <param name="types"> The selected types </param>
        /// <param name="groups"> The selected groups </param>
        /// <param name="views"> The selected views </param>
        /// <param name="name_space"> The namespace of generated class </param>
        /// <param name="templateFilePath"> The path of using template, use Generator2 as defaut </param>
        public void Generate(string destinationFolder,
            string targetFileName,
            string[] types,
            string[] groups,
            string[] views,
            string name_space,
            string CSTemplateFilePath,
            string SQLTemplateFilePath,
            string XamlTemplateFilePath)
        {
            var my_types = (types != null) && (types.Length > 0) ? types : all_types;
            var my_groups = (groups != null) && (groups.Length > 0) ? groups : null;
            var my_views = (views != null) && (views.Length > 0) ? views : null;
            ArchiDocument archiDocumentTemp = archiDocument;
            archiDocumentTemp.Update(my_types, my_groups, my_views, name_space);
            ArchiDocumentSerialized archiDocumentSerialized = new ArchiDocumentSerialized(archiDocumentTemp);

            //GenerateSolution(destinationFolder, archiDocumentTemp.Mmap_solution);

            if (CSTemplateFilePath.Length > 0)
            {
                var output = Transform(archiDocumentSerialized, CSTemplateFilePath);
                File.WriteAllText(Path.Combine(destinationFolder, targetFileName + ".cs"), output);
            }

            if (SQLTemplateFilePath.Length > 0)
            {
                var output = Transform(archiDocumentSerialized, SQLTemplateFilePath);
                output = output.Replace("<T>","");
                XElement xml = XElement.Parse(output);

                //var generator = new SQLScriptTemplate();
                //generator.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
                //generator.Session["archiDocument"] = archiDocumentSerialized;
                //generator.Initialize();
                //var generatedCode = generator.TransformText();
                //XElement xml = XElement.Parse(generatedCode);

                foreach (var node in xml.Descendants("script"))
                    System.IO.File.WriteAllText(Path.Combine(destinationFolder, node.Attribute("name").Value + ".sql"), node.Value);
            }

            if (XamlTemplateFilePath.Length > 0)
            {
                foreach(var view in archiDocument.List_representation)
                {
                    var viewTemplate = new ViewTemplate();
                    viewTemplate.Session = new TextTemplatingSession();
                    if (archiDocument.Dict_element_group.ContainsKey(view.Identifier_))
                        viewTemplate.Session["groupName"] = StringHelper.UpperString(archiDocument.Dict_element[archiDocument.Dict_element_group[view.Identifier_]].Class_name_);
                    else
                        viewTemplate.Session["groupName"] = "UnknownGroup";
                    viewTemplate.Session["viewName"] = StringHelper.UpperString(view.Class_name_);
                    viewTemplate.Initialize();
                    var generatedText = viewTemplate.TransformText();
                    File.WriteAllText(destinationFolder + "\\" +StringHelper.UpperString(view.Class_name_) + ".xaml", generatedText);
                }
                
            }
        }

        [STAThread]
        private void GenerateSolution(string destinationFolder, Dictionary<string, List<string>> dict)
        {
            Dictionary<string, Element> dict_element = archiDocument.Dict_element;
            System.Type type = Type.GetTypeFromProgID("VisualStudio.DTE.15.0");
            Object obj = System.Activator.CreateInstance(type, true);
            EnvDTE.DTE dte = (EnvDTE.DTE)obj;

            foreach (var id_solution in dict.Keys)
            {
                List<string> list_projet = dict[id_solution];
                string solution_name = StringHelper.UpperString(dict_element[id_solution].Class_name_);

                //dte.MainWindow.Visible = true; // optional if you want to See VS doing its thing*
                string path = destinationFolder;
                string solution_path = System.IO.Path.Combine(path, solution_name);
                
                // create the folder for the solution
                System.IO.Directory.CreateDirectory(solution_path);

                // Generate App.xaml
                var appXamlTemplate = new AppXamlTemplate();
                appXamlTemplate.Session = new TextTemplatingSession();
                appXamlTemplate.Session["solutionName"] = solution_name;
                List<string> list_FT;
                List<string> list_view = new List<string>();
                if (archiDocument.Mmap_relationship.ContainsKey(id_solution))
                {
                    if(archiDocument.Mmap_relationship[id_solution]["source"].TryGetValue("Triggering", out list_FT))
                        foreach (var i in list_FT)
                            if (dict_element[i].Type_.Equals("Representation"))
                                list_view.Add(StringHelper.UpperString(dict_element[i].Class_name_)+".xaml");
                    if (archiDocument.Mmap_relationship[id_solution]["source"].TryGetValue("Flow", out list_FT))
                        foreach (var i in list_FT)
                            if (dict_element[i].Type_.Equals("Representation"))
                                list_view.Add(StringHelper.UpperString(dict_element[i].Class_name_)+".xaml");
                }

                string views;
                if (list_view.Count() > 0)
                    views = string.Join(",", list_view);
                else
                    views = "null";
                appXamlTemplate.Session["launcherName"] = views;
                appXamlTemplate.Initialize();
                var generatedText = appXamlTemplate.TransformText();
                File.WriteAllText(solution_path + "\\App.xaml", generatedText);
                
                // create a new solution
                dte.Solution.Create(solution_path, solution_name);
                var solution = dte.Solution;
                solution.AddFromTemplate(Path.GetFullPath(@"..\..\lib\ConsoleApplication\csConsoleApplication.vstemplate"),
                        Path.Combine(Path.GetFullPath(solution_path), solution_name), solution_name);
                Thread.Sleep(1000);
                // create a C# ConsoleApp app
                foreach (var id_projet in list_projet)
                {
                    string projet_name = StringHelper.UpperString(dict_element[id_projet].Class_name_);
                    //Console.WriteLine(Directory.GetCurrentDirectory());

                    solution.AddFromTemplate(Path.GetFullPath(@"..\..\lib\ClassLibrary\csClassLibrary.vstemplate"),
                        Path.Combine(Path.GetFullPath(solution_path), projet_name), projet_name);

                    Thread.Sleep(1000);
                }


                dte.ExecuteCommand("File.SaveAll");
                

                //// create a C# class library
                //solution.AddFromTemplate(@"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\ProjectTemplatesCache\CSharp\Windows\1033\ClassLibrary\csClassLibrary.vstemplate",
                //    @"C:\NewSolution\ClassLibrary", "ClassLibrary");

                // save and quit

            }

            dte.Quit();
        }
        
        private string Transform(ArchiDocumentSerialized archiDocumentSerialized, string templateFilePath = "..\\..\\Template\\Generator2.t4")
        {
            CustomCmdLineHost host = new CustomCmdLineHost();
            Engine engine = new Engine();
            host.TemplateFileValue = templateFilePath;
            //Read the text template.  
            string input = File.ReadAllText(templateFilePath);
            var extensionPath = Path.GetDirectoryName(GetType().Assembly.Location) + Path.DirectorySeparatorChar;
            input = input.Replace("$(binDir)", extensionPath);
            
            
            host.Session = host.CreateSession();
            // Add parameter values to the Session:  
            host.Session["archiDocument"] = archiDocumentSerialized;
            //Transform the text template.  

            string result = engine.ProcessTemplate(input, host);

            if (host.Errors!=null)
            {
                foreach (CompilerError error in host.Errors)
                {
                    Console.WriteLine(error.ToString());
                }
            }
            

            return result;

            

            //var generator = new Generator();
            //generator.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            //generator.Session["archiDocument"] = archiDocument;
            //generator.Initialize();
            //var generatedCode = generator.TransformText();

            //string log = GetPart(generatedCode, "Log");
            //generatedCode = generatedCode.Replace(log, "");

            //string scripts = GetPart(generatedCode, "scripts");
            //generatedCode = generatedCode.Replace(scripts, "");
            //XElement xml = XElement.Parse(scripts);
            //string path_script;
            //foreach (var node in xml.Descendants("script"))
            //{
            //    if (output_name.Contains("\\"))
            //        path_script = output_name.Replace(output_name.Substring(output_name.LastIndexOf("\\") + 1), "") + node.Attribute("name").Value+".sql";
            //    else
            //        path_script = node.Attribute("name").Value + ".sql";
            //    System.IO.File.WriteAllText(path_script, node.Value);
            //}

            //string path_log;
            //if (output_name.Contains("\\"))
            //    path_log = output_name.Replace(output_name.Substring(output_name.LastIndexOf("\\") + 1), "") + "GenerationLog.txt";
            //else
            //    path_log = "GenerationLog.txt";
            //System.IO.File.WriteAllText(path_log, log);

            //System.IO.File.WriteAllText(output_name, generatedCode);
        }

        public string[] getAllType() { return all_types; }

        public string[] getAllGroup()
        {
            IEnumerable<XElement> xeles_group = from e in doc.Descendants(NP + "element")
                                                where e.Attribute(xmlns_xsi + "type").Value == "Grouping"
                                                select e;
            List<string> list_group = new List<string>();
            foreach (var ele in xeles_group)
            {
                list_group.Add(ele.Element(NP + "name").Value);
            }
            return list_group.ToArray();
        }

        public string[] getAllView()
        {
            IEnumerable<XElement> xeles_view = from e in doc.Descendants(NP + "view")
                                               select e;
            List<string> list_view = new List<string>();
            foreach (var ele in xeles_view)
            {
                list_view.Add(ele.Element(NP + "name").Value);
            }
            return list_view.ToArray();
        }

        [STAThread]
        static void Main(string[] args)
        {
            FileGenerator fileGenerator = new FileGenerator("D:\\documents\\INSA\\maidis\\vnext\\modele_vnext\\MODELE_VNEXT.xml");

            List<string> list = new List<string>();
            //string[] types = { "BusinessObject" };
            string[] types = list.ToArray();
            //string[] groups = { "Web" };
            string[] groups = list.ToArray();
            //string[] views = { "g��n��ration couches client" };
            //string[] views = { "g��n��ration couches serveur" };
            string[] views = list.ToArray();
            fileGenerator.Generate("..\\..\\Generated", "generated", fileGenerator.getAllType(), groups, views, "Maidis.VNext.", "..\\..\\Template\\Generator2.t4", "..\\..\\Template\\SQLScriptTemplate.t4", "..\\..\\Template\\ViewTemplate.t4");
        }
    }
}
