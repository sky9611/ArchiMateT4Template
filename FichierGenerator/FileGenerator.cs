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
            //"BusinessActor",
            //"BusinessCollaboration",
            //"BusinessComponent",
            //"BusinessEvent",
            //"BusinessFunction",
            //"BusinessRole",
            //"BusinessService",
            "BusinessObject",
            "Contract",
            "Representation",
            "DataObject",
            //"BusinessInteraction",
            //"BusinessInterface",
            //"TechnologyCollaboration",
            //"TechnologyFunction",
            //"TechnologyInteraction",
            //"TechnologyInterface",
            //"TechnologyService",
            //"ApplicationInterface",
            "ApplicationService",
            //"ApplicationFunction",
            "ApplicationComponent",
            "ApplicationEvent",
            "ApplicationProcess"};

        public string File_path { get => file_path; set => file_path = value; }

        private string GetPart(string source, string part_name)
        {
            int start = source.IndexOf("<" + part_name + ">");
            int end = source.IndexOf("</" + part_name + ">");
            string result = source.Substring(start,end - start+1);
            return result;
        }

        /// <summary>
        ///     Method to run the t4 template
        /// </summary>
        /// <param name="output_name"> The name of the fichier created</param>
        /// <param name="types"> The selected types </param>
        /// <param name="groups"> The selected groups </param>
        /// <param name="views"> The selected views </param>
        public void Generate(string output_name, string[] types, string[] groups, string[] views, string name_space)
        {
            var generator = new Generator();
            generator.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            generator.Session["input_name"] = file_path;
            generator.Session["groups"] = (groups != null) && (groups.Length > 0) ? groups : null;
            generator.Session["views"] = (views != null) && (views.Length > 0) ? views : null;
            generator.Session["name_space"] = (views != null) && (views.Length > 0) ? name_space : null;
            if (types==null||types.Length==0)
                generator.Session["types"] = all_types;
            else
                generator.Session["types"] = types;
            generator.Initialize();
            var generatedCode = generator.TransformText();

            string log = GetPart(generatedCode, "log");
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

        static void Main(string[] args)
        {
            FileGenerator fileGenerator = new FileGenerator("D:\\documents\\INSA\\maidis\\vnext\\modele_vnext\\MODELE_VNEXT.xml");

            List<string> list = new List<string>();
            //string[] types = { "BusinessObject" };
            string[] types = list.ToArray();
            //string[] groups = { "Web" };
            string[] groups = list.ToArray();
            string[] views = { "g��n��ration couches client" };
            //string[] views = list.ToArray();
            fileGenerator.Generate("generated.cs", fileGenerator.getAllType(), groups, views, "Maidis.VNext.");
        }
    }
}
