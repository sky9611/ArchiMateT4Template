using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FichierGenerator
{
    [Serializable()]
    public class ArchiDocumentSerialized
    {
        string class_namespace;

        public ArchiDocumentSerialized(ArchiDocument archiDocument)
        {
            types = archiDocument.Types;
            class_namespace = archiDocument.Class_namespace;
            dict_related_element = archiDocument.Dict_related_element;
            list_group = archiDocument.List_group;
            list_element = archiDocument.List_element;
            property_definition_map = archiDocument.Property_definition_map;
            dict_group = archiDocument.Dict_group;
            dict_group_name = archiDocument.Dict_group_name;
            dict_namespace = archiDocument.Dict_namespace;
            dict_element_group = archiDocument.Dict_element_group;
            dict_view = archiDocument.Dict_view;
            dict_element = archiDocument.Dict_element;
            dict_relationship = archiDocument.Dict_relationship;
            mmap_relationship = archiDocument.Mmap_relationship;
            mmap_specialization = archiDocument.Mmap_specialization;
            mmap_association = archiDocument.Mmap_association;
            mmap_group_access = archiDocument.Mmap_group_access;
            mmap_element_access = archiDocument.Mmap_element_access;
            list_representation = archiDocument.List_representation;
            list_data_object = archiDocument.List_data_object;
            errors = archiDocument.Errors;
            classes = archiDocument.Classes;
            list_group_new = new List<string>(archiDocument.List_group_new);
            mmap_solution = archiDocument.Mmap_solution;
            dict_element_project = archiDocument.Dict_element_project;
            dict_implementation = archiDocument.Dict_implementation;
        }

        public void Update(ArchiDocument archiDocument)
        {
            types = archiDocument.Types;
            class_namespace = archiDocument.Class_namespace;
            dict_related_element = archiDocument.Dict_related_element;
            list_group = archiDocument.List_group;
            list_element = archiDocument.List_element;
            property_definition_map = archiDocument.Property_definition_map;
            dict_group = archiDocument.Dict_group;
            dict_group_name = archiDocument.Dict_group_name;
            dict_namespace = archiDocument.Dict_namespace;
            dict_element_group = archiDocument.Dict_element_group;
            dict_view = archiDocument.Dict_view;
            dict_element = archiDocument.Dict_element;
            dict_relationship = archiDocument.Dict_relationship;
            mmap_relationship = archiDocument.Mmap_relationship;
            mmap_specialization = archiDocument.Mmap_specialization;
            mmap_association = archiDocument.Mmap_association;
            mmap_group_access = archiDocument.Mmap_group_access;
            mmap_element_access = archiDocument.Mmap_element_access;
            list_representation = archiDocument.List_representation;
            list_data_object = archiDocument.List_data_object;
            errors = archiDocument.Errors;
            classes = archiDocument.Classes;
            list_group_new = new List<string>(archiDocument.List_group_new);
            dict_element_project = archiDocument.Dict_element_project;
            dict_implementation = archiDocument.Dict_implementation;
        }

        Dictionary<string, string> dict_implementation = new Dictionary<string, string>();

        // Map id_element - all elements related
        Dictionary<string, List<string>> dict_related_element = new Dictionary<string, List<string>>();

        // list of group
        List<string> list_group = new List<string>();

        // list of elements
        List<string> list_element = new List<string>();

        // Map id_element - projet(componant applicative) associé
        Dictionary<string, string> dict_element_project = new Dictionary<string, string>();

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

        List<string> types = new List<string>();

        List<string> list_group_new = new List<string>();

        Dictionary<string, List<string>> mmap_solution = new Dictionary<string, List<string>>();

        public string Class_namespace { get => class_namespace; set => class_namespace = value; }
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
        public Dictionary<string, List<string>> Mmap_specialization { get => mmap_specialization; set => mmap_specialization = value; }
        public Dictionary<string, List<string>> Mmap_association { get => mmap_association; set => mmap_association = value; }
        public Dictionary<string, List<string>> Mmap_group_access { get => mmap_group_access; set => mmap_group_access = value; }
        public Dictionary<string, List<string>> Mmap_element_access { get => mmap_element_access; set => mmap_element_access = value; }
        public List<Element> List_representation { get => list_representation; set => list_representation = value; }
        public List<Element> List_data_object { get => list_data_object; set => list_data_object = value; }
        public List<string> Errors { get => errors; set => errors = value; }
        public List<string> Classes { get => classes; set => classes = value; }
        public List<string> Types { get => types; set => types = value; }
        public List<string> List_group_new { get => list_group_new; set => list_group_new = value; }
        public Dictionary<string, List<string>> Mmap_solution { get => mmap_solution; set => mmap_solution = value; }
        public Dictionary<string, string> Dict_element_project { get => dict_element_project; set => dict_element_project = value; }
        public Dictionary<string, string> Dict_implementation { get => dict_implementation; set => dict_implementation = value; }
    }
}
