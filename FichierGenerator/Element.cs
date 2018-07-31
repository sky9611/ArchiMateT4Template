﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichierGenerator
{
    [Serializable]
    public class Element
    {
        public string Identifier_ { get; set; }
        public string Type_ { get; set; }
        public string Name_ { get; set; }
        public string Documentation_ { get; set; }
        public Dictionary<string, string> Properties_ { get; set; }
        public string Class_name_ { get; set; }

        public Element()
        {
        }

        public Element(string identifier_, string type_, string name_, string documentation_ = "", Dictionary<string, string> properties_ = null)
        {
            this.Identifier_ = identifier_;
            this.Type_ = type_;
            this.Name_ = name_;
            this.Class_name_ = name_;
            this.Documentation_ = documentation_;
            this.Properties_ = (properties_ == null) ? new Dictionary<string, string>() : properties_;
        }

        /*
		public override string ToString()
		{
			string s;
			s = "identifier: " + this.Identifier_ + "\r\nname: " + this.Name_ + "\r\ntype: " + this.Type_ + "\r\ndocumentation: " + this.Documentation_ + "\r\nproperties: ";
			if (this.Properties_ != null)
			{
				int i = 0;
				foreach (Property p in this.Properties_)
				{
					if (i != 0)
						s += "            ";
					s += p.name + " - " + p.value + "\r\n";
					i++;
				}
			}
			return s;
		}
		*/
    }

    public struct Property
    {
        public string name;
        public string value;
    }
}
