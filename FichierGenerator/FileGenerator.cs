using EnvDTE;
using FichierGenerator.Template;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Tools;
using VSLangProj80;

namespace FichierGenerator
{
    public class FileGenerator
    {
        Solution solution;
        ArchiDocument archiDocument;
        Dictionary<string, Element> dict_element;
        XElement doc;
        XNamespace NP;
        private readonly XNamespace xmlns_xsi = "http://www.w3.org/2001/XMLSchema-instance";

        // Dictionary project - directory
        Dictionary<string, string> dict_project_directory = new Dictionary<string, string>();

        public static readonly Dictionary<string, string> dict_implementation_defaut = new Dictionary<string, string>{
            {ElementConstants.BusinessObject,"IBusinessObject"},
            {ElementConstants.Contract, "CContract"},
            {ElementConstants.ApplicationEvent, "EventArgs"},
            {ElementConstants.ApplicationComponent, "Component"},
            {ElementConstants.DataObject, "DAO"},
            {ElementConstants.ApplicationProcess, "UseCaseWorkflow"},
            {ElementConstants.ApplicationService, "BusinessService"},
        };

        public static readonly string[] all_types = {
            ElementConstants.Product,
            ElementConstants.BusinessObject,
            ElementConstants.Contract,
            ElementConstants.Representation,
            ElementConstants.DataObject,
            ElementConstants.ApplicationInterface,
            ElementConstants.ApplicationService,
            ElementConstants.ApplicationFunction,
            ElementConstants.ApplicationComponent,
            ElementConstants.ApplicationEvent,
            ElementConstants.ApplicationProcess };

        public FileGenerator(
            string file_path, 
            Dictionary<string, string> dict_implementation, 
            string current_solution_name, 
            string current_solution_path, 
            Solution solution)
        {
            this.solution = solution;
            Current_solution_name = current_solution_name;
            Current_solution_path = current_solution_path;
            this.File_path = file_path;
            doc = XElement.Load(file_path);
            NP = doc.GetDefaultNamespace();
            archiDocument = new ArchiDocument(dict_implementation, file_path);
            Dict_element = archiDocument.Dict_element;
            Log.Add("errors", archiDocument.Errors);
            Log.Add("warnings", new List<string>());
        }

        public string[] getAllElements()
        {
            List<string> list = new List<string>();
            foreach (var x in Dict_element.Keys)
            {
                if (getAllType().Contains(Dict_element[x].Type_))
                    list.Add(Dict_element[x].Name_);
            }
            return list.ToArray();
        }

        public string[] getAllElementID()
        {
            List<string> list = new List<string>();
            foreach (var x in Dict_element.Keys)
            {
                if (getAllType().Contains(Dict_element[x].Type_))
                    list.Add(x);
            }
            return list.ToArray();
        }

        public string[] getElements(string[] types, string[] groups, string[] views, string[] projects)
        {
            List<string> list = new List<string>();

            // Get all elements in selected views
            foreach (var i in views)
            {
                string id_view = archiDocument.Dict_view_name.First(x => x.Value.Equals(i)).Key;
                if (id_view!=null)
                    list.AddRange(archiDocument.Dict_view[id_view]);
            }

            // Get all elements in selected groups
            foreach (var i in groups)
            {
                string id_group = archiDocument.Dict_namespace[i];
                list.AddRange(archiDocument.Dict_group[id_group]["interface"]);
                list.AddRange(archiDocument.Dict_group[id_group]["class"]);
            }

            // Get all elements in selected components
            List<string> list_idProject = new List<string>();
            foreach (var i in projects)
            {
                string id_project = archiDocument.Dict_project_elements.FirstOrDefault(x => dict_element[x.Key].Class_name_.Equals(i)).Key;
                if (id_project != null)
                {
                    list.AddRange(archiDocument.Dict_project_elements[id_project]);
                    list_idProject.Add(id_project);
                }
            }

            // Remove dublication
            list = list.Distinct().ToList();
            // Remove elements with unselected type
            list.RemoveAll(x => !types.Contains(Dict_element[x].Type_));
            // Remove elements don't exist
            list.RemoveAll(x => !Dict_element.ContainsKey(x));
            // Remove elements not belong to selected components
            if (list_idProject.Count() > 0)
                list.RemoveAll(x => archiDocument.Dict_element_project.Keys.Contains(x) && !list_idProject.Contains(archiDocument.Dict_element_project[x]));

            List<string> list_element_name = new List<string>();
            list.ForEach(x => list_element_name.Add(Dict_element[x].Name_));

            // If only choose the Application Component as type, ze generate projects instead of classes
            if (types.Count() == 1 && types[0].Equals(ElementConstants.ApplicationComponent))
            {
                list.AddRange(GetProjects(solution));
                return list.ToArray();
            }
            return list_element_name.ToArray();
        }

        public string[] getElementID(string[] types, string[] groups, string[] views, string[] projects)
        {
            List<string> list = new List<string>();

            // Get all elements in selected views
            foreach (var i in views)
            {
                string id_view = archiDocument.Dict_view_name.First(x => x.Value.Equals(i)).Key;
                if (id_view != null)
                    list.AddRange(archiDocument.Dict_view[id_view]);
            }

            // Get all elements in selected groups
            foreach (var i in groups)
            {
                string id_group = archiDocument.Dict_namespace[i];
                list.AddRange(archiDocument.Dict_group[id_group]["interface"]);
                list.AddRange(archiDocument.Dict_group[id_group]["class"]);
            }

            // Get all elements in selected components
            List<string> list_idProject = new List<string>();
            foreach (var i in projects)
            {
                string id_project = archiDocument.Dict_project_elements.FirstOrDefault(x => dict_element[x.Key].Class_name_.Equals(i)).Key;
                if (id_project != null)
                {
                    list.AddRange(archiDocument.Dict_project_elements[id_project]);
                    list_idProject.Add(id_project);
                }
            }

            // Remove dublication
            list = list.Distinct().ToList();
            // Remove elements with unselected type
            list.RemoveAll(x => !types.Contains(Dict_element[x].Type_));
            // Remove elements don't exist
            list.RemoveAll(x => !Dict_element.ContainsKey(x));
            // Remove elements not belong to selected components
            if (list_idProject.Count() > 0)
                list.RemoveAll(x => archiDocument.Dict_element_project.Keys.Contains(x) && !list_idProject.Contains(archiDocument.Dict_element_project[x]));

            List<string> list_element_name = new List<string>();
            list.ForEach(x => list_element_name.Add(Dict_element[x].Name_));

            // If only choose the Application Component as type, ze generate projects instead of classes
            if (types.Count() == 1 && types[0].Equals(ElementConstants.ApplicationComponent))
            {
                list.AddRange(GetProjects(solution));
                return list.ToArray();
            }
            return list.ToArray();
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

        public string[] getGroups(string[] types)
        {
            List<string> list_group = new List<string>();
            foreach (var i in archiDocument.Dict_group_types.Keys)
            {
                if (archiDocument.Dict_group_types[i].Intersect(types).Count() > 0)
                    list_group.Add(Dict_element[i].Name_);
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

        public string[] getViews(string[] types)
        {
            List<string> list_view = new List<string>();
            foreach (var i in archiDocument.Dict_view_types.Keys)
            {
                if (archiDocument.Dict_view_types[i].Intersect(types).Count() > 0)
                    list_view.Add(archiDocument.Dict_view_name[i]);
            }
            return list_view.ToArray();
        }


        public string[] getAllSolutions()
        {
            //List<string> list = new List<string>();
            //List<string> list2 = new List<string>();
            //foreach (var x in Dict_element.Keys)
            //{
            //    Element element = Dict_element[x];
            //    if (element.Type_.Equals(ElementConstants.Product))
            //        if (element.Properties_.ContainsKey("$principal"))
            //        {
            //            list2.Add(element.Name_);
            //            break;
            //        }
            //        else
            //            list.Add(element.Name_);
            //}
            //return list2.Count()>0 ? list2.ToArray() : list.ToArray();
            if (archiDocument.Solution_principal!=null)
                return new[] { dict_element[archiDocument.Solution_principal].Class_name_ };
            else
                return archiDocument.List_product.Select(x => dict_element[x].Class_name_).ToArray();
        }

        public string File_path { get; set; }
        public string Current_solution_name { get; set; }
        public string Current_solution_path { get; set; }
        public Dictionary<string, List<string>> Log { get; set; } = new Dictionary<string, List<string>>();
        public Dictionary<string, Element> Dict_element { get => dict_element; set => dict_element = value; }
        public Dictionary<string, string> Dict_project_directory { get => dict_project_directory; set => dict_project_directory = value; }

        /// <summary>
        ///     Method to run the t4 template to generate files with selected elements
        /// </summary>
        /// <param name="destinationFolder"> The destination folder</param>
        /// <param name="elements"> The selected elements </param>
        /// <param name="name_space"> The namespace of generated class </param>
        /// <param name="solution"> The current solution </param>
        public void Generate(string destinationFolder, string[] elements, string name_space, Solution solution)
        {
            this.solution = solution;
            ArchiDocument archiDocumentTemp = archiDocument;
            archiDocumentTemp.Update(elements, name_space);
            ArchiDocumentSerialized archiDocumentSerialized = new ArchiDocumentSerialized(archiDocumentTemp);

            foreach (var id_element in archiDocumentSerialized.List_element)
            {
                Element ele = Dict_element[id_element];
                if (ele.Type_.Equals(ElementConstants.ApplicationComponent))
                    GenerateProject(solution, ele.Name_);
            }

            foreach (var id_element in archiDocumentSerialized.List_element)
            {
                Element ele = Dict_element[id_element];

                // Only the elements who are related to the current solution will be generated
                if (archiDocument.Dict_element_solution.ContainsKey(id_element))
                {
                    var related_solution_name = StringHelper.UpperString(Dict_element[archiDocument.Dict_element_solution[id_element]].Name_);
                    if (!related_solution_name.Equals(Path.GetFileNameWithoutExtension(Current_solution_name)))
                        Log["errors"].Add("Element \"" + ele.Name_ + "\" is not supposed to be generated here, it's related to solution(ArchimateModel.Produit) \"" + related_solution_name);
                    else
                    {
                        if (ele.Type_.Equals(ElementConstants.ApplicationEvent) && ele.Properties_.ContainsKey("$implementation"))
                            GenerateApplicationEvent(archiDocumentSerialized, id_element);
                        switch (ele.Type_)
                        {
                            case ElementConstants.Contract:
                                GenerateContract(archiDocumentSerialized, id_element);
                                break;
                            case ElementConstants.BusinessObject:
                                GenerateBusinessObject(archiDocumentSerialized, id_element);
                                break;
                            case ElementConstants.ApplicationService:
                                GenerateApplicationService(archiDocumentSerialized, id_element);
                                break;
                            case ElementConstants.ApplicationProcess:
                                GenerateApplicationProcess(archiDocumentSerialized, id_element);
                                break;
                            case ElementConstants.ApplicationInterface:
                                GenerateInterface(archiDocumentSerialized, id_element);
                                break;
                            case ElementConstants.Representation:
                                GenerateRepresentation(archiDocumentSerialized, id_element);
                                break;
                            case ElementConstants.DataObject:
                                GenerateDataObject(archiDocumentSerialized, id_element);
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Find all the representations related to a solution
        /// </summary>
        /// <param name="id_solution"></param>
        /// <returns></returns>
        private string GetStartUpUri(string id_solution)
        {
            List<string> list_FT;
            List<string> list_view = new List<string>();
            if (archiDocument.Mmap_relationship.ContainsKey(id_solution))
            {
                if (archiDocument.Mmap_relationship[id_solution]["source"].TryGetValue(RelationshipConstants.Triggering, out list_FT))
                    foreach (var i in list_FT)
                        if (Dict_element[i].Type_.Equals(ElementConstants.Representation))
                            list_view.Add(StringHelper.UpperString(Dict_element[i].Class_name_) + ".xaml");
                if (archiDocument.Mmap_relationship[id_solution]["source"].TryGetValue(RelationshipConstants.Flow, out list_FT))
                    foreach (var i in list_FT)
                        if (Dict_element[i].Type_.Equals(ElementConstants.Representation))
                            list_view.Add(StringHelper.UpperString(Dict_element[i].Class_name_) + ".xaml");
            }

            string views;
            if (list_view.Count() > 0)
                views = string.Join(",", list_view);
            else
                views = "null";
            return views;
        }

        /// <summary>
        ///     Generate the App.xaml.cs for the solution
        /// </summary>
        /// <param name="solution_name"></param>
        /// <returns></returns>
        private string GenerateSolutionXamlCs(string solution_name)
        {
            var appXamlCsTemplate = new AppXamlCsTemplate();
            appXamlCsTemplate.Session = new TextTemplatingSession();
            appXamlCsTemplate.Session["solutionName"] = solution_name;
            appXamlCsTemplate.Initialize();
            return appXamlCsTemplate.TransformText();
        }

        public string[] GetProjects(Solution solution)
        {
            string solution_name = Path.GetFileNameWithoutExtension(solution.FullName);
            var id_solution = archiDocument.Mmap_solution.FirstOrDefault(x => StringHelper.UpperString(Dict_element[x.Key].Name_) == solution_name).Key;
            List<string> list_project = archiDocument.Mmap_solution[id_solution];
            List<string> list_project_name = new List<string>();
            foreach (var i in list_project)
                list_project_name.Add(dict_element[i].Name_);

            return list_project_name.ToArray();
        }

        /// <summary>
        ///     Create Project
        /// </summary>
        /// <param name="solution"> The solution where the project will be created </param>
        /// <param name="application_component_name"> The name of the project </param>
        public void GenerateProject(Solution solution,  string application_component_name)
        {
            string id_project = dict_element.First(x => x.Value.Name_.Equals(application_component_name)).Key;
            string solution_path = Directory.GetParent(solution.FullName).ToString();
            string solution_name = Path.GetFileName(solution.FullName);
            ArchiDocumentSerialized archiDocumentSerialized = new ArchiDocumentSerialized(archiDocument);
            string projet_name = StringHelper.UpperString(Dict_element[id_project].Class_name_);
            string project_path = Path.Combine(Path.GetFullPath(solution_path), projet_name);

            if (!IsProjectIncludedInSolution(projet_name, solution))
            {
                solution.AddFromTemplate(Path.GetFullPath(@"..\..\lib\ClassLibrary\csClassLibrary.vstemplate"),
                    project_path, projet_name);

                // Modify AssemblyInfo
                string text = File.ReadAllText(project_path + "\\Properties\\AssemblyInfo.cs");
                Regex regex = new Regex(@"" + projet_name);
                text = regex.Replace(text, solution_name, 1, text.IndexOf(projet_name) + projet_name.Length);
                File.WriteAllText(project_path + "\\Properties\\AssemblyInfo.cs", text);

                // Store the project directory
                Dict_project_directory.Add(id_project, Path.Combine(Path.GetFullPath(solution_path), projet_name));

                // Remove unused cs class
                // TODO

                System.Threading.Thread.Sleep(1000);
            }

           
        }

        private bool IsProjectIncludedInSolution(string prjName, Solution solution)
        {
            VSProject2 vsproj;
            foreach (Project proj in solution.Projects)
            {
                vsproj = (VSProject2)proj.Object;
                if (vsproj.Project.Name.Equals(prjName))
                    return true;
            }
            return false;
        }

        /// <summary>
        ///     Add referenced projects to each project
        ///     TO BE TESTED
        /// </summary>
        /// <param name="solution"></param>
        public void AddProjectReferences(Solution solution)
        {
            VSProject2 vsproj;
            foreach (Project proj in solution.Projects)
            {
                vsproj = (VSProject2)proj.Object;
                string id_project = archiDocument.Dict_project_reference.FirstOrDefault(x => Path.GetFileNameWithoutExtension(vsproj.Project.Name).Equals(StringHelper.UpperString(dict_element[x.Key].Class_name_))).Key; 
                HashSet<string> set_references;
                if (id_project != null && archiDocument.Dict_project_reference.TryGetValue(id_project, out set_references))
                    foreach (var id_reference in set_references)
                    {
                        if (id_reference!= id_project)
                        {
                            if (Dict_project_directory.ContainsKey(id_reference))
                            {
                                vsproj.References.AddProject(GetProjectByName(solution, StringHelper.UpperString(dict_element[id_reference].Class_name_)));
                            }
                            else
                                Log["errors"].Add("The reference \"" + dict_element[id_reference].Class_name_ + "\" of project \"" + Path.GetFileNameWithoutExtension(vsproj.Project.Name) + "\" has not been found in this solution");
                        }
                    }

            }
        }

        public DTE GenerateSolution(string destinationFolder, string solution_name)
        {
            System.Type type = Type.GetTypeFromProgID("VisualStudio.DTE.15.0");
            Dictionary<string, List<string>> dict = archiDocument.Mmap_solution;
            ArchiDocumentSerialized archiDocumentSerialized = new ArchiDocumentSerialized(archiDocument);

            var id_solution = dict.FirstOrDefault(x => Dict_element[x.Key].Name_ == solution_name).Key;

            Object obj = System.Activator.CreateInstance(type, true);
            EnvDTE.DTE dte = (EnvDTE.DTE)obj;
            List<string> list_projet = dict[id_solution];
            solution_name = StringHelper.UpperString(solution_name);

            //dte.MainWindow.Visible = true; // optional if you want to See VS doing its thing*
            string path = destinationFolder;
            string solution_path = System.IO.Path.Combine(path, solution_name);

            if (Directory.Exists(solution_path))
                Directory.Delete(solution_path,true);

            // create the folder for the solution
            System.IO.Directory.CreateDirectory(solution_path);

            // create a new solution
            dte.Solution.Create(solution_path, solution_name);
            var solution = dte.Solution;

            // Save the sln file
            solution.SaveAs(Path.GetFullPath(Path.Combine(solution_path, solution_name) + ".sln"));

            // Generate the project with the same name of solution
            Project project;
            project = solution.AddFromTemplate(Path.GetFullPath(@"..\..\lib\WPFApplication\csWPFApplication.vstemplate"),
                Path.Combine(Path.GetFullPath(solution_path), solution_name), solution_name);

            // Generate manifest
            var template = new DeploymentFileTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_solution;
            template.Initialize();
            var generatedText = template.TransformText();
            File.WriteAllText(Path.Combine(Path.GetFullPath(solution_path), solution_name)+ "\\" + solution_name + ".manifest.xml", generatedText);
            project = GetProjectByName(solution, solution_name);
            project.ProjectItems.AddFromFile(Path.Combine(Path.GetFullPath(solution_path), solution_name) + "\\" + solution_name + ".manifest.xml");

            // Modify App.xaml
            string text = File.ReadAllText(Path.Combine(solution_path, solution_name) + "\\App.xaml");
            string startUpUri = GetStartUpUri(id_solution);
            if(!startUpUri.Equals("null"))
                text = text.Replace("MainWindow.xaml", startUpUri);
            File.WriteAllText(Path.Combine(solution_path, solution_name) + "\\App.xaml", text);

            // Modify App.xaml.cs
            text = GenerateSolutionXamlCs(solution_name);
            File.WriteAllText(Path.Combine(solution_path, solution_name) + "\\App.xaml.cs", text);

            System.Threading.Thread.Sleep(1000);

            //dte.Quit();
            return dte;
        }
       
        private void GenerateContract(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new ContractTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            //File.WriteAllText("..\\..\\Generated" + "\\"+ name + ".cs", generatedText);
            string filename = WriteToFile(id_element, generatedText, ".cs");

            AddFileToProject(id_element, filename);
        }

        private void GenerateBusinessObject(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new BusinessObjectTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            string filename = WriteToFile(id_element, generatedText, ".cs");
            AddFileToProject(id_element, filename);
        }

        private void GenerateApplicationService(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new ApplicationServiceTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            string filename = WriteToFile(id_element, generatedText, ".cs");
            AddFileToProject(id_element, filename);
        }

        private void GenerateApplicationEvent(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new ApplicationEventTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            string filename = WriteToFile(id_element, generatedText, ".cs");
            AddFileToProject(id_element, filename);
        }

        private void GenerateApplicationProcess(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new ApplicationProcessTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            string filename = WriteToFile(id_element, generatedText, ".cs");
            AddFileToProject(id_element, filename);
        }

        private void GenerateInterface(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new InterfaceTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            string filename = WriteToFile(id_element, generatedText, ".cs");
            AddFileToProject(id_element, filename);
        }

        private void GenerateRepresentation(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new RepresentationTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            string filename = WriteToFile(id_element, generatedText, ".cs");
            AddFileToProject(id_element, filename);

            var viewTemplate = new ViewTemplate();
            viewTemplate.Session = new TextTemplatingSession();
            if (archiDocument.Dict_element_group.ContainsKey(id_element))
                viewTemplate.Session["groupName"] = StringHelper.UpperString(archiDocument.Dict_element[archiDocument.Dict_element_group[id_element]].Class_name_);
            else
                viewTemplate.Session["groupName"] = "UnknownGroup";
            viewTemplate.Session["viewName"] = StringHelper.UpperString(name);
            viewTemplate.Initialize();
            generatedText = viewTemplate.TransformText();
            filename =  WriteToFile(id_element, generatedText, ".xaml");
            AddFileToProject(id_element, filename);
        }

        private void GenerateDataObject(ArchiDocumentSerialized archiDocumentSerialized, string id_element)
        {
            string name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            var template = new DataObjectTemplate();
            template.Session = new TextTemplatingSession();
            template.Session["archiDocument"] = archiDocumentSerialized;
            template.Session["id_element"] = id_element;
            template.Initialize();
            var generatedText = template.TransformText();
            string filename = WriteToFile(id_element, generatedText, ".cs");
            AddFileToProject(id_element, filename);

            var sqlTemplate = new SQLTemplate();
            sqlTemplate.Session = new TextTemplatingSession();
            sqlTemplate.Session["archiDocument"] = archiDocumentSerialized;
            sqlTemplate.Session["id_element"] = id_element;
            sqlTemplate.Initialize();
            generatedText = sqlTemplate.TransformText();
            filename = WriteToFile(id_element, generatedText, ".sql");
            AddFileToProject(id_element, filename);

            if (archiDocument.Mmap_relationship.ContainsKey(id_element))
            {
                List<string> list_associated;
                if (archiDocument.Mmap_relationship[id_element]["source"].TryGetValue("Realization", out list_associated))
                {
                    foreach (var id_associated in list_associated)
                    {
                        if (Dict_element.ContainsKey(id_associated))
                        {
                            Element element_associated = Dict_element[id_associated];
                            if (element_associated.Type_.Equals(ElementConstants.BusinessObject))
                            {
                                var mappingTemplate = new MappingTemplate();
                                mappingTemplate.Session = new TextTemplatingSession();
                                mappingTemplate.Session["archiDocument"] = archiDocumentSerialized;
                                mappingTemplate.Session["id_element"] = id_element;
                                mappingTemplate.Session["id_business_object"] = id_associated;
                                mappingTemplate.Initialize();
                                generatedText = mappingTemplate.TransformText();
                                filename = WriteToFile(id_element, generatedText, ".xml");
                                AddFileToProject(id_element, filename);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///  Create generated file
        /// </summary>
        /// <param name="id_element"></param>
        /// <param name="generatedText"></param>
        /// <param name="type"></param>
        /// <returns> The fullname of generated file </returns>
        private string WriteToFile(string id_element, string generatedText, string type)
        {
            string fullname;
            string id_project;
            string file_name = StringHelper.UpperString(Dict_element[id_element].Class_name_);
            if (archiDocument.Dict_element_project.TryGetValue(id_element, out id_project))
            {
                Project project = GetProjectByName(solution, StringHelper.UpperString(dict_element[id_project].Class_name_));
                if (project != null)
                {
                    if (!Dict_element[id_element].Properties_.ContainsKey("$localisation"))
                    {
                        //fullname = Dict_project_directory[id_project] + "\\" + file_name + type;
                        fullname = Path.GetDirectoryName(project.FullName) + "\\" + file_name + type;
                        File.WriteAllText(fullname, generatedText);
                    }
                    else
                    {
                        string localisation = Dict_element[id_element].Properties_["$localisation"].Replace("./", "");
                        Directory.CreateDirectory(Path.GetDirectoryName(project.FullName) + "\\" + localisation);
                        fullname = Path.GetDirectoryName(project.FullName) + "\\" + localisation + "\\" + file_name + type;
                        File.WriteAllText(fullname, generatedText);
                    }
                }
                else
                {
                    Log["warnings"].Add("The project \"" + StringHelper.UpperString(dict_element[id_project].Class_name_) + "which element \"" + Dict_element[id_element].Name_ + "\" is related to has not been found");
                    Directory.CreateDirectory(Path.GetFullPath(Path.Combine(Path.Combine(Current_solution_path, Path.GetFileNameWithoutExtension(Current_solution_name)), "Generated")));
                    fullname = Path.GetFullPath(Path.Combine(Path.Combine(Current_solution_path, Path.GetFileNameWithoutExtension(Current_solution_name)), "Generated")) + "\\" + file_name + type;
                    File.WriteAllText(fullname, generatedText);
                }
            }
            else
            {
                // Les elements qui ne sont pas li��s �� un projet(Composant Applicatif) quelconque sont mets dans 
                // le r��pertoire /<CurrentSolution>/Generated
                Log["warnings"].Add("Element \"" + Dict_element[id_element].Name_ + "\" is not related to any projects in this solution");
                Directory.CreateDirectory(Path.GetFullPath(Path.Combine(Path.Combine(Current_solution_path, Path.GetFileNameWithoutExtension(Current_solution_name)), "Generated")));
                fullname = Path.GetFullPath(Path.Combine(Path.Combine(Current_solution_path, Path.GetFileNameWithoutExtension(Current_solution_name)), "Generated")) + "\\" + file_name + type;
                File.WriteAllText(fullname, generatedText);
            }
            return fullname;
        }

        public Project GetProjectByName(Solution solution, string name)
        {
            foreach (Project p in solution.Projects)
                if (Path.GetFileNameWithoutExtension(p.FileName).Equals(name))
                    return p;
            return null;
        }

        /// <summary>
        ///     If the file(generated element) is related to a project(Application Component), add to it.
        /// Otherwise, add it to the solution name project   
        /// </summary>
        /// <param name="id_element"></param>
        /// <param name="filename"></param>
        private void AddFileToProject(string id_element, string filename)
        {
            string id_project;
            string project_name;
            if (filename != "")
            {
                if (archiDocument.Dict_element_project.TryGetValue(id_element, out id_project))
                {
                    project_name = dict_element[id_project].Class_name_;
                    Project project = GetProjectByName(solution, StringHelper.UpperString(project_name));
                    if (project != null)
                        project.ProjectItems.AddFromFile(filename);
                }
                else
                {
                    project_name = Path.GetFileNameWithoutExtension(Current_solution_name);
                    Project project = GetProjectByName(solution, project_name);
                    if (project != null)
                        project.ProjectItems.AddFromFile(filename);
                }
            }
            
        }

        static void Main(string[] args)
        {
            //FileGenerator fileGenerator = new FileGenerator(@"..\..\lib\MODELE_VNEXT.xml", dict_implementation_defaut, "", Path.GetFullPath("..\\..\\Generated"));

            List<string> list = new List<string>();
            //string[] types = { ElementConstants.BusinessObject };
            string[] types = list.ToArray();
            //string[] groups = { "Accueil Patient" };
            string[] groups = list.ToArray();
            //string[] views = { "g��n��ration couches client" };
            string[] views = { "g��n��ration couches serveur" };
            //string[] elements = fileGenerator.getAllElements();
            //string[] elements = list.ToArray();
            //string[] views = list.ToArray();
            //string[] array_element = fileGenerator.getElements(fileGenerator.getAllType(), groups, views);
            //string[] array_views = fileGenerator.getViews(fileGenerator.getAllType());
            //fileGenerator.GenerateSolution("..\\..\\Generated", "Accueil Patient Service");
            //fileGenerator.Generate("..\\..\\Generated", fileGenerator.getAllType(), groups, views, array_element, "Maidis.VNext.");
        }
    }
}
