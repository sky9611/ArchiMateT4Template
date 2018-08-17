﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Globalization;
using Tools;

namespace FichierGenerator
{
    public class ArchiDocument
    {
        string class_namespace;

        // Dictionary of heritage
        Dictionary<string, string> dict_heritage = new Dictionary<string, string>();

        // Dictionary project(Application Composition) - project(Application Composition)
        Dictionary<string, HashSet<string>> dict_project_reference = new Dictionary<string, HashSet<string>>();

        // Dictionary view_id - view_name
        Dictionary<string, string> dict_view_name = new Dictionary<string, string>();

        // Dictionary group_id - element_types
        Dictionary<string, HashSet<string>> dict_group_types = new Dictionary<string, HashSet<string>>();

        // Dictionary view_id - element_types
        Dictionary<string, HashSet<string>> dict_view_types = new Dictionary<string, HashSet<string>>();

        // Dictionary element - solution
        Dictionary<string, string> dict_element_solution = new Dictionary<string, string>();

        // User settings for the implenmentation of different class
        Dictionary<string, string> dict_implementation = new Dictionary<string, string>();

        // Open the prototype document.
        XElement doc;

        // Get the nampespaces 
        XNamespace NP;
        XNamespace xmlns_xsi = "http://www.w3.org/2001/XMLSchema-instance";

        // Map id_element - all elements related
        Dictionary<string, List<string>> dict_related_element = new Dictionary<string, List<string>>();

        // Map id_element - projet(componant applicative) associé
        Dictionary<string, string> dict_element_project = new Dictionary<string, string>();

        // list of all project(application component)
        HashSet<string> hashset_project = new HashSet<string>();

        // list of group
        List<string> list_group = new List<string>();

        // list of elements
        List<string> list_element = new List<string>();

        // Map idProperty - PropertyName
        Dictionary<string, string> property_definition_map = new Dictionary<string, string>();

        // Map group_id - list_id_elements + list_id_interface
        Dictionary<string, Dictionary<string, List<string>>> dict_group = new Dictionary<string, Dictionary<string, List<string>>>();

        // Map group_id - namespace
        Dictionary<string, string> dict_group_name = new Dictionary<string, string>();

        // Map group_name - id_group
        Dictionary<string, string> dict_namespace = new Dictionary<string, string>();

        // Map id_element - group
        Dictionary<string, string> dict_element_group = new Dictionary<string, string>();

        // Map view_id - list_id_elements
        Dictionary<string, List<string>> dict_view = new Dictionary<string, List<string>>();

        // Map identifier - element
        Dictionary<string, Element> dict_element = new Dictionary<string, Element>();

        // Map identifier - relationship name
        Dictionary<Tuple<string, string>, string> dict_relationship = new Dictionary<Tuple<string, string>, string>();

        // MultiMap of id_element - [source|target] - [type de relation] - list_id_element
        Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> mmap_relationship = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();

        // MultiMap of composition
        Dictionary<string, List<string>> mmap_compostion = new Dictionary<string, List<string>>();

        // MultiMap of aggregation
        Dictionary<string, List<string>> mmap_aggregation = new Dictionary<string, List<string>>();

        // Map of specialization of class
        Dictionary<string, List<string>> mmap_specialization = new Dictionary<string, List<string>>();

        // MultiMap of association
        Dictionary<string, List<string>> mmap_association = new Dictionary<string, List<string>>();

        // MultiMap of group access (to generate using ...)
        Dictionary<string, List<string>> mmap_group_access = new Dictionary<string, List<string>>();

        // MultiMap of element access (a kind of relationship between elements)
        Dictionary<string, List<string>> mmap_element_access = new Dictionary<string, List<string>>();

        // List of representation
        List<Element> list_representation = new List<Element>();

        // List of data object
        List<Element> list_data_object = new List<Element>();

        // List of errors
        List<string> errors = new List<string>();

        // List of class created
        List<string> classes = new List<string>();

        // MultiMap of Produit - application composants (Solution - projects to be created)
        Dictionary<string, List<string>> mmap_solution = new Dictionary<string, List<string>>();

        List<string> types = new List<string>();

        IEnumerable<string> list_group_new = new List<string>();

        public string Class_namespace { get => class_namespace; set => class_namespace = value; }
        public XElement Doc { get => doc; set => doc = value; }
        public XNamespace NP1 { get => NP; set => NP = value; }
        public XNamespace Xmlns_xsi { get => xmlns_xsi; set => xmlns_xsi = value; }
        public Dictionary<string, List<string>> Dict_related_element { get => dict_related_element; set => dict_related_element = value; }
        public List<string> List_group { get => list_group; set => list_group = value; }
        public List<string> List_element { get => list_element; set => list_element = value; }
        public Dictionary<string, string> Property_definition_map { get => property_definition_map; set => property_definition_map = value; }
        public Dictionary<string, Dictionary<string, List<string>>> Dict_group { get => dict_group; set => dict_group = value; }
        public Dictionary<string, string> Dict_group_name { get => dict_group_name; set => dict_group_name = value; }
        public Dictionary<string, string> Dict_namespace { get => dict_namespace; set => dict_namespace = value; }
        public Dictionary<string, string> Dict_element_group { get => dict_element_group; set => dict_element_group = value; }
        public Dictionary<string, List<string>> Dict_view { get => dict_view; set => dict_view = value; }
        public Dictionary<string, Element> Dict_element { get => dict_element; set => dict_element = value; }
        public Dictionary<Tuple<string, string>, string> Dict_relationship { get => dict_relationship; set => dict_relationship = value; }
        public Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> Mmap_relationship { get => mmap_relationship; set => mmap_relationship = value; }
        public Dictionary<string, List<string>> Mmap_compostion { get => mmap_compostion; set => mmap_compostion = value; }
        public Dictionary<string, List<string>> Mmap_aggregation { get => mmap_aggregation; set => mmap_aggregation = value; }
        public Dictionary<string, List<string>> Mmap_specialization { get => mmap_specialization; set => mmap_specialization = value; }
        public Dictionary<string, List<string>> Mmap_association { get => mmap_association; set => mmap_association = value; }
        public Dictionary<string, List<string>> Mmap_group_access { get => mmap_group_access; set => mmap_group_access = value; }
        public Dictionary<string, List<string>> Mmap_element_access { get => mmap_element_access; set => mmap_element_access = value; }
        public List<Element> List_representation { get => list_representation; set => list_representation = value; }
        public List<Element> List_data_object { get => list_data_object; set => list_data_object = value; }
        public List<string> Errors { get => errors; set => errors = value; }
        public List<string> Classes { get => classes; set => classes = value; }
        public IEnumerable<string> List_group_new { get => list_group_new; set => list_group_new = value; }
        public List<string> Types { get => types; set => types = value; }
        public Dictionary<string, List<string>> Mmap_solution { get => mmap_solution; set => mmap_solution = value; }
        public Dictionary<string, string> Dict_element_project { get => dict_element_project; set => dict_element_project = value; }
        public HashSet<string> Hashset_project { get => hashset_project; set => hashset_project = value; }
        public Dictionary<string, string> Dict_implementation { get => dict_implementation; set => dict_implementation = value; }
        public Dictionary<string, string> Dict_element_solution { get => dict_element_solution; set => dict_element_solution = value; }
        public Dictionary<string, HashSet<string>> Dict_group_types { get => dict_group_types; set => dict_group_types = value; }
        public Dictionary<string, HashSet<string>> Dict_view_types { get => dict_view_types; set => dict_view_types = value; }
        public Dictionary<string, string> Dict_view_name { get => dict_view_name; set => dict_view_name = value; }
        public Dictionary<string, HashSet<string>> Dict_project_reference { get => dict_project_reference; set => dict_project_reference = value; }
        public Dictionary<string, string> Dict_heritage { get => dict_heritage; set => dict_heritage = value; }

        public ArchiDocument(Dictionary<string, string> dict_implementation, string path, string[] types = null, string[] groups = null, string[] views = null, string name_space = "Maidis.Vnext.")
        {
            this.dict_implementation = dict_implementation;
            class_namespace = name_space;
            this.doc = XElement.Load(path);
            NP = doc.GetDefaultNamespace();
            // Make the map of property definition
            IEnumerable<XElement> prop_defs = from element in doc.Descendants(NP + "propertyDefinition")
                                              select element;
            foreach (XElement ele in prop_defs)
            {
                property_definition_map.Add(ele.Attribute("identifier").Value, (ele.Element(NP + "name").Value != null) ? ele.Element(NP + "name").Value.Replace("att_", "") : "");
            }

            // Make the map of id - relationship name
            foreach (var rl in doc.Descendants(NP + "relationship"))
            {
                Tuple<string, string> tuple = new Tuple<string, string>(rl.Attribute("source").Value, rl.Attribute("target").Value);
                if (rl.Element(NP + "name") != null && !dict_relationship.ContainsKey(tuple))
                    dict_relationship.Add(tuple, rl.Element(NP + "name").Value);
            }

            // Make the dictionary id_view - view_name
            IEnumerable<XElement> xeles_view = from e in doc.Descendants(NP + "view")
                                               select e;
            foreach (var ele in xeles_view)
                dict_view_name.Add(ele.Attribute("identifier").Value, ele.Element(NP + "name").Value);

            // Make the map of id - element
            foreach (var ele in doc.Descendants(NP + "element"))
            {
                Dictionary<string, string> properties = new Dictionary<string, string>();
                if (ele.Descendants(NP + "properties") != null)
                    foreach (var i in ele.Descendants(NP + "property"))
                        properties.Add(property_definition_map[i.Attribute("propertyDefinitionRef").Value], i.Element(NP + "value").Value);
                Element element = new Element
                {
                    Identifier_ = ele.Attribute("identifier").Value,
                    Name_ = (ele.Element(NP + "name") != null) ? ele.Element(NP + "name").Value : "",
                    Documentation_ = (ele.Element(NP + "documentation") != null) ? ele.Element(NP + "documentation").Value : "",
                    Type_ = ele.Attribute(xmlns_xsi + "type").Value
                };
                element.Properties_ = properties;
                if (properties.Keys.Contains("Implementation") && properties["Implementation"].Length > 0)
                    element.Class_name_ = properties["Implementation"];
                else
                    element.Class_name_ = element.Name_;
                if (element.Type_.Equals(ElementConstants.ApplicationComponent)) hashset_project.Add(element.Identifier_);
                dict_element.Add(element.Identifier_, element);
            }

            // Make the map of relationship
            foreach (var ele in doc.Descendants(NP + "relationship"))
            {
                string relationship_type = ele.Attribute(xmlns_xsi + "type").Value;
                string id_source = ele.Attribute("source").Value;
                string id_target = ele.Attribute("target").Value;
                Dictionary<string, Dictionary<string, List<string>>> dict_source_relationship;
                Dictionary<string, Dictionary<string, List<string>>> dict_target_relationship;
                if (mmap_relationship.TryGetValue(id_source, out dict_source_relationship))
                {
                    List<string> list;
                    if (dict_source_relationship["source"].TryGetValue(relationship_type, out list))
                    {
                        list.Add(id_target);
                        if (relationship_type.Equals(RelaionshipConstants.Access) && ele.Attribute("accessType").Equals("ReadWrite"))
                        {
                            List<string> list2;
                            if (dict_source_relationship["target"].TryGetValue(relationship_type, out list2))
                            {
                                list2.Add(id_target);
                                dict_source_relationship["target"][relationship_type] = list2;
                            }
                            else
                            {
                                list2 = new List<string>();
                                list2.Add(id_target);
                                dict_source_relationship["target"].Add(relationship_type, list2);
                            }
                        }
                        dict_source_relationship["source"][relationship_type] = list;
                    }
                    else
                    {
                        list = new List<string>();
                        list.Add(id_target);
                        if (relationship_type.Equals(RelaionshipConstants.Access) && ele.Attribute("accessType").Equals("ReadWrite"))
                        {
                            List<string> list2;
                            if (dict_source_relationship["target"].TryGetValue(relationship_type, out list2))
                            {
                                list2.Add(id_target);
                                dict_source_relationship["target"][relationship_type] = list2;
                            }
                            else
                            {
                                list2 = new List<string>();
                                list2.Add(id_target);
                                dict_source_relationship["target"].Add(relationship_type, list2);
                            }
                        }
                        dict_source_relationship["source"].Add(relationship_type, list);
                    }
                    mmap_relationship[id_source] = dict_source_relationship;
                }
                else
                {
                    dict_source_relationship = new Dictionary<string, Dictionary<string, List<string>>>();
                    Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
                    List<string> list = new List<string>();
                    list.Add(id_target);
                    dict2.Add(relationship_type, list);
                    dict_source_relationship.Add("source", dict2);
                    dict_source_relationship.Add("target", new Dictionary<string, List<string>>());
                    if (relationship_type.Equals(RelaionshipConstants.Access) && ele.Attribute("accessType").Equals("ReadWrite"))
                    {
                        List<string> list2 = new List<string>();
                        list2.Add(id_target);
                        dict_source_relationship["target"].Add(relationship_type, list2);
                    }
                    mmap_relationship.Add(id_source, dict_source_relationship);
                }

                if (mmap_relationship.TryGetValue(id_target, out dict_target_relationship))
                {
                    List<string> list;
                    if (dict_target_relationship["target"].TryGetValue(relationship_type, out list))
                    {
                        list.Add(id_source);
                        if (relationship_type.Equals(RelaionshipConstants.Access) && ele.Attribute("accessType").Equals("ReadWrite"))
                        {
                            List<string> list2;
                            if (dict_target_relationship["source"].TryGetValue(relationship_type, out list2))
                            {
                                list2.Add(id_source);
                                dict_target_relationship["source"][relationship_type] = list2;
                            }
                            else
                            {
                                list2 = new List<string>();
                                list2.Add(id_source);
                                dict_target_relationship["source"].Add(relationship_type, list2);
                            }
                        }
                        dict_target_relationship["target"][relationship_type] = list;
                    }
                    else
                    {
                        list = new List<string>();
                        list.Add(id_source);
                        if (relationship_type.Equals(RelaionshipConstants.Access) && ele.Attribute("accessType").Equals("ReadWrite"))
                        {
                            List<string> list2;
                            if (dict_target_relationship["source"].TryGetValue(relationship_type, out list2))
                            {
                                list2.Add(id_source);
                                dict_target_relationship["source"][relationship_type] = list2;
                            }
                            else
                            {
                                list2 = new List<string>();
                                list2.Add(id_source);
                                dict_target_relationship["source"].Add(relationship_type, list2);
                            }
                        }
                        dict_target_relationship["target"].Add(relationship_type, list);
                    }
                    mmap_relationship[id_target] = dict_target_relationship;
                }
                else
                {
                    dict_target_relationship = new Dictionary<string, Dictionary<string, List<string>>>();
                    Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
                    List<string> list = new List<string>();
                    list.Add(id_source);
                    dict2.Add(relationship_type, list);
                    dict_target_relationship.Add("target", dict2);
                    dict_target_relationship.Add("source", new Dictionary<string, List<string>>());
                    if (relationship_type.Equals(RelaionshipConstants.Access) && ele.Attribute("accessType").Equals("ReadWrite"))
                    {
                        List<string> list2 = new List<string>();
                        list2.Add(id_source);
                        dict_target_relationship["source"].Add(relationship_type, list2);
                    }
                    mmap_relationship.Add(id_target, dict_target_relationship);
                }
            }

            
            foreach(var id in dict_element.Keys)
            {
                // Add function relations
                if (dict_element[id].Type_.Equals(ElementConstants.ApplicationFunction))
                {
                    string id_first_function = GetFirstFunction(id);
                    string id_element = CallFunctionElement(id_first_function);
                    AddFunctionToElement(id_first_function, id_element);
                }

                // Make the dict id_element - project
                string id_project = FindProjectByElement(id);
                dict_element_project.Add(id, id_project);

                // Make the heritage dictionary 
                string id_parent = GetParentElement(id);
                if (id_parent != null)
                    dict_heritage.Add(id, id_parent);
            }
            // Add properties depends on heritage relationship
            foreach(var i in dict_heritage.Keys)
            {
                Element child = dict_element[i];
                string id_root = GetRootElement(i);
                if (id_root!=i)
                {
                    Element root = dict_element[id_root];
                    foreach (var p in root.Properties_.Keys)
                    {
                        if (!child.Properties_.ContainsKey(p))
                            child.Properties_.Add(p, root.Properties_[p]);
                    }
                }
            }

            // Make the map of views
            foreach (var ele in xeles_view)
            {
                string id = ele.Attribute("identifier").Value;
                List<string> list_ele_child = new List<string>();
                List<string> list_group_child = new List<string>();
                findAllElement(dict_element, xmlns_xsi, NP, doc, ele, ref list_ele_child, ref list_group_child);
                if (!dict_view.ContainsKey(id))
                    dict_view.Add(id, list_ele_child);
                HashSet<string> set_type;
                if (dict_view_types.TryGetValue(id, out set_type))
                {
                    foreach (var i in list_ele_child)
                        set_type.Add(dict_element[i].Type_);
                }
                else
                {
                    set_type = new HashSet<string>();
                    foreach (var i in list_ele_child)
                        set_type.Add(dict_element[i].Type_);
                    dict_view_types.Add(id, set_type);
                }
            }

            // Make the dict id_element - project
            //foreach (var id_project in hashset_project)
            //{
            //    List<string> list_element = new List<string>();
            //    if (mmap_relationship.ContainsKey(id_project))
            //    {
            //        //if (mmap_relationship[id_project]["source"].TryGetValue(RelaionshipConstants.Association, out list_element))
            //        //    foreach (var i in list_element)
            //        //        if (dict_element[i].Type_.Equals(ElementConstants.BusinessObject))
            //        //            dict_element_project.Add(i, id_project);
            //        //if (mmap_relationship[id_project]["source"].TryGetValue(RelaionshipConstants.Aggregation, out list_element))
            //        //    foreach (var i in list_element)
            //        //        if (dict_element[i].Type_.Equals(ElementConstants.ApplicationInterface))
            //        //            dict_element_project.Add(i, id_project);
            //        //if (mmap_relationship[id_project]["target"].TryGetValue(RelaionshipConstants.Assignment, out list_element))
            //        //    foreach (var i in list_element)
            //        //        if (dict_element[i].Type_.Equals(ElementConstants.ApplicationService))
            //        //            dict_element_project.Add(i, id_project);
            //        //if (mmap_relationship[id_project]["target"].TryGetValue(RelaionshipConstants.Access, out list_element))
            //        //    foreach (var i in list_element)
            //        //        if (dict_element[i].Type_.Equals(ElementConstants.DataObject))
            //        //            dict_element_project.Add(i, id_project);
            //        if (mmap_relationship[id_project]["source"].TryGetValue(RelaionshipConstants.Composition, out list_element))
            //            foreach (var i in list_element)
            //                if (!dict_element_project.ContainsKey(i))
            //                    dict_element_project.Add(i, id_project);
            //    }
            //}
            

            // Make the dictionary of project references
            foreach (var id_project in hashset_project)
            {
                List<string> list_element = new List<string>();
                if (mmap_relationship.ContainsKey(id_project))
                {
                    if (mmap_relationship[id_project]["source"].TryGetValue(RelaionshipConstants.Aggregation, out list_element))
                        foreach (var i in list_element)
                            if (dict_element[i].Type_.Equals(ElementConstants.ApplicationComponent))
                            {
                                // HashSet to store the references of the project
                                HashSet<string> set;
                                if (dict_project_reference.TryGetValue(id_project, out set))
                                    set.Add(i);
                                else
                                {
                                    set = new HashSet<string>();
                                    set.Add(i);
                                    dict_project_reference.Add(id_project, set);
                                }
                            }

                    if (mmap_relationship[id_project]["target"].TryGetValue(RelaionshipConstants.Serving, out list_element))
                        foreach (var i in list_element)
                            if (dict_element[i].Type_.Equals(ElementConstants.ApplicationComponent))
                            {
                                // HashSet to store the references of the project
                                HashSet<string> set;
                                if (dict_project_reference.TryGetValue(id_project, out set))
                                    set.Add(i);
                                else
                                {
                                    set = new HashSet<string>();
                                    set.Add(i);
                                    dict_project_reference.Add(id_project, set);
                                }
                            }
                }
            }

            

            
            // Make the mmap of solution - projects
            foreach (var id in dict_element.Keys)
            {
                if (dict_element[id].Type_.Equals(ElementConstants.Product))
                {
                    List<string> list;
                    List<string> list_projet = new List<string>();
                    mmap_solution.Add(id, list_projet);
                    if ( mmap_relationship.ContainsKey(id) &&
                         mmap_relationship[id]["source"].TryGetValue(RelaionshipConstants.Association, out list))
                    {
                        foreach (var id_element in list)
                            if (dict_element[id_element].Type_.Equals(ElementConstants.ApplicationComponent))
                                list_projet.Add(id_element);
                    }
                }
            }

            // Handle the "$interface" property
            foreach(var id in dict_element.Keys)
            {
                Element element = dict_element[id];
                if (element.Properties_.ContainsKey("$Interface"))
                {
                    // The project name which element belongs to
                    string project_id;
                    if (dict_element_project.TryGetValue(id, out project_id))
                    {
                        string project_name = dict_element[project_id].Class_name_;

                        //Create new application component element and add it to dict_element
                        Element new_project = new Element();
                        new_project.Name_ = project_name + ".Interface";
                        new_project.Class_name_ = project_name + ".Interface"; 
                        new_project.Identifier_ = project_name + ".Interface";
                        new_project.Type_ = ElementConstants.ApplicationComponent;
                        dict_element.Add(new_project.Identifier_, new_project);
                        hashset_project.Add(new_project.Identifier_);

                        // Add new project to the references of implementation project 
                        HashSet<string> set; // Hashset to store the references
                        if (dict_project_reference.TryGetValue(project_id, out set))
                        {
                            set.Add(new_project.Identifier_);
                        }
                        else
                        {
                            set = new HashSet<string>();
                            set.Add(new_project.Identifier_);
                            dict_project_reference.Add(project_id, set);
                        }

                        // Add new project to the solution
                        try
                        {
                            string solution_id = mmap_solution.First(x => x.Value.Contains(project_id)).Key;
                            mmap_solution[solution_id].Add(new_project.Identifier_);
                        }
                        catch { }

                        // Remove ancient project references and add the news
                        List<string> keys = dict_project_reference.Keys.ToList();
                        foreach (var i in keys)
                        {
                            if (dict_project_reference[i].Contains(project_id))
                            {
                                dict_project_reference[i].Remove(project_id);
                                dict_project_reference[i].Add(new_project.Identifier_);
                            }

                        }

                        //Create new interface element and add it to dict_element
                        Element new_interface = new Element();
                        new_interface.Name_ = "I"+ element.Class_name_;
                        new_interface.Class_name_ = new_project.Name_;
                        new_interface.Identifier_ = new_project.Name_;
                        new_interface.Type_ = ElementConstants.ApplicationInterface;
                        dict_element.Add(new_interface.Identifier_, new_interface);

                        // Move functions into interface
                        if (element.Type_.Equals(ElementConstants.ApplicationProcess))
                        {
                            Dictionary<string, Dictionary<string, List<string>>> dict;
                            if (mmap_relationship.TryGetValue(id, out dict))
                            {
                                List<string> list;
                                if (dict["source"].TryGetValue("Function", out list))
                                {
                                    foreach (var i in list)
                                        if (mmap_relationship.ContainsKey(new_interface.Identifier_))
                                            AddFunctionToElement(i, new_interface.Identifier_);
                                        else
                                        {
                                            Dictionary<string, Dictionary<string, List<string>>> dict2 = new Dictionary<string, Dictionary<string, List<string>>>();
                                            Dictionary<string, List<string>> dict_source = new Dictionary<string, List<string>>();
                                            dict_source.Add("Function", new List<string>(list));
                                            dict2.Add("source", dict_source);
                                            dict2.Add("target", new Dictionary<string, List<string>>());
                                            mmap_relationship.Add(new_interface.Identifier_, dict2);
                                        }

                                    dict.Remove("Function");
                                }
                            }
                        }
                    }
                }
            }

            // Make the dictionary id_element - solution
            foreach (var id_element in dict_element.Keys)
            {
                Dictionary<string, Dictionary<string, List<string>>> dict;
                if (mmap_relationship.TryGetValue(id_element, out dict))
                {
                    List<string> list;
                    if (dict["target"].TryGetValue(RelaionshipConstants.Aggregation, out list))
                        foreach (var i in list)
                            if (dict_element[i].Type_.Equals(ElementConstants.Representation) ||
                                dict_element[i].Type_.Equals(ElementConstants.ApplicationService))
                                dict_element_solution.Add(id_element, i);
                    if (dict["target"].TryGetValue(RelaionshipConstants.Flow, out list))
                        foreach (var i in list)
                            if (dict_element[i].Type_.Equals(ElementConstants.Representation) ||
                                dict_element[i].Type_.Equals(ElementConstants.ApplicationProcess))
                                dict_element_solution.Add(id_element, i);
                }
            }
            foreach (var id_element in dict_element_project.Keys)
            {
                if (!dict_element_solution.ContainsKey(id_element))
                {
                    string solution = null;
                    try
                    {
                        solution = mmap_solution.First(x => x.Value.Contains(dict_element_project[id_element])).Key;
                    }
                    catch
                    {

                    }
                    if (solution!=null)
                        dict_element_solution.Add(id_element, solution);
                }

            }

            // Make the map of group name
            IEnumerable<XElement> xeles_all_group = from e in doc.Descendants(NP + "element")
                                                    where e.Attribute(xmlns_xsi + "type").Value == ElementConstants.Grouping
                                                    select e;
            foreach (var ele in xeles_all_group)
            {
                dict_group_name.Add(ele.Attribute("identifier").Value, class_namespace + UpperString(ele.Element(NP + "name").Value));
            }

            // Make the map of all groups
            dict_group_name.Add("id-GroupeUnConnu", class_namespace + "Unconnu");
            Dictionary<string, List<string>> dict_temp = new Dictionary<string, List<string>>();
            List<string> list_element_temp = new List<string>();
            List<string> list_interface_temp = new List<string>();
            dict_temp.Add("class", list_element_temp);
            dict_temp.Add("interface", list_interface_temp);
            dict_group.Add("id-GroupeUnConnu", dict_temp);
            IEnumerable<XElement> xeles_group = from e in doc.Descendants(NP + "element")
                                                where e.Attribute(xmlns_xsi + "type").Value == ElementConstants.Grouping
                                                select e;
            foreach (var ele in xeles_group)
            {
                if (!dict_namespace.ContainsKey(ele.Element(NP + "name").Value))
                    dict_namespace.Add(ele.Element(NP + "name").Value, ele.Attribute("identifier").Value);
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                List<string> list_target = new List<string>();
                List<string> list_interface = new List<string>();
                IEnumerable<XElement> xeles_target = from e in doc.Descendants(NP + "relationship")
                                                     where e.Attribute("source").Value == ele.Attribute("identifier").Value && e.Attribute(xmlns_xsi + "type").Value == RelaionshipConstants.Composition
                                                     select e;
                if (xeles_target != null && xeles_target.Count() != 0)
                {
                    foreach (var eg in xeles_target)
                    {
                        if (dict_element[eg.Attribute("target").Value].Type_.Equals(ElementConstants.ApplicationInterface))
                            list_interface.Add(eg.Attribute("target").Value);
                        else
                            list_target.Add(eg.Attribute("target").Value);
                        if (!dict_element_group.Keys.Contains(eg.Attribute("target").Value))
                            dict_element_group.Add(eg.Attribute("target").Value, ele.Attribute("identifier").Value);
                    }
                    dict.Add("class", list_target);
                    dict.Add("interface", list_interface);
                    dict_group.Add(ele.Attribute("identifier").Value, dict);

                    HashSet<string> set_type = new HashSet<string>();
                    if (list_interface.Count() > 0)
                        set_type.Add(ElementConstants.ApplicationInterface);
                    foreach (var i in list_target)
                        set_type.Add(dict_element[i].Type_);
                    dict_group_types.Add(ele.Attribute("identifier").Value, set_type);
                }
            }
        }

        private string GetRootElement(string i)
        {
            string id_parent;
            if (dict_heritage.TryGetValue(i, out id_parent))
            {
                while (dict_heritage.ContainsKey(id_parent))
                {
                    id_parent = dict_heritage[id_parent];
                }
                return id_parent;
            }                
            else
                return i;
        }

        private string GetParentElement(string id)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict;
            if (mmap_relationship.TryGetValue(id, out dict))
            {
                List<string> list_temp;
                if (mmap_relationship[id]["source"].TryGetValue(RelaionshipConstants.Specialization, out list_temp))
                {
                    foreach (var i in list_temp)
                        if (dict_element.ContainsKey(i) && dict_element[i].Type_.Equals(dict_element[id].Type_))
                            return i;
                }
            }
            return null;
        }

        private void AddFunctionToElement(string id_first_function, string id_elementCalled)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();
            if (mmap_relationship.TryGetValue(id_elementCalled, out dict))
            {
                List<string> list_temp;
                if (mmap_relationship[id_elementCalled]["source"].TryGetValue("Function", out list_temp))
                {
                    list_temp.Add(id_first_function);
                }
                else
                {
                    list_temp = new List<string>();
                    list_temp.Add(id_first_function);
                    mmap_relationship[id_elementCalled]["source"].Add("Function", list_temp);
                }
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(id_first_function);
                Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
                dict2.Add("Function", list);
                dict.Add("source", dict2);
                mmap_relationship.Add(id_elementCalled, dict);
            }
        }


        private string CallFunctionElement(string id_function)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict;
            string result="";
            int n = 0;
            if (mmap_relationship.TryGetValue(id_function, out dict))
            {
                List<string> list;

                if (dict["target"].TryGetValue(RelaionshipConstants.Composition, out list))
                {
                    foreach (var i in list)
                        if (dict_element[i].Type_.Equals(ElementConstants.ApplicationProcess))
                        {
                            n++;
                            result = i;
                        }
                }

                if (dict["target"].TryGetValue(RelaionshipConstants.Triggering, out list))
                {
                    foreach (var i in list)
                        if (dict_element[i].Type_.Equals(ElementConstants.ApplicationProcess))
                        {
                            n++;
                            result = i;
                        }
                }

                if (dict["target"].TryGetValue(RelaionshipConstants.Flow, out list))
                {
                    foreach (var i in list)
                        if (dict_element[i].Type_.Equals(ElementConstants.ApplicationProcess))
                        {
                            n++;
                            result = i;
                        }
                }
            }
            if (n > 1)
                errors.Add("Function \"" + dict_element[id_function] + "\" has been called by more than one process");
            if (result != "")
                return result;
            else
                return null;
        }

        private string GetFirstFunction(string id)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict;
            if (mmap_relationship.TryGetValue(id, out dict))
            {
                List<string> list_flow;
                if (dict["target"].TryGetValue(RelaionshipConstants.Flow, out list_flow))
                {
                    foreach (var i in list_flow)
                        if (dict_element[i].Type_.Equals(ElementConstants.ApplicationFunction))
                            if (CallFunctionElement(i)==null)
                                return GetFirstFunction(i);
                            else
                                return i;
                }
                else
                    return id;
            }

            return id;
        }

        public void Update(string[] views)
        {
            //IEnumerable<XElement> xeles_view = from e in doc.Descendants(NP + "view")
            //                                   where views.Contains(e.Element(NP + "name").Value)
            //                                   select e;
            //foreach (var ele in xeles_view)
            //{
            //    List<string> list_ele_child = new List<string>();
            //    List<string> list_group_child = new List<string>();
            //    findAllElement(dict_element, xmlns_xsi, NP, doc, ele, ref list_ele_child, ref list_group_child);
            //    if (!dict_view.ContainsKey(ele.Attribute("identifier").Value))
            //        dict_view.Add(ele.Attribute("identifier").Value, list_ele_child);
            //    list_group.AddRange(list_group_child);
            //    list_element.AddRange(list_ele_child);
            //}
            List<string> keys = dict_view.Keys.ToList();
            foreach (var i in keys)
                if (!views.Contains(dict_view_name[i]))
                    dict_view.Remove(i);
        }

        public void Update(string[] types, string[] groups, string[] views, string[] elements, string name_space)
        {
            this.class_namespace = name_space;
            this.types = types.ToList();
            // Make the map of views
            IEnumerable<XElement> xeles_view = from e in doc.Descendants(NP + "view")
                                               where views.Contains(e.Element(NP + "name").Value)
                                               select e;
            foreach (var ele in xeles_view)
            {
                List<string> list_ele_child = new List<string>();
                List<string> list_group_child = new List<string>();
                findAllElement(dict_element, xmlns_xsi, NP, doc, ele, ref list_ele_child, ref list_group_child);
                if (!dict_view.ContainsKey(ele.Attribute("identifier").Value))
                    dict_view.Add(ele.Attribute("identifier").Value, list_ele_child);
                list_group.AddRange(list_group_child);
                list_element.AddRange(list_ele_child);
            }

            // Make the list of related group and elements
            if (groups != null)
            {
                foreach (var g in groups)
                {
                    var key = dict_namespace[g];
                    if (dict_group.ContainsKey(key))
                        list_group.Add(key);
                }
            }
            foreach (var ele in dict_view.Keys)
            {
                foreach (var i in dict_view[ele])
                {
                    var id_group = dict_group.FirstOrDefault(x => x.Value["class"].Contains(i) || x.Value["interface"].Contains(i)).Key;
                    if (id_group != null)
                        list_group.Add(id_group);
                }
            }
            list_group = list_group.Distinct().ToList();

            List_group_new = list_group.Intersect(dict_group.Keys);
            foreach (var g in List_group_new)
            {
                if (dict_group.ContainsKey(g))
                {
                    list_element.AddRange(dict_group[g]["class"]);
                    list_element.AddRange(dict_group[g]["interface"]);
                }

            }
            list_element = list_element.Distinct().ToList();

            // Consider the types
            if (elements != null && elements.Count()>0)
                list_element.RemoveAll(x => !elements.Contains(dict_element[x].Name_));
            list_element.RemoveAll(x => !types.Contains(dict_element[x].Type_));
            list_element.RemoveAll(x => !dict_element.ContainsKey(x));

            foreach (var e in list_element)
            {
                if (!dict_element_group.ContainsKey(e))
                {
                    if (!list_group.Contains("id-GroupeUnConnu"))
                        list_group.Add("id-GroupeUnConnu");
                    if (dict_element[e].Type_.Equals(ElementConstants.ApplicationInterface))
                        dict_group["id-GroupeUnConnu"]["interface"].Add(e);
                    else
                        dict_group["id-GroupeUnConnu"]["class"].Add(e);
                }
            }

            // Make the list of scripts
            foreach (var ele in list_element)
            {
                if (dict_element[ele].Type_.Equals(ElementConstants.DataObject))
                    list_data_object.Add(dict_element[ele]);
            }

            // Make the list of Rresentation
            foreach (var ele in list_element)
            {
                if (dict_element[ele].Type_.Equals(ElementConstants.Representation))
                    list_representation.Add(dict_element[ele]);
            }

            // Make the map of relationship
            foreach (var ele in list_element)
            {
                IEnumerable<XElement> xeles_related = from e in doc.Descendants(NP + "relationship")
                                                      where e.Attribute("source").Value.Equals(ele) ||
                                                            e.Attribute("target").Value.Equals(ele)
                                                      select e;
                foreach (var i in xeles_related)
                {
                    if (i.Attribute("source").Value.Equals(ele))
                    {
                        List<string> list;
                        if (dict_related_element.TryGetValue(ele, out list))
                        {
                            list.Add(i.Attribute("target").Value);
                        }
                        else
                        {
                            list = new List<string>();
                            list.Add(i.Attribute("target").Value);
                            dict_related_element[ele] = list;
                        }
                    }
                    else
                    {
                        List<string> list;
                        if (dict_related_element.TryGetValue(ele, out list))
                        {
                            list.Add(i.Attribute("source").Value);
                        }
                        else
                        {
                            list = new List<string>();
                            list.Add(i.Attribute("source").Value);
                            dict_related_element[ele] = list;
                        }
                    }
                }
            }

            // Make the mmap of group access

            foreach (var g in List_group_new)
            {
                if (!mmap_group_access.ContainsKey(g))
                {
                    IEnumerable<XElement> xeles_access = from e in doc.Descendants(NP + "relationship")
                                                         where e.Attribute("source").Value == g &&
                                                               e.Attribute(xmlns_xsi + "type").Value == RelaionshipConstants.Access
                                                         select e;
                    List<string> list_lib = new List<string>();
                    if (xeles_access != null && xeles_access.Count() != 0)
                    {
                        foreach (var eg in xeles_access)
                        {
                            if (dict_element[eg.Attribute("target").Value].Type_.Equals(ElementConstants.Grouping))
                                list_lib.Add(eg.Attribute("target").Value);
                        }
                        mmap_group_access.Add(g, list_lib);
                    }
                }
            }



            // Make the mmap of element access
            IEnumerable<XElement> xeles_element_access = from e in doc.Descendants(NP + "relationship")
                                                         where (!List_group_new.Contains(e.Attribute("source").Value)) && e.Attribute(xmlns_xsi + "type").Value == RelaionshipConstants.Access
                                                         select e;
            foreach (var ele in xeles_element_access)
            {
                List<string> list_target;
                if (mmap_element_access.TryGetValue(ele.Attribute("source").Value, out list_target))
                {
                    list_target.Add(ele.Attribute("target").Value);
                }
                else
                {
                    list_target = new List<string>();
                    list_target.Add(ele.Attribute("target").Value);
                    mmap_element_access[ele.Attribute("source").Value] = list_target;
                }
            }

            // Make the map of specialzation-relationship
            IEnumerable<XElement> xeles_specialization = from e in doc.Descendants(NP + "relationship")
                                                         where e.Attribute(xmlns_xsi + "type").Value == RelaionshipConstants.Specialization
                                                         select e;
            foreach (var ele in xeles_specialization)
            {
                string id_child = ele.Attribute("source").Value;
                string id_parent = ele.Attribute("target").Value;

                Element element_child = dict_element[id_child];
                Element element_parent = dict_element[id_parent];

                List<string> list_parent = new List<string>();

                if (!mmap_specialization.ContainsKey(id_child))
                {
                    list_parent.Add(id_parent);
                    mmap_specialization.Add(id_child, list_parent);
                }
                else
                {
                    mmap_specialization[id_child].Add(id_parent);
                }
            }

            IEnumerable<XElement> xeles_implementation = from e in doc.Descendants(NP + "relationship")
                                                         where e.Attribute(xmlns_xsi + "type").Value == RelaionshipConstants.Association
                                                         select e;
            foreach (var ele in xeles_implementation)
            {
                string id_source = ele.Attribute("source").Value;
                string id_target = ele.Attribute("target").Value;

                if (dict_element.Keys.Contains(id_source) && dict_element.Keys.Contains(id_target))
                {
                    Element element_source = dict_element[id_source];
                    Element element_target = dict_element[id_target];

                    List<string> list_parent = new List<string>();

                    if (element_source.Type_.Equals(ElementConstants.ApplicationInterface) && (!element_target.Type_.Equals(ElementConstants.ApplicationInterface)))
                    {
                        if (!mmap_specialization.ContainsKey(id_target))
                        {
                            list_parent.Add(id_source);
                            mmap_specialization.Add(id_target, list_parent);
                        }
                        else
                        {
                            mmap_specialization[id_target].Add(id_source);
                        }
                    }
                    else if ((!element_source.Type_.Equals(ElementConstants.ApplicationInterface)) && element_target.Type_.Equals(ElementConstants.ApplicationInterface))
                    {
                        if (!mmap_specialization.ContainsKey(id_source))
                        {
                            list_parent.Add(id_target);
                            mmap_specialization.Add(id_source, list_parent);
                        }
                        else
                        {
                            mmap_specialization[id_source].Add(id_target);
                        }
                    }
                }
            }

            foreach (var id in list_element)
            {
                switch (dict_element[id].Type_)
                {
                    case ElementConstants.BusinessObject: addImplementation(ref mmap_specialization, id, Dict_implementation[ElementConstants.BusinessObject]); break;
                    case ElementConstants.Representation: addImplementation(ref mmap_specialization, id, "I" + UpperString(dict_element[id].Class_name_)); break;
                    case ElementConstants.Contract: addImplementation(ref mmap_specialization, id, Dict_implementation[ElementConstants.Contract]); break;
                    case ElementConstants.ApplicationEvent: addImplementation(ref mmap_specialization, id, Dict_implementation[ElementConstants.ApplicationEvent]); break;
                    case ElementConstants.ApplicationComponent: addImplementation(ref mmap_specialization, id, Dict_implementation[ElementConstants.ApplicationComponent]); break;
                    case ElementConstants.DataObject: addImplementation(ref mmap_specialization, id, Dict_implementation[ElementConstants.DataObject]); break;
                    case ElementConstants.ApplicationProcess: addImplementation(ref mmap_specialization, id, Dict_implementation[ElementConstants.ApplicationProcess]); break;
                    case ElementConstants.ApplicationService: addImplementation(ref mmap_specialization, id, Dict_implementation[ElementConstants.ApplicationService]); break;
                }
            }

            // Make the multimap of association-relationship
            IEnumerable<XElement> xeles_association = from e in doc.Descendants(NP + "relationship")
                                                      where e.Attribute(xmlns_xsi + "type").Value == RelaionshipConstants.Association
                                                      select e;
            foreach (var ele in xeles_association)
            {
                List<string> list_target;
                List<string> list_target2;
                if (mmap_association.TryGetValue(ele.Attribute("source").Value, out list_target))
                {
                    list_target.Add(ele.Attribute("target").Value);
                }
                else
                {
                    list_target = new List<string>();
                    list_target.Add(ele.Attribute("target").Value);
                    mmap_association[ele.Attribute("source").Value] = list_target;
                }
                if (mmap_association.TryGetValue(ele.Attribute("target").Value, out list_target))
                {
                    list_target.Add(ele.Attribute("source").Value);
                }
                else
                {
                    list_target2 = new List<string>();
                    list_target2.Add(ele.Attribute("source").Value);
                    mmap_association[ele.Attribute("target").Value] = list_target2;
                }
            }
        }

        private bool isInSelectedGroups(string id, Dictionary<string, Dictionary<string, List<string>>> dict_group)
        {
            foreach (var g in dict_group.Keys)
            {
                foreach (var sg in dict_group[g].Keys)
                    if (dict_group[g][sg].Contains(id))
                        return true;
            }
            return false;
        }

        private bool isInSelectedViews(string id, Dictionary<string, List<string>> dict_view)
        {
            foreach (var v in dict_view.Keys)
            {
                if (dict_view[v].Contains(id))
                    return true;
            }
            return false;
        }

        private void findAllElement(Dictionary<string, Element> dict_element, XNamespace xmlns_xsi, XNamespace NP, XElement root, XElement node, ref List<string> list, ref List<string> list_group)
        {
            IEnumerable<XElement> xeles_node = from e in node.Descendants(NP + "node")
                                               select e;
            foreach (var n in xeles_node)
            {
                if (n.Attribute(xmlns_xsi + "type").Value == "Element")
                {
                    string id = n.Attribute("elementRef").Value;
                    if (!dict_element[id].Type_.Equals(ElementConstants.Grouping))
                        list.Add(n.Attribute("elementRef").Value);
                    else
                        list_group.Add(n.Attribute("elementRef").Value);
                }
                else if (n.Attribute(xmlns_xsi + "type").Value == "Label" && n.Element(NP + "viewRef") != null)
                {
                    XElement container = root.Descendants(NP + "view").FirstOrDefault(el => el.Attribute("identifier").Value == n.Element(NP + "viewRef").Attribute("ref").Value);
                    if (container != null)
                        findAllElement(dict_element, xmlns_xsi, NP, root, container, ref list, ref list_group);
                }
                else if (n.Attribute(xmlns_xsi + "type").Value == "Container")
                {
                    findAllElement(dict_element, xmlns_xsi, NP, root, n, ref list, ref list_group);
                }
            }
        }

        private void addImplementation(ref Dictionary<string, List<string>> mmap_specialization, string id_child, string parent)
        {
            if (!mmap_specialization.ContainsKey(id_child))
            {
                List<string> list_parent = new List<string>();
                list_parent.Add(parent);
                mmap_specialization.Add(id_child, list_parent);
            }
            else
            {
                mmap_specialization[id_child].Add(parent);
            }
        }

        public static string UpperString(string name)
        {
            //name = Regex.Replace(name, @"\s\(.*\)", "");
            name = name.Replace(".", " ");
            name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            name = name.Replace(" ", "");
            name = Regex.Replace(name, @"[^\w\.@_]", "");
            return name[0].ToString().ToUpperInvariant() + name.Substring(1);
        }

        /// <summary>
        ///  Find the project which the element belongs to
        /// </summary>
        /// <param name="id">id of element</param>
        private string FindProjectByElement(string id)
        {
            List<string> list_element = new List<string>();
            if (mmap_relationship.ContainsKey(id))
            {
                if (mmap_relationship[id]["target"].TryGetValue(RelaionshipConstants.Composition, out list_element))
                {
                    foreach (var i in list_element)
                        if (dict_element[i].Type_.Equals(ElementConstants.ApplicationComponent))
                            return i;
                    foreach (var i in list_element)
                        return FindProjectByElement(i);
                }
                    
            }
            return null;

        }
    }
}
