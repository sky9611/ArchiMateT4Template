﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace FichierGenerator.Template
{
    using Microsoft.VisualStudio.TextTemplating;
    using System;
    using System.Linq;
    using System.Xml.Linq;
    using System.Collections;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using FichierGenerator;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ApplicationServiceTemplate : ApplicationServiceTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 1 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\InitVar.ttinclude"

	string class_namespace = archiDocument.Class_namespace;

	// Map id_element - all elements related
	Dictionary<string, List<string>> dict_related_element = archiDocument.Dict_related_element;

	// list of group
	List<string> list_group = archiDocument.List_group;

	// list of elements
	List<string> list_element = archiDocument.List_element;

	// Map idProperty - PropertyName
	Dictionary<string, string> property_definition_map = archiDocument.Property_definition_map;

	// Map group_id - list_id_elements + list_id_interface
	Dictionary<string, Dictionary<string,List<string>>> dict_group = archiDocument.Dict_group;

	// Map group_id - namespace
	Dictionary<string, string> dict_group_name = archiDocument.Dict_group_name;

	// Map id_element - namespace
	Dictionary<string, string> dict_namespace = archiDocument.Dict_namespace;

	// Map id_element - group
	Dictionary<string, string> dict_element_group = archiDocument.Dict_element_group;

	// Map view_id - list_id_elements
	Dictionary<string, List<string>> dict_view = archiDocument.Dict_view;
	
	// Map identifier - element
	Dictionary<string, Element> dict_element = archiDocument.Dict_element;

	// Map identifier - relationship name
	Dictionary<Tuple<string, string>, string> dict_relationship = archiDocument.Dict_relationship;

	// MultiMap of id_element - [source|target] - [type de relation] - list_id_element
	Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> mmap_relationship = archiDocument.Mmap_relationship;

	// Map of specialization of class
	Dictionary<string, List<string>> mmap_specialization = archiDocument.Mmap_specialization;

	// MultiMap of association
	Dictionary<string, List<string>> mmap_association = archiDocument.Mmap_association;

	// MultiMap of group access (to generate using ...)
	Dictionary<string, List<string>> mmap_group_access = archiDocument.Mmap_group_access;

	// MultiMap of element access (a kind of relationship between elements)
	Dictionary<string, List<string>> mmap_element_access = archiDocument.Mmap_element_access;

	// List of representation
	List<string> list_representation = new List<string>();
	
	// List of data object
	List<string> list_data_object = new List<string>();

	// List of errors
	List<string> errors = archiDocument.Errors;

	// List of class created
	List<string> classes = archiDocument.Classes;

	List<string> list_group_new = archiDocument.List_group_new;

	Dictionary<string, List<string>> dict_using = archiDocument.Dict_using;

	string id_group;
	if (!dict_element_group.ContainsKey(id_element))
		id_group = "id-GroupeInConnu";
	else
		id_group = dict_element_group[id_element];

	Element ele = dict_element[id_element];
	string class_name = UpperString(ele.Class_name_);

            
            #line default
            #line hidden
            this.Write("using System.Collections.Generic;\r\n");
            
            #line 21 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
	
    class_name = ele.Class_name_;
	// Generate used namespaces
	List<string> list_using;
	if(mmap_group_access.TryGetValue(id_group, out list_using))
	{
		foreach(var id in list_using)
		{

            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 30 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dict_group_name[id]));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 31 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

		}
	}

	if(dict_using.TryGetValue(id_element, out list_using))
	{
		list_using = list_using.Distinct().ToList();
		foreach(var id in list_using)
		{

            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 41 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dict_group_name[id]));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 42 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 47 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dict_group_name[id_group]));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[Model(");
            
            #line 49 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ele.Type_));
            
            #line default
            #line hidden
            this.Write("Archimate, \"");
            
            #line 49 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(class_name));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 50 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

	// Generate attributes
	if( mmap_relationship.ContainsKey(id_element) )
	{
		if ( mmap_relationship[id_element].ContainsKey("source") && 
				mmap_relationship[id_element]["source"].ContainsKey("Realization") )
		{
			List<string> list_associated;
			if (mmap_relationship[id_element]["source"].TryGetValue("Realization", out list_associated))
			{
				foreach(var id_associated in list_associated)
				{
					if(dict_element.ContainsKey(id_associated))
					{
						Element element_associated = dict_element[id_associated];
						if(element_associated.Type_.Equals("Requirement")||element_associated.Type_.Equals("BusinessService"))
						{

            
            #line default
            #line hidden
            this.Write("\t[ReferenceModel(");
            
            #line 68 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element_associated.Type_));
            
            #line default
            #line hidden
            this.Write("Archimate, \"");
            
            #line 68 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element_associated.Name_));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 69 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

						}
					}
				}
			}
		}

		if ( mmap_relationship[id_element].ContainsKey("target") && 
				mmap_relationship[id_element]["target"].ContainsKey("Serving") )
		{
			List<string> list_associated;
			if (mmap_relationship[id_element]["target"].TryGetValue("Serving", out list_associated))
			{
				foreach(var id_associated in list_associated)
				{
					if(dict_element.ContainsKey(id_associated))
					{
						Element element_associated = dict_element[id_associated];
						if( ( element_associated.Properties_.ContainsKey("$type") && element_associated.Properties_["$type"].Equals("Macro")) ||
							element_associated.Type_.Equals("BusinessInteraction") ||
							element_associated.Type_.Equals("BusinessFunction") ||
							element_associated.Type_.Equals("BusinessProcess"))
						{

            
            #line default
            #line hidden
            this.Write("\t[ReferenceModel(");
            
            #line 93 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element_associated.Type_));
            
            #line default
            #line hidden
            this.Write("Archimate, \"");
            
            #line 93 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element_associated.Name_));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 94 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

						}
					}
				}
			}
		}

		List<string> list_access;
		if(mmap_relationship[id_element]["source"].TryGetValue("Access", out list_access))
		{
			foreach(var i in list_access)
			{
				Element element_associated = dict_element[i];
				if (element_associated.Type_.Equals("Contrat"))
				{
								

            
            #line default
            #line hidden
            this.Write("\t[Contract(\"");
            
            #line 111 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element_associated.Name_));
            
            #line default
            #line hidden
            this.Write("\",\"");
            
            #line 111 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(element_associated.Class_name_));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 112 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

				}
			}
		}
	}

	if (!mmap_specialization.Keys.Contains(id_element))
	{

            
            #line default
            #line hidden
            this.Write("\tpartial class ");
            
            #line 121 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ele.Class_name_));
            
            #line default
            #line hidden
            this.Write(" \r\n\t{\r\n");
            
            #line 123 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
	
	}
	else
	{
		List<string> list_parent_name = new List<string>();
		foreach(var e in mmap_specialization[id_element])
		{
			if(e.StartsWith("id"))
				list_parent_name.Add(dict_element[e].Class_name_);
			else
				list_parent_name.Add(e);
		}
		string str_parents = String.Join(", ", list_parent_name.Select(i => UpperString(i.ToString())).ToArray());
						

            
            #line default
            #line hidden
            this.Write("\tpartial class ");
            
            #line 138 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ele.Class_name_));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 138 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(str_parents));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 140 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

	}

	// Generate collection sur classe.
	if( mmap_relationship.ContainsKey(id_element) && 
		mmap_relationship[id_element].ContainsKey("source") && 
		mmap_relationship[id_element]["source"].ContainsKey("Aggregation") )
	{
		foreach (var idTarget in mmap_relationship[id_element]["source"]["Aggregation"])
		{
			Element elementTarget = dict_element[idTarget];
			if (elementTarget.Type_.Equals("ApplicationService"))
			{
				Tuple<string, string> tuple =  new Tuple<string, string>(id_element,idTarget);
				string var_name = dict_relationship.ContainsKey(tuple) ? LowerString(dict_relationship[tuple]) : LowerString(elementTarget.Class_name_);

            
            #line default
            #line hidden
            this.Write("\t\tList");
            
            #line 156 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UpperString(elementTarget.Class_name_)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 156 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(var_name));
            
            #line default
            #line hidden
            this.Write("_ ;\r\n\r\n");
            
            #line 158 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

			}
		}

		List<string> list;
		if(mmap_relationship[id_element]["source"].TryGetValue("Access", out list))
		{
			foreach (var idTarget in list)
			{
				Element elementTarget = dict_element[idTarget];
				if (elementTarget.Type_.Equals("ApplicationService"))
				{
					Tuple<string, string> tuple =  new Tuple<string, string>(id_element,idTarget);
					string var_name = dict_relationship.ContainsKey(tuple) ? LowerString(dict_relationship[tuple]) : LowerString(elementTarget.Class_name_);

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 173 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UpperString(elementTarget.Class_name_)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 173 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(var_name));
            
            #line default
            #line hidden
            this.Write("_ ;\r\n\r\n");
            
            #line 175 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

				}
			}
		}
	}

	// Generate référence d'une classe.
	if( mmap_association.ContainsKey(id_element))
	{
		foreach(var id_associated in mmap_association[id_element])
		{
			if(dict_element.ContainsKey(id_associated))
			{
				Element element_associated = dict_element[id_associated];
				if(element_associated.Equals("ApplicationService"))
				{
					Tuple<string, string> tuple =  new Tuple<string, string>(id_element,id_associated);
					string var_name = dict_relationship.ContainsKey(tuple) ? LowerString(dict_relationship[tuple]) : LowerString(element_associated.Class_name_);

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 194 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UpperString(element_associated.Class_name_)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 194 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(var_name));
            
            #line default
            #line hidden
            this.Write("_ ;\r\n\r\n");
            
            #line 196 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

				}
			}
		}
	}

	if (mmap_relationship.ContainsKey(id_element))
	{
		List<string> list_associated;
		if (mmap_relationship[id_element]["source"].TryGetValue("Access", out list_associated))
		{
			foreach(var id_associated in list_associated)
			{
				if(dict_element.ContainsKey(id_associated))
				{
					Element element_associated = dict_element[id_associated];
					if(element_associated.Type_.Equals("ApplicationProcess"))
					{
						Tuple<string, string> tuple =  new Tuple<string, string>(id_element,id_associated);
						string var_name = dict_relationship.ContainsKey(tuple) ? LowerString(dict_relationship[tuple]) : LowerString(element_associated.Class_name_);

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 217 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UpperString(element_associated.Class_name_)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 217 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(var_name));
            
            #line default
            #line hidden
            this.Write("_ ;\r\n\r\n");
            
            #line 219 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

					}
				}
			}
		}
	}

            
            #line default
            #line hidden
            this.Write("\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 228 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

	private bool isInSelectedGroups(string id, Dictionary<string, Dictionary<string,List<string>>> dict_group)
	{
		foreach(var g in dict_group.Keys)
		{
			foreach(var sg in dict_group[g].Keys)
				if(dict_group[g][sg].Contains(id))
					return true;
		}
		return false;
	}

	private bool isInSelectedViews(string id, Dictionary<string, List<string>> dict_view)
	{
		foreach(var v in dict_view.Keys)
		{
			if(dict_view[v].Contains(id))
				return true;
		}
		return false;
	}

	private void addImplementation(ref Dictionary<string, List<string>> mmap_specialization, string id_child, string parent)
	{
		if (!mmap_specialization.ContainsKey(id_child))
		{
			List<string> list_parent = new List<string>();
			list_parent.Add(parent);
			mmap_specialization.Add(id_child,list_parent);
		}
		else 
		{
			mmap_specialization[id_child].Add(parent);
		}
	}

	// Method for creating the class name, deleting the spaces, special characters and uppercasing the string
	public string UpperString(string name)
	{
		//name = Regex.Replace(name, @"\s\(.*\)", "");
		//name = name.Replace(".", " ");
        //name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        name = name.Replace(" ", "");
		name = Regex.Replace(name, @"[^\w\.@_]", "");
		return name[0].ToString().ToUpperInvariant() + name.Substring(1);
	}

	// Method for creating the object name, deleting the spaces, special characters and lowercasing the string
	public string LowerString(string name)
	{
		//name = Regex.Replace(name, @"\s\(.*\)", "");
		//name = name.Replace(".", " ");
        //name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        name = name.Replace(" ", "");
		name = Regex.Replace(name, @"[^\w\.@_]", "");
		return name[0].ToString().ToLowerInvariant() + name.Substring(1);
	}

	// Method to delete line feed characters like \r, \n 
	public string DocumentationTraitement(string document)
	{
		document = document.Replace("&#xD;","");
		document = document.Replace("\r"," ");
		document = document.Replace("\n"," ");
		document = document.Replace("\t"," ");
		document = Regex.Replace(document, "\\s{2,}", " ");
		document = document.Replace("\"","\\\"");
		return document;
	}

        
        #line default
        #line hidden
        
        #line 1 "D:\documents\INSA\maidis\vs\Projet\FichierGenerator\FichierGenerator\Template\ApplicationServiceTemplate.tt"

private global::FichierGenerator.ArchiDocumentSerialized _archiDocumentField;

/// <summary>
/// Access the archiDocument parameter of the template.
/// </summary>
private global::FichierGenerator.ArchiDocumentSerialized archiDocument
{
    get
    {
        return this._archiDocumentField;
    }
}

private string _id_elementField;

/// <summary>
/// Access the id_element parameter of the template.
/// </summary>
private string id_element
{
    get
    {
        return this._id_elementField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool archiDocumentValueAcquired = false;
if (this.Session.ContainsKey("archiDocument"))
{
    this._archiDocumentField = ((global::FichierGenerator.ArchiDocumentSerialized)(this.Session["archiDocument"]));
    archiDocumentValueAcquired = true;
}
if ((archiDocumentValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("archiDocument");
    if ((data != null))
    {
        this._archiDocumentField = ((global::FichierGenerator.ArchiDocumentSerialized)(data));
    }
}
bool id_elementValueAcquired = false;
if (this.Session.ContainsKey("id_element"))
{
    this._id_elementField = ((string)(this.Session["id_element"]));
    id_elementValueAcquired = true;
}
if ((id_elementValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("id_element");
    if ((data != null))
    {
        this._id_elementField = ((string)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class ApplicationServiceTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
