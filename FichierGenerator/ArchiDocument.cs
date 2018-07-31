﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Globalization;

namespace FichierGenerator
{
    public class ArchiDocument
    {
        string class_namespace;
        
        // Open the prototype document.
        XElement doc;

        // Get the nampespaces 
        XNamespace NP;
        XNamespace xmlns_xsi = "http://www.w3.org/2001/XMLSchema-instance";

        // Map id_element - all elements related
        Dictionary<string, List<string>> dict_related_element = new Dictionary<string, List<string>>();

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

        // Map id_element - namespace
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

        public ArchiDocument(string path, string[] types = null, string[] groups = null, string[] views = null, string name_space = "Maidis.Vnext")
        {
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
                        if (relationship_type.Equals("Access") && ele.Attribute("accessType").Equals("ReadWrite"))
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
                        if (relationship_type.Equals("Access") && ele.Attribute("accessType").Equals("ReadWrite"))
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
                    if (relationship_type.Equals("Access") && ele.Attribute("accessType").Equals("ReadWrite"))
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
                        if (relationship_type.Equals("Access") && ele.Attribute("accessType").Equals("ReadWrite"))
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
                        if (relationship_type.Equals("Access") && ele.Attribute("accessType").Equals("ReadWrite"))
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
                    if (relationship_type.Equals("Access") && ele.Attribute("accessType").Equals("ReadWrite"))
                    {
                        List<string> list2 = new List<string>();
                        list2.Add(id_source);
                        dict_target_relationship["source"].Add(relationship_type, list2);
                    }
                    mmap_relationship.Add(id_target, dict_target_relationship);
                }
            }

            // Make the mmap of solution - projects
            foreach(var id in dict_element.Keys)
            {
                if (dict_element[id].Type_.Equals("Product"))
                {
                    List<string> list;
                    if ( mmap_relationship.ContainsKey(id) &&
                         mmap_relationship[id]["source"].TryGetValue("Association", out list))
                    {
                        List<string> list_projet = new List<string>();
                        foreach (var id_element in list)
                            if (dict_element[id_element].Type_.Equals("ApplicationComponent"))
                                list_projet.Add(id_element);
                        mmap_solution.Add(id, list_projet);
                    }
                }
            }

            // Make the map of group name
            IEnumerable<XElement> xeles_all_group = from e in doc.Descendants(NP + "element")
                                                    where e.Attribute(xmlns_xsi + "type").Value == "Grouping"
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
                                                where e.Attribute(xmlns_xsi + "type").Value == "Grouping"
                                                select e;
            foreach (var ele in xeles_group)
            {
                if (!dict_namespace.ContainsKey(ele.Element(NP + "name").Value))
                    dict_namespace.Add(ele.Element(NP + "name").Value, ele.Attribute("identifier").Value);
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                List<string> list_target = new List<string>();
                List<string> list_interface = new List<string>();
                IEnumerable<XElement> xeles_target = from e in doc.Descendants(NP + "relationship")
                                                     where e.Attribute("source").Value == ele.Attribute("identifier").Value && e.Attribute(xmlns_xsi + "type").Value == "Composition"
                                                     select e;
                if (xeles_target != null && xeles_target.Count() != 0)
                {
                    foreach (var eg in xeles_target)
                    {
                        if (dict_element[eg.Attribute("target").Value].Type_.Equals("ApplicationInterface"))
                            list_interface.Add(eg.Attribute("target").Value);
                        else
                            list_target.Add(eg.Attribute("target").Value);
                        if (!dict_element_group.Keys.Contains(eg.Attribute("target").Value))
                            dict_element_group.Add(eg.Attribute("target").Value, ele.Attribute("identifier").Value);
                    }
                    dict.Add("class", list_target);
                    dict.Add("interface", list_interface);
                    dict_group.Add(ele.Attribute("identifier").Value, dict);
                }
            }
        }

        public void Update(string[] types, string[] groups, string[] views, string name_space)
        {
            this.class_namespace = name_space;
            this.types = types.ToList();
            // Make the map of views
            IEnumerable<XElement> xeles_view = from e in doc.Descendants(NP + "view")
                                               where views == null ||
                                                     views.Contains(e.Element(NP + "name").Value) ||
                                                     views.Count() == 0
                                               select e;
            foreach (var ele in xeles_view)
            {
                List<string> list_ele_child = new List<string>();
                List<string> list_group_child = new List<string>();
                findAllElement(dict_element, xmlns_xsi, NP, doc, ele, ref list_ele_child, ref list_group_child);
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


            list_element.RemoveAll(x => !dict_element.ContainsKey(x));
            foreach (var e in list_element)
            {
                if (!dict_element_group.ContainsKey(e))
                {
                    if (!list_group.Contains("id-GroupeUnConnu"))
                        list_group.Add("id-GroupeUnConnu");
                    if (dict_element[e].Type_.Equals("ApplicationInterface"))
                        dict_group["id-GroupeUnConnu"]["interface"].Add(e);
                    else
                        dict_group["id-GroupeUnConnu"]["class"].Add(e);
                }
            }

            // Make the list of scripts
            foreach (var ele in list_element)
            {
                if (dict_element[ele].Type_.Equals("DataObject"))
                    list_data_object.Add(dict_element[ele]);
            }

            // Make the list of Rresentation
            foreach (var ele in list_element)
            {
                if (dict_element[ele].Type_.Equals("Representation"))
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
                                                               e.Attribute(xmlns_xsi + "type").Value == "Access"
                                                         select e;
                    List<string> list_lib = new List<string>();
                    if (xeles_access != null && xeles_access.Count() != 0)
                    {
                        foreach (var eg in xeles_access)
                        {
                            if (dict_element[eg.Attribute("target").Value].Type_.Equals("Grouping"))
                                list_lib.Add(eg.Attribute("target").Value);
                        }
                        mmap_group_access.Add(g, list_lib);
                    }
                }
            }



            // Make the mmap of element access
            IEnumerable<XElement> xeles_element_access = from e in doc.Descendants(NP + "relationship")
                                                         where (!List_group_new.Contains(e.Attribute("source").Value)) && e.Attribute(xmlns_xsi + "type").Value == "Access"
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
                                                         where e.Attribute(xmlns_xsi + "type").Value == "Specialization"
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
                                                         where e.Attribute(xmlns_xsi + "type").Value == "Association"
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

                    if (element_source.Type_.Equals("ApplicationInterface") && (!element_target.Type_.Equals("ApplicationInterface")))
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
                    else if ((!element_source.Type_.Equals("ApplicationInterface")) && element_target.Type_.Equals("ApplicationInterface"))
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
                    case "BusinessObject": addImplementation(ref mmap_specialization, id, "IBusinessObject"); break;
                    case "Representation": addImplementation(ref mmap_specialization, id, "I" + UpperString(dict_element[id].Class_name_)); break;
                    case "Contract": addImplementation(ref mmap_specialization, id, "CContract"); break;
                    case "ApplicationEvent": addImplementation(ref mmap_specialization, id, "EventArgs"); break;
                    case "ApplicationComponent": addImplementation(ref mmap_specialization, id, "Component"); break;
                    case "DataObject": addImplementation(ref mmap_specialization, id, "DAO"); break;
                    case "ApplicationProcess": addImplementation(ref mmap_specialization, id, "UseCaseWorkflow"); break;
                    case "ApplicationService": addImplementation(ref mmap_specialization, id, "UseCaseWorkflow"); break;
                }
            }

            // Make the multimap of association-relationship
            IEnumerable<XElement> xeles_association = from e in doc.Descendants(NP + "relationship")
                                                      where e.Attribute(xmlns_xsi + "type").Value == "Association"
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
                    if (!dict_element[id].Type_.Equals("Grouping"))
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
    }
}
