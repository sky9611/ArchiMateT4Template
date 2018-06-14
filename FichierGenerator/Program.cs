using FichierGenerator.Template;
using System.Collections.Generic;

namespace FichierGenerator
{
    public class Program
    {
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
        /// <summary>
        ///     Method to run the t4 template
        /// </summary>
        /// <param name="input_name"> The name of xml fichier which describe the architecture</param>
        /// <param name="output_name"> The name of the fichier created</param>
        public static void Generate(string input_name, string output_name, string[] types = null, string[] groups = null, string[] views = null)
        {
            var generator = new Generator();
            generator.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            generator.Session["input_name"] = input_name;
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

        //static void Main(string[] args)
        //{
        //    string[] types = { "BusinessObject" };
        //    string[] groups = { "Web" };
        //    string[] views = { "Digramme d'entit¨¦s ADF.NET" };
        //    Generate("D:\\documents\\INSA\\maidis\\vs\\Projet\\FichierGenerator\\FichierGenerator\\PLATEFORME_VNEXT.xml", "BusinessObjectenerated.cs",null, null, views);
        //}
    }
}
