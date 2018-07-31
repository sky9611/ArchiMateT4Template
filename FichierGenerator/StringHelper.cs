using System.Text.RegularExpressions;
using System.Globalization;

namespace FichierGenerator
{
    class StringHelper
    {

        // Method for creating the class name, deleting the spaces, special characters and uppercasing the string
        public static string UpperString(string name)
        {
            //name = Regex.Replace(name, @"\s\(.*\)", "");
            name = name.Replace(".", " ");
            name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            name = name.Replace(" ", "");
            name = Regex.Replace(name, @"[^\w\.@_]", "");
            return name[0].ToString().ToUpperInvariant() + name.Substring(1);
        }

        // Method for creating the object name, deleting the spaces, special characters and lowercasing the string
        public static string LowerString(string name)
        {
            //name = Regex.Replace(name, @"\s\(.*\)", "");
            name = name.Replace(".", " ");
            name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            name = name.Replace(" ", "");
            name = Regex.Replace(name, @"[^\w\.@_]", "");
            return name[0].ToString().ToLowerInvariant() + name.Substring(1);
        }

        // Method to delete line feed characters like \r, \n 
        public static string DocumentationTraitement(string document)
        {
            document = document.Replace("&#xD;", "");
            document = document.Replace("\r", " ");
            document = document.Replace("\n", " ");
            document = document.Replace("\t", " ");
            document = Regex.Replace(document, "\\s{2,}", " ");
            document = document.Replace("\"", "\\\"");
            return document;
        }
    }
}
