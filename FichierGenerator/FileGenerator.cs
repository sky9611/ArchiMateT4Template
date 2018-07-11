using FichierGenerator.Template;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace FichierGenerator
{
    public class FileGenerator
    {
        ArchiDocument archiDocument;
        ArchiDocumentSerialized archiDocumentSerialized;
        XElement doc;
        XNamespace NP;
        XNamespace xmlns_xsi = "http://www.w3.org/2001/XMLSchema-instance";

        public FileGenerator(string file_path)
        {
            this.File_path = file_path;
            doc = XElement.Load(file_path);
            NP = doc.GetDefaultNamespace();
            archiDocument = new ArchiDocument(file_path);
            archiDocumentSerialized = new ArchiDocumentSerialized(archiDocument);
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

        public static T LoadObject<T>(string contents) where T : new()
        {
            T t = new T();
            // do whatever
            return t;
        }

        private string GetPart(string source, string part_name)
        {
            int start = source.IndexOf("<" + part_name + ">");
            int end = source.IndexOf("</" + part_name + ">");
            string result = source.Substring(start,end - start+ part_name.Length+3);
            return result;
        }

        /// <summary>
        ///     Method to run the t4 template
        /// </summary>
        /// <param name="output_name"> The name of the fichier created</param>
        /// <param name="types"> The selected types </param>
        /// <param name="groups"> The selected groups </param>
        /// <param name="views"> The selected views </param>
        /// <param name="name_space"> The namespace of generated class </param>
        public void Generate(string output_name, string[] types, string[] groups, string[] views, string name_space)
        {
            var my_types = (types != null) && (types.Length > 0) ? types : all_types;
            var my_groups = (groups != null) && (groups.Length > 0) ? groups : null;
            var my_views = (views != null) && (views.Length > 0) ? views : null;
            archiDocument.Update(my_types, my_groups, my_views, name_space);
            archiDocumentSerialized.Update(archiDocument);

            CustomCmdLineHost host = new CustomCmdLineHost();
            Engine engine = new Engine();
            host.TemplateFileValue = "..\\..\\Template\\Generator2.t4";
            //Read the text template.  
            string input = File.ReadAllText("..\\..\\Template\\Generator2.t4");
            var extensionPath = Path.GetDirectoryName(GetType().Assembly.Location) + Path.DirectorySeparatorChar;
            input = input.Replace("$(binDir)", extensionPath);
            
            
            host.Session = host.CreateSession();
            // Add parameter values to the Session:  
            host.Session["archiDocument"] = archiDocumentSerialized;
            //Transform the text template.  
            string generatedCode = engine.ProcessTemplate(input, host);

            foreach (CompilerError error in host.Errors)
            {
                Console.WriteLine(error.ToString());
            }

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

            System.IO.File.WriteAllText(output_name, generatedCode);
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

        static void Main(string[] args)
        {
            FileGenerator fileGenerator = new FileGenerator("D:\\documents\\INSA\\maidis\\vnext\\modele_vnext\\MODELE_VNEXT.xml");

            List<string> list = new List<string>();
            //string[] types = { "BusinessObject" };
            string[] types = list.ToArray();
            //string[] groups = { "Web" };
            string[] groups = list.ToArray();
            //string[] views = { "g¨¦n¨¦ration couches client" };
            string[] views = { "g¨¦n¨¦ration couches serveur" };
            //string[] views = list.ToArray();
            fileGenerator.Generate("generated.cs", fileGenerator.getAllType(), groups, views, "Maidis.VNext.");
        }
    }
}
