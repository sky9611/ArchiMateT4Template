using FichierGenerator.Template;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace FichierGenerator
{
    public class FileGenerator
    {
        string file_path;
        XElement doc;
        XNamespace NP;
        XNamespace xmlns_xsi = "http://www.w3.org/2001/XMLSchema-instance";

        public FileGenerator(string file_path)
        {
            this.file_path = file_path;
            doc = XElement.Load(file_path);
            NP = doc.GetDefaultNamespace();
        }

        public static readonly string[] all_types = {
            "BusinessActor",
            "BusinessCollaboration",
            "BusinessComponent",
            "BusinessEvent",
            "BusinessFunction",
            "BusinessProcess",
            "BusinessRole",
            "BusinessService",
            "BusinessObject",
            "BusinessInteraction",
            "BusinessInterface",
            "TechnologyCollaboration",
            "TechnologyFunction",
            "TechnologyInteraction",
            "TechnologyInterface",
            "TechnologyService",
            "ApplicationInterface",
            "ApplicationService",
            "ApplicationFunction",
            "ApplicationComponent",
            "ApplicationEvent",
            "ApplicationProcess"};

        public string File_path { get => file_path; set => file_path = value; }

        /// <summary>
        ///     Method to run the t4 template
        /// </summary>
        /// <param name="output_name"> The name of the fichier created</param>
        /// <param name="types"> The selected types </param>
        /// <param name="groups"> The selected groups </param>
        /// <param name="views"> The selected views </param>
        public void Generate(string output_name, string[] types = null, string[] groups = null, string[] views = null)
        {
            var generator = new Generator();
            generator.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            generator.Session["input_name"] = file_path;
            generator.Session["groups"] = groups;
            generator.Session["views"] = views;
            if (types==null)
                generator.Session["types"] = all_types;
            else
                generator.Session["types"] = types;
            generator.Initialize();
            var generatedCode = generator.TransformText();

            int start = generatedCode.IndexOf("<Log>");
            int end = generatedCode.IndexOf("</Log>"); 
            string log = generatedCode.Substring(start);
            generatedCode = generatedCode.Replace(log, "");
            System.IO.File.WriteAllText(output_name, generatedCode);
            string path_log;
            if (output_name.Contains("\\"))
                path_log = output_name.Replace(output_name.Substring(output_name.LastIndexOf("\\") + 1), "") + "GenerationLog.txt";
            else
                path_log = "GenerationLog.txt";
            System.IO.File.WriteAllText(path_log, log);
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

        //static void Main(string[] args)
        //{
        //    string[] types = { "BusinessObject" };
        //    string[] groups = { "Web" };
        //    string[] views = { "Digramme d'entit¨¦s ADF.NET" };
        //    Generate("D:\\documents\\INSA\\maidis\\vs\\Projet\\FichierGenerator\\FichierGenerator\\PLATEFORME_VNEXT.xml", "BusinessObjectenerated.cs",null, null, views);
        //}
    }
}
