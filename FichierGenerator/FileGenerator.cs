using FichierGenerator.Template;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using Tools;

namespace FichierGenerator
{
    public class FileGenerator
    {
        ArchiDocument archiDocument;
        Dictionary<string, Element> dict_element;
        XElement doc;
        XNamespace NP;
        XNamespace xmlns_xsi = "http://www.w3.org/2001/XMLSchema-instance";

        // Dictionary project - directory
        Dictionary<string, string> dict_project_directory = new Dictionary<string, string>();

        public FileGenerator(string file_path)
        {
            this.File_path = file_path;
            doc = XElement.Load(file_path);
            NP = doc.GetDefaultNamespace();
            archiDocument = new ArchiDocument(dict_implementation_defaut, file_path);
            dict_element = archiDocument.Dict_element;
        }

        public string[] getAllElements()
        {
            List<string> list = new List<string>();
            foreach (var x in dict_element.Keys)
                list.Add(dict_element[x].Name_);
            return list.ToArray();
        }

        public static readonly Dictionary<string, string> dict_implementation_defaut = new Dictionary<string, string>{
            {ElementConstants.BusinessObject,"IBusinessObject"},
            {ElementConstants.Contract, "CContract"},
            {ElementConstants.ApplicationEvent, "EventArgs"},
            {ElementConstants.ApplicationComponent, "Component"},
            {ElementConstants.DataObject, "DAO"},
            {ElementConstants.ApplicationProcess, "UseCaseWorkflow"},
            {ElementConstants.ApplicationService, "UseCaseWorkflow"},
        };

        public static readonly string[] all_types = {
            ElementConstants.Product,
            ElementConstants.BusinessObject,
            ElementConstants.Contract,
            ElementConstants.Representation,
            ElementConstants.DataObject,
            ElementConstants.ApplicationInterface,
            ElementConstants.ApplicationService,
            ElementConstants.ApplicationFunction,
            ElementConstants.ApplicationComponent,
            ElementConstants.ApplicationEvent,
            ElementConstants.ApplicationProcess };

        public string File_path { get; set; }

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
            string[] types,
            string[] groups,
            string[] views,
            string[] elements,
            string name_space)
        {
            var my_types = (types != null) && (types.Length > 0) ? types : all_types;
            var my_groups = (groups != null) && (groups.Length > 0) ? groups : null;
            var my_views = (views != null) && (views.Length > 0) ? views : null;
            ArchiDocument archiDocumentTemp = archiDocument;
            archiDocumentTemp.Update(my_types, my_groups, my_views, elements, name_space);
            ArchiDocumentSerialized archiDocumentSerialized = new ArchiDocumentSerialized(archiDocumentTemp);

            //GenerateSolution(destinationFolder, archiDocumentTemp.Mmap_solution);

            foreach (var id_element in archiDocumentSerialized.List_element)
            {
                Element ele = dict_element[id_element];
                if (ele.Type_.Equals(ElementConstants.ApplicationEvent) && ele.Properties_.ContainsKey("Implementation"))
                    GenerateApplicationEvent(archiDocumentSerialized, id_element);

                //Directory.CreateDirectory("..\\..\\Generated\\Contract");

                switch (ele.Type_)
                {
                    case ElementConstants.Contract:
                        GenerateContract(archiDocumentSerialized, id_element);
                        break;
                    case ElementConstants.BusinessObject:
                        GenerateBusinessObject(archiDocumentSerialized, id_element);
                        break;
                    case ElementConstants.ApplicationService:
                        GenerateApplicationService(archiDocumentSerialized, id_element);
                        break;
                    case ElementConstants.ApplicationProcess:
                        GenerateApplicationProcess(archiDocumentSerialized, id_element);
                        break;
                    case ElementConstants.ApplicationInterface:
                        GenerateInterface(archiDocumentSerialized, id_element);
                        break;
                    case ElementConstants.Representation:
                        GenerateRepresentation(archiDocumentSerialized, id_element);
                        break;
                    case ElementConstants.DataObject:
                        GenerateRepresentation(archiDocumentSerialized, id_element);
                        break;
                }
            }
        }


        private void GenerateSolutionXaml(string solution_path, string solution_name, string id_solution)
        {
            var appXamlTemplate = new AppXamlTemplate();
            appXamlTemplate.Session = new TextTemplatingSession();
            appXamlTemplate.Session["solutionName"] = solution_name;
            List<string> list_FT;
            List<string> list_view = new List<string>();
            if (archiDocument.Mmap_relationship.ContainsKey(id_solution))
            {
                if (archiDocument.Mmap_relationship[id_solution]["source"].TryGetValue(RelaionshipConstants.Triggering, out list_FT))
                    foreach (var i in list_FT)
                        if (dict_element[i].Type_.Equals(ElementConstants.Representation))
                            list_view.Add(StringHelper.UpperString(dict_element[i].Class_name_) + ".xaml");
                if (archiDocument.Mmap_relationship[id_solution]["source"].TryGetValue(RelaionshipConstants.Flow, out list_FT))
                    foreach (var i in list_FT)
                        if (dict_element[i].Type_.Equals(ElementConstants.Representation))
                            list_view.Add(StringHelper.UpperString(dict_element[i].Class_name_) + ".xaml");
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
        }

        private void GenerateSolutionXamlCs(string solution_path, string solution_name, string launcher)
        {
            var appXamlCsTemplate = new AppXamlCsTemplate();
            appXamlCsTemplate.Session = new TextTemplatingSession();
            appXamlCsTemplate.Session["solutionName"] = solution_name;
            appXamlCsTemplate.Session["launcher"] = launcher;
            appXamlCsTemplate.Initialize();
            var generatedText = appXamlCsTemplate.TransformText();
            File.WriteAllText(solution_path + "\\App.xaml.cs", generatedText);
        }

        public void GenerateSolution(string destinationFolder, string solution_name)
        {
            System.Type type = Type.GetTypeFromProgID("VisualStudio.DTE.15.0");
            Dictionary<string, List<string>> dict = archiDocument.Mmap_solution;
            ArchiDocumentSerialized archiDocumentSerialized = new ArchiDocumentSerialized(archiDocument);

            var id_solution = dict.FirstOrDefault(x => dict_element[x.Key].Name_ == solution_name).Key;

            Object obj = System.Activator.CreateInstance(type, true);
            EnvDTE.DTE dte = (EnvDTE.DTE)obj;
            List<string> list_projet = dict[id_solution];
            solution_name = StringHelper.UpperString(solution_name);

            //dte.MainWindow.Visible = true; // optional if you want to See VS doing its thing*
            string path = destinationFolder;
            string solution_path = System.IO.Path.Combine(path, solution_name);

            List<string> list_launcher = new List<string>();
            List<string> list_temp;
            if (archiDocument.Mmap_relationship.ContainsKey(id_solution) &&
                    archiDocument.Mmap_relationship[id_solution]["source"].TryGetValue("Flow", out list_temp))
                foreach (var i in list_temp)
                    if (dict_element[i].Type_.Equals(ElementConstants.ApplicationFunction) ||
                            dict_element[i].Type_.Equals(ElementConstants.ApplicationProcess))
                        list_launcher.Add(StringHelper.UpperString(dict_element[i].Class_name_));
            string launcher = string.Join(",", list_launcher);

            // create the folder for the solution
            System.IO.Directory.CreateDirectory(solution_path);

            // Generate App.xaml
            GenerateSolutionXaml(solution_path, solution_name, id_solution);

            // Generate App.xaml.cs
            GenerateSolutionXamlCs(solution_path, solution_name, launcher);

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

                string project_path = Path.Combine(Path.GetFullPath(solution_path), projet_name);

                solution.AddFromTemplate(Path.GetFullPath(@"..\..\lib\ClassLibrary\csClassLibrary.vstemplate"),
                    project_path, projet_name);

                // Generate manifest
                string name = StringHelper.UpperString(dict_element[id_projet].Class_name_);
                var template = new DeploymentFileTemplate();
                template.Session = new TextTemplatingSession();
                template.Session["archiDocument"] = archiDocumentSerialized;
                template.Session["id_element"] = id_projet;
                template.Initialize();
                var generatedText = template.TransformText();
                File.WriteAllText(project_path + "\\" + name + ".manifest.xml", generatedText);

                string text = File.ReadAllText(project_path + "\\Properties\\AssemblyInfo.cs");
                Regex regex = new Regex(@""+ projet_name);
                text = regex.Replace(text, solution_name, 1, text.IndexOf(projet_name) + projet_name.Length);
                File.WriteAllText(project_path + "\\Properties\\AssemblyInfo.cs", text);

                dict_project_directory.Add(id_projet, Path.Combine(Path.GetFullPath(solution_path), projet_name));

                Thread.Sleep(1000);
            }

            dte.ExecuteCommand("File.SaveAll");
            dte.Quit();



            //// create a C# class library
            //solution.AddFromTemplate(@"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\ProjectTemplatesCache\CSharp\Windows\1033\ClassLibrary\csClassLibrary.vstemplate",
            //    @"C:\NewSolution\ClassLibrary", "ClassLibrary");

            // save and quit

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

        private void GenerateContract(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new ContractTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            //File.WriteAllText("..\\..\\Generated" + "\\"+ name + ".cs", generatedText);
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");
        }

        private void GenerateBusinessObject(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new BusinessObjectTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");
        }

        private void GenerateApplicationService(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new ApplicationServiceTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");
        }

        private void GenerateApplicationEvent(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new ApplicationEventTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");
        }

        private void GenerateApplicationProcess(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new ApplicationProcessTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");
        }

        private void GenerateInterface(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new InterfaceTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");
        }

        private void GenerateRepresentation(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new RepresentationTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");

            var viewTemplate = new ViewTemplate();
            viewTemplate.Session = new TextTemplatingSession();
            if (archiDocument.Dict_element_group.ContainsKey(id_element))
                viewTemplate.Session["groupName"] = StringHelper.UpperString(archiDocument.Dict_element[archiDocument.Dict_element_group[id_element]].Class_name_);
            else
                viewTemplate.Session["groupName"] = "UnknownGroup";
            viewTemplate.Session["viewName"] = StringHelper.UpperString(name);
            viewTemplate.Initialize();
            generatedText = viewTemplate.TransformText();
            WriteToFile(id_element, generatedText, ".xaml", "..\\..\\Generated");
        }

        private void GenerateDataObject(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            var template = new DataObjectTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            WriteToFile(id_element, generatedText, ".cs", "..\\..\\Generated");

            var sqlTemplate = new SQLTemplate();
            sqlTemplate.Session = new TextTemplatingSession();
            sqlTemplate.Session["archiDocument"] = archiDocumentSerialized;
            sqlTemplate.Session["id_element"] = id_element;
            sqlTemplate.Initialize();
            generatedText = sqlTemplate.TransformText();
            WriteToFile(id_element, generatedText, ".sql", "..\\..\\Generated");
        }

        private void WriteToFile(string id_element, string generatedText, string type, string destinationFolder)
        {
            string id_project;
            string file_name = StringHelper.UpperString(dict_element[id_element].Class_name_);
            if (archiDocument.Dict_element_project.TryGetValue(id_element, out id_project))
                try
                {
                    File.WriteAllText(dict_project_directory[id_project] + "\\" + file_name + type, generatedText);
                }
                catch
                {
                    // TO be changed after
                    File.WriteAllText(destinationFolder + "\\" + file_name + type, generatedText);
                }
            else
                // TO be changed after
                File.WriteAllText(destinationFolder + "\\" + file_name + type, generatedText);
        }

        static void Main(string[] args)
        {
            FileGenerator fileGenerator = new FileGenerator(@"..\..\lib\MODELE_VNEXT.xml");

            List<string> list = new List<string>();
            //string[] types = { ElementConstants.BusinessObject };
            string[] types = list.ToArray();
            //string[] groups = { "Web" };
            string[] groups = list.ToArray();
            //string[] views = { "g¨¦n¨¦ration couches client" };
            string[] views = { "Comportement applicatif" };
            string[] elements = fileGenerator.getAllElements();
            //string[] elements = list.ToArray();
            //string[] views = list.ToArray();
            //fileGenerator.GenerateSolution("..\\..\\Generated", "Amies VNext");
            fileGenerator.Generate("..\\..\\Generated", fileGenerator.getAllType(), groups, views, elements, "Maidis.VNext.");
        }
    }
}
