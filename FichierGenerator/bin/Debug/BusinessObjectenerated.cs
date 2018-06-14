



using System.Collections.Generic;

namespace MyProject
{
	[ModelElement("Aspect",", ElementType = "BusinessObjectArchimate")]
	partial class Aspect {}
	[ModelElement("Autorisation","défini une autorisation CRUD pour utilisateur sur une entité ou un élément d'une entité ou une fonction, ElementType = "BusinessObjectArchimate")]
	partial class Autorisation {}
	[ModelElement("Composant","un composant implèmente complètement une fonctionnalité métier ou technique il expose des interfaces d'utilisation pour pouvoir être intégré au sein d'une application il est composé de modules selon leur spécificités techniques, ElementType = "BusinessObjectArchimate")]
	partial class Composant {}
	[ModelElement("Contexte de session",", ElementType = "BusinessObjectArchimate")]
	partial class Contexte_de_session {}
	[ModelElement("Contexte utilisateur","container d'objets associé à l'utilisateur courant, ElementType = "BusinessObjectArchimate")]
	partial class Contexte_utilisateur {}
	[ModelElement("Document","template instancié intégrant des données métier est utilisé de manière atomique sans avoir la connaissance de sa structure interne, ElementType = "BusinessObjectArchimate")]
	partial class Document {}
	[ModelElement("Domaine fonctionnel","regroupe un ensemble d'objets métier, leurs workflows et leurs services associés, correspondant à une fonctionnalité applicative comme par exemple la prescription. Les domaines fonctionnels ont les propriétés suivantes: - ils sont associés à des autorisations pour des rôles et des utilisateurs - ils définissent des règles de dépendances entre eux: chaque fonctionnalité dépend d'une ou plusieurs autres fonctionnalités - ils servent de connecteurs dans les tools pour définir les dépendances entre tools: un tool est activé en fonction de la fonctionnalité qu'il implémente et charge les tools gérant les fonctionnalités nécessaires. - ils délimitent les schémas de base en terme de contraintes d'intégrité référentielle et de sous-schéma combinable avec d'autres sous-schémas - ils limitent la recherche des données de traitement des services applicatifs associés: en général, un service de traitement métier va charger pour un objet raçine tout les objets connectés du même domaine fonctionnel. Les autres objets nécessaires dans un autre domaine seront chargés dans une autre requête la détermination des domaines fonctionnels peut être complexe. Une approche possible et de rechercher pour une entité du domaine métier de trouver toutes ses entités en relation 1-n ou n-m sur plusieurs niveaux. cette règle pourrait être utilisé de manière automatique dans le cas où l'on veut accéder à une entité qui n'est pas affectée à un domaine métier, ElementType = "BusinessObjectArchimate")]
	partial class Domaine_fonctionnel {}
	[ModelElement("Entité","propriétés communes à toutes les entités métier comme par exemple des champs partagés tel que la clé Id, la date de création (les champs techniques), ElementType = "BusinessObjectArchimate")]
	partial class Entité {}
	[ModelElement("Etat","état présentant des informations métiers pouvant être imprimé, ElementType = "BusinessObjectArchimate")]
	partial class Etat {}
	[ModelElement("Exception",", ElementType = "BusinessObjectArchimate")]
	partial class Exception {}
	[ModelElement("Exception technique",", ElementType = "BusinessObjectArchimate")]
	partial class Exception_technique {}
	[ModelElement("Factory",", ElementType = "BusinessObjectArchimate")]
	partial class Factory {}
	[ModelElement("Fonctionalité technique","les fonctionalités techniques sont des classes internes avec moins de contraintes de format que les services métiers (non SOA) elles sont appelables depuis n'importe quel couche applicative elle intègrent un état et peuvent appeler des services (au sens SOA du terme) elles peuvent être implémentées différemment selon l'environnement d'exécution. Par exemple, une fonction de log en local sera différente sur le serveur., ElementType = "BusinessObjectArchimate")]
	partial class Fonctionalité_technique {}
	[ModelElement("Fonctionnalité","Une fonctionnalité expose un workflow métier d'un composant métier qui peut être appelée par d'autres fonctionnalités, ElementType = "BusinessObjectArchimate")]
	partial class Fonctionnalité {}
	[ModelElement("Machine à état","encapsulation d'une machine à état qui défini un ensemble d'état avec un ensemble de traitements associés selon des conditions de déclenchement, ElementType = "BusinessObjectArchimate")]
	partial class Machine_à_état {}
	[ModelElement("Module","ensemble d'artefacts exécutables assurant une fonctionnalité spécifique d'un composant (en général associé à une couche) un module correspond par exemple à l'ensemble des workflows d'un composant un module dépend d'autres modules d'un même composant un module s'implémente sous la forme d'un ensemble d'assemblies avec leurs dépendances un module peut être réutilisé entre plusieurs composants, ElementType = "BusinessObjectArchimate")]
	partial class Module {}
	[ModelElement("Moteur IOC",", ElementType = "BusinessObjectArchimate")]
	partial class Moteur_IOC {}
	[ModelElement("Notification",", ElementType = "BusinessObjectArchimate")]
	partial class Notification {}
	[ModelElement("Relation","modélise la relation de type 1-1 ou 1-n entre 2 types d'entités est implémenté sous la forme de collection gère le lazy-loading, ElementType = "BusinessObjectArchimate")]
	partial class Relation {}
	[ModelElement("Requete","défini les éléments d'une requête de recherche d'un ensemble de données, ElementType = "BusinessObjectArchimate")]
	partial class Requete {}
	[ModelElement("Role","regroupe un ensemble d'utilisateurs associés à des domaines métier les droits d'accès sont gérés en fonction des rôles, pas en fonction d'un utilisateur un rôle peut être une extension et/ou une fusion d'autres rôles, ElementType = "BusinessObjectArchimate")]
	partial class Role {}
	[ModelElement("Règle","structure générale d'une règle qui sera spécialisée selon le métier intègre les liens pour gérer des combinaisons de règles, ElementType = "BusinessObjectArchimate")]
	partial class Règle {}
	[ModelElement("Trace","trace intégrant des informations métier, ElementType = "BusinessObjectArchimate")]
	partial class Trace {}
	[ModelElement("Transaction",", ElementType = "BusinessObjectArchimate")]
	partial class Transaction {}
	[ModelElement("Tâche","traitement de tout type peut être décomposé en autres tâches peut être déclenchée en traitement de fond, à une heure particulière peut être défini de manière statique par du code ou de manière dynamique par un langage compréhensible par l'utilisateur, ElementType = "BusinessObjectArchimate")]
	partial class Tâche {}
	[ModelElement("Utilisateur","information sur un utilisateur réel un utilisateur est associé à un rôle à un instant donné mais il peut changer de rôle, ElementType = "BusinessObjectArchimate")]
	partial class Utilisateur {}
	[ModelElement("Verrou","verrou d'accès à une ressource ou un objet de manière générale, ElementType = "BusinessObjectArchimate")]
	partial class Verrou {}
	[ModelElement("Accéléromètre",", ElementType = "BusinessObjectArchimate")]
	partial class Accéléromètre {}
	[ModelElement("aide contextuelle","une aide contextuelle modélise un élément d'aide (texte) affichable associée à un élément graphique, ElementType = "BusinessObjectArchimate")]
	partial class Aide_contextuelle {}
	[ModelElement("Aide application","gère l'ensemble des informations d'aide de l'application, sous la forme d'un dictionnaire de texte peut être associé à un élément graphique que l'utilisateur peut activer, ElementType = "BusinessObjectArchimate")]
	partial class Aide_application {}
	[ModelElement("Appareil photo",", ElementType = "BusinessObjectArchimate")]
	partial class Appareil_photo {}
	[ModelElement("Application","propriétés de l'application, ensemble de fonctionnalités exposés sur le client, ElementType = "BusinessObjectArchimate")]
	partial class Application {}
	[ModelElement("Composant client","propriété d'un composant de code s'exécutant sur le poste de travail de l'utilisateur implémenté sous la forme d'un exécutable ou d'une dll (windows), ElementType = "BusinessObjectArchimate")]
	partial class Composant_client {}
	[ModelElement("Container graphique","composant graphique container pouvant être associé à un identifiant de contexte, ElementType = "BusinessObjectArchimate")]
	partial class Container_graphique {}
	[ModelElement("Contexte d'application","container des objets métier au niveau application, ElementType = "BusinessObjectArchimate")]
	partial class Contexte_dapplication {}
	[ModelElement("Lanceur","gère le lancement de l'application, avec toutes les problématiques de déploiement, ElementType = "BusinessObjectArchimate")]
	partial class Lanceur {}
	[ModelElement("Gesture",", ElementType = "BusinessObjectArchimate")]
	partial class Gesture {}
	[ModelElement("GPS",", ElementType = "BusinessObjectArchimate")]
	partial class GPS {}
	[ModelElement("Périphérique mobile",", ElementType = "BusinessObjectArchimate")]
	partial class Périphérique_mobile {}
	[ModelElement("Tool","Un tool est un composant de code livrable il correspond à une demande client Il est composé d'un ensemble de composants métier, ElementType = "BusinessObjectArchimate")]
	partial class Tool {}
	[ModelElement("Tool externe","le tool externe s'exécute dans un espace d'adressage différent de celui du container il peut faire un appel direct aux fonctionnalités du container en passant par un mécanisme de communication externe, ElementType = "BusinessObjectArchimate")]
	partial class Tool_externe {}
	[ModelElement("Vue","structure commune à toutes les vues, ElementType = "BusinessObjectArchimate")]
	partial class Vue {}
	[ModelElement("Widget","composant graphique élémentaire gérant une information, ElementType = "BusinessObjectArchimate")]
	partial class Widget {}
	[ModelElement("Workflow","structure partagée par tout les workflows, ElementType = "BusinessObjectArchimate")]
	partial class Workflow {}
	[ModelElement("Reconnaissance vocale",", ElementType = "BusinessObjectArchimate")]
	partial class Reconnaissance_vocale {}
	[ModelElement("Widget externe","widget dont le traitement est en dehors de l'espace d'adressage de l'application (intégration par COM par exemple) correspond aux composants graphiques existants, ElementType = "BusinessObjectArchimate")]
	partial class Widget_externe {}
	[ModelElement("Vue externe","vue dont le traitement est en dehors de l'espace d'adressage de l'application (intégration par COM par exemple) correspond aux fenêtres graphiques existants, ElementType = "BusinessObjectArchimate")]
	partial class Vue_externe {}
	[ModelElement("Périphérique","peripherique pilotable par l'application est associé au poste de travail dans le cas des objets connectés, peut être associé à un composant serveur externe qui récupérera les informations et qui les fournira à l'application sous forme de service (cas de l'utilisation pour le big data): dans ce cas, le périphérique n'apparaît pas comme tel dans l'architecture de l'application a voir: faut-il inclure les périphériques intégrés aux fonctionnalités transverses tel que l'impression au travers de l'imprimante?, ElementType = "BusinessObjectArchimate")]
	partial class Périphérique {}
	[ModelElement("ADO","Objet d'accès au données standard, qui intègre des mécanismes CRUD réutilisables, ElementType = "BusinessObjectArchimate")]
	partial class ADO {}
	[ModelElement("Composant serveur",", ElementType = "BusinessObjectArchimate")]
	partial class Composant_serveur {}
	[ModelElement("Contrat de service",", ElementType = "BusinessObjectArchimate")]
	partial class Contrat_de_service {}
	[ModelElement("ORM","gestionnaire de mapping objet<->table, ElementType = "BusinessObjectArchimate")]
	partial class ORM {}
	[ModelElement("Schema","sous-ensemble des entités métier associé à un domaine métier. Sera implémenté sous la forme d'un schéma dans la base de données, ElementType = "BusinessObjectArchimate")]
	partial class Schema {}
	[ModelElement("Serveur",", ElementType = "BusinessObjectArchimate")]
	partial class Serveur {}
	[ModelElement("Service","service métier un service n'a normalement pas de traitement avec des effets de bord, ElementType = "BusinessObjectArchimate")]
	partial class Service {}
	[ModelElement("Service CRUD","structure standard d'un service CRUD: référence à l'ADO associé..., ElementType = "BusinessObjectArchimate")]
	partial class Service_CRUD {}
	[ModelElement("Fichier",", ElementType = "BusinessObjectArchimate")]
	partial class Fichier {}
	[ModelElement("Reservation","données d'une réservation intégrant des liens à toutes les entités associés à cette réservation qui peut être validé (avec ses entités) ou pas, ElementType = "BusinessObjectArchimate")]
	partial class Reservation {}
	[ModelElement("Ressource","accès à une ressource partagé avec contrainte, tel qu'un fichier, ElementType = "BusinessObjectArchimate")]
	partial class Ressource {}
	[ModelElement("Transformation","une transformation gère un ensemble d'objets métier pivot pour transformer un ensemble d'objets d'entrée en objets de sortie une transformation est un service sans état, ElementType = "BusinessObjectArchimate")]
	partial class Transformation {}
	[ModelElement("Unité de travail","représente l'ensemble des entités en cours de traitement pour gérer un scénario de travail (implémentation du pattern Unit of work) en cas de persistance des données, correspond à la notion de une ou plusieurs sessions dans un ORM cependant, comme un service peut accéder à plusieurs autres services gérant des schémas de données différents, une unité de travail peut gérer plusieurs sessions ORM en même temps. s'implémente avec le pattern repository qui gère chaque espace de persistance https://msdn.microsoft.com/en-us/library/ff649690.aspx, ElementType = "BusinessObjectArchimate")]
	partial class Unité_de_travail {}
	[ModelElement("Document texte","document type word, ElementType = "BusinessObjectArchimate")]
	partial class Document_texte {}
	[ModelElement("Template","modèle de transformation de données métier en document d'un type spécifique, ElementType = "BusinessObjectArchimate")]
	partial class Template {}
	[ModelElement("Document tableau","document de type tableau Excel, ElementType = "BusinessObjectArchimate")]
	partial class Document_tableau {}
	[ModelElement("Image","document de type image par exemple une image bmp, ElementType = "BusinessObjectArchimate")]
	partial class Image {}
	[ModelElement("Entité métier",", ElementType = "BusinessObjectArchimate")]
	partial class Entité_métier {}
	[ModelElement("Exception métier",", ElementType = "BusinessObjectArchimate")]
	partial class Exception_métier {}
	[ModelElement("Type valeur métier","défini un type métier avec ses propres contraintes de valeurs, ElementType = "BusinessObjectArchimate")]
	partial class Type_valeur_métier {}
	[ModelElement("Règle métier","règle métier combinable, ElementType = "BusinessObjectArchimate")]
	partial class Règle_métier {}
	[ModelElement("Contexte utilisateur métier","container d'entités métiers associé à l'utilisateur courant, ElementType = "BusinessObjectArchimate")]
	partial class Contexte_utilisateur_métier {}
	[ModelElement("Contexte de session métier",", ElementType = "BusinessObjectArchimate")]
	partial class Contexte_de_session_métier {}
	[ModelElement("Aspect métier",", ElementType = "BusinessObjectArchimate")]
	partial class Aspect_métier {}
	[ModelElement("Domaine fonctionnel métier","un domaine fonctionnel spécifique à un domaine métier particulier, ElementType = "BusinessObjectArchimate")]
	partial class Domaine_fonctionnel_métier {}
	[ModelElement("Notification métier",", ElementType = "BusinessObjectArchimate")]
	partial class Notification_métier {}
	[ModelElement("Etat métier",", ElementType = "BusinessObjectArchimate")]
	partial class Etat_métier {}
	[ModelElement("Tâche métier",", ElementType = "BusinessObjectArchimate")]
	partial class Tâche_métier {}
	[ModelElement("Application métier",", ElementType = "BusinessObjectArchimate")]
	partial class Application_métier {}
	[ModelElement("Composant client métier","Un composant métier regroupe un ensemble de workflows métier avec leurs dépendances, ElementType = "BusinessObjectArchimate")]
	partial class Composant_client_métier {}
	[ModelElement("Contexte d'application métier","défini la collection des entités métiers globale spécifique à l'application, ElementType = "BusinessObjectArchimate")]
	partial class Contexte_dapplication_métier {}
	[ModelElement("Tool externe métier","Un tool externe regroupe un ensemble de composants métier livrable qui ne s'appuie pas nécessairement sur le framework de développement standard, ElementType = "BusinessObjectArchimate")]
	partial class Tool_externe_métier {}
	[ModelElement("Vue métier",", ElementType = "BusinessObjectArchimate")]
	partial class Vue_métier {}
	[ModelElement("Widget métier",", ElementType = "BusinessObjectArchimate")]
	partial class Widget_métier {}
	[ModelElement("Workflow métier",", ElementType = "BusinessObjectArchimate")]
	partial class Workflow_métier {}
	[ModelElement("Widget externe métier",", ElementType = "BusinessObjectArchimate")]
	partial class Widget_externe_métier {}
	[ModelElement("Vue externe métier",", ElementType = "BusinessObjectArchimate")]
	partial class Vue_externe_métier {}
	[ModelElement("Tool métier","Un tool regroupe un ensemble de composants métier livrable, ElementType = "BusinessObjectArchimate")]
	partial class Tool_métier {}
	[ModelElement("ADO métier","classe de persistance spécifique à une entité métier implémente les fonctions de persistance associée à une entité métier et à ses entités connectées via des jointures, ElementType = "BusinessObjectArchimate")]
	partial class ADO_métier {}
	[ModelElement("Composant serveur métier",", ElementType = "BusinessObjectArchimate")]
	partial class Composant_serveur_métier {}
	[ModelElement("Contrat de service métier",", ElementType = "BusinessObjectArchimate")]
	partial class Contrat_de_service_métier {}
	[ModelElement("Schéma métier","schéma de la base de données associé à un ensemble d'objets métier, ElementType = "BusinessObjectArchimate")]
	partial class Schéma_métier {}
	[ModelElement("Serveur métier","un serveur métier regroupe l'ensemble des services métier associé à un ou plusieurs schémas, ElementType = "BusinessObjectArchimate")]
	partial class Serveur_métier {}
	[ModelElement("Service CRUD métier","un service métier pilotant des traitements de persistance service à effet de bord pour les traitements CUD n'appelle pas d'autres services mais peut appeler plusieurs traitements de persistance, ElementType = "BusinessObjectArchimate")]
	partial class Service_CRUD_métier {}
	[ModelElement("Service métier","un service définissant essentiellement des traitements métiers sur plusieurs entités métier peut appeler des services CRUD, ElementType = "BusinessObjectArchimate")]
	partial class Service_métier {}
	[ModelElement("Transformation métier","une transformation métier s'appuie sur un ensemble d'entités métier qui sont impactés par la transformation une transformation permet par exemple d'implémenter un traitement d'import, qui est une association entre une ou plusieurs transformations et une ou plusieurs liaisons, ElementType = "BusinessObjectArchimate")]
	partial class Transformation_métier {}
	// Composition relationship

    partial class Application_métier
    {
		List<Composant_client_métier> composant_client_métier_ = 
			new List<Composant_client_métier>();
		public List<Composant_client_métier> Composant_client_métier_ { get => composant_client_métier_; set => composant_client_métier_ = value; }

		List<Tool_externe_métier> tool_externe_métier_ = 
			new List<Tool_externe_métier>();
		public List<Tool_externe_métier> Tool_externe_métier_ { get => tool_externe_métier_; set => tool_externe_métier_ = value; }

	}

    partial class Vue_métier
    {
		List<Container_graphique> container_graphique_ = 
			new List<Container_graphique>();
		public List<Container_graphique> Container_graphique_ { get => container_graphique_; set => container_graphique_ = value; }

	}

    partial class Domaine_fonctionnel_métier
    {
		List<Entité_métier> entité_métier_ = 
			new List<Entité_métier>();
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}

    partial class Composant_client_métier
    {
		List<Fonctionnalité> fonctionnalité_ = 
			new List<Fonctionnalité>();
		public List<Fonctionnalité> Fonctionnalité_ { get => fonctionnalité_; set => fonctionnalité_ = value; }

	}

    partial class Serveur_métier
    {
		List<Composant_serveur_métier> composant_serveur_métier_ = 
			new List<Composant_serveur_métier>();
		public List<Composant_serveur_métier> Composant_serveur_métier_ { get => composant_serveur_métier_; set => composant_serveur_métier_ = value; }

	}

    partial class Entité_métier
    {
		List<Relation> relation_ = 
			new List<Relation>();
		public List<Relation> Relation_ { get => relation_; set => relation_ = value; }

	}

    partial class Aide_application
    {
		List<Aide_contextuelle> aide_contextuelle_ = 
			new List<Aide_contextuelle>();
		public List<Aide_contextuelle> Aide_contextuelle_ { get => aide_contextuelle_; set => aide_contextuelle_ = value; }

	}

    partial class Lanceur
    {
		List<Composant_client> composant_client_ = 
			new List<Composant_client>();
		public List<Composant_client> Composant_client_ { get => composant_client_; set => composant_client_ = value; }

	}

    partial class Container_graphique
    {
		List<Widget_externe> widget_externe_ = 
			new List<Widget_externe>();
		public List<Widget_externe> Widget_externe_ { get => widget_externe_; set => widget_externe_ = value; }

		List<Vue_externe> vue_externe_ = 
			new List<Vue_externe>();
		public List<Vue_externe> Vue_externe_ { get => vue_externe_; set => vue_externe_ = value; }

	}

    partial class Vue_externe
    {
		List<Widget_externe> widget_externe_ = 
			new List<Widget_externe>();
		public List<Widget_externe> Widget_externe_ { get => widget_externe_; set => widget_externe_ = value; }

	}

    partial class Vue_externe_métier
    {
		List<Widget_externe_métier> widget_externe_métier_ = 
			new List<Widget_externe_métier>();
		public List<Widget_externe_métier> Widget_externe_métier_ { get => widget_externe_métier_; set => widget_externe_métier_ = value; }

	}


	// Specialization relationship

	partial class GPS : Périphérique_mobile {}
	partial class Exception_technique : Exception {}
	partial class Exception_métier : Exception {}
	partial class Tool_externe : Tool {}
	partial class Composant_client : Composant {}
	partial class Tool : Composant_client {}
	partial class Composant_serveur : Composant {}
	partial class Reservation : Transaction {}
	partial class Appareil_photo : Périphérique_mobile {}
	partial class Gesture : Périphérique_mobile {}
	partial class Accéléromètre : Périphérique_mobile {}
	partial class Reconnaissance_vocale : Périphérique_mobile {}
	partial class Service_métier : Service {}
	partial class Workflow_métier : Workflow {}
	partial class Application_métier : Application {}
	partial class Tool_externe_métier : Tool_externe {}
	partial class Composant_client_métier : Composant_client {}
	partial class Contexte_dapplication_métier : Contexte_dapplication {}
	partial class ADO_métier : ADO {}
	partial class Schéma_métier : Schema {}
	partial class Entité_métier : Entité {}
	partial class Vue_métier : Vue {}
	partial class Service_CRUD : Service {}
	partial class Service_CRUD_métier : Service_CRUD {}
	partial class Règle_métier : Règle {}
	partial class Contexte_utilisateur_métier : Contexte_utilisateur {}
	partial class Contexte_de_session_métier : Contexte_de_session {}
	partial class Domaine_fonctionnel_métier : Domaine_fonctionnel {}
	partial class Contrat_de_service_métier : Contrat_de_service {}
	partial class Aspect_métier : Aspect {}
	partial class Notification_métier : Notification {}
	partial class Widget_métier : Widget {}
	partial class Serveur_métier : Serveur {}
	partial class Composant_serveur_métier : Composant_serveur {}
	partial class Etat_métier : Etat {}
	partial class Widget_externe_métier : Widget_externe {}
	partial class Transformation_métier : Transformation {}
	partial class Vue_externe_métier : Vue_externe {}
	partial class Transformation : Service {}
	partial class Périphérique_mobile : Périphérique {}
	partial class Tool_métier : Tool {}
	partial class Tâche_métier : Tâche {}
	partial class Document_texte : Document {}
	partial class Document_tableau : Document {}
	partial class Image : Document {}

	// Aggregation relationship

    partial class Composant
    {
		List<Fichier> fichier_ ;
		public List<Fichier> Fichier_ { get => fichier_; set => fichier_ = value; }

		List<Module> module_ ;
		public List<Module> Module_ { get => module_; set => module_ = value; }

	}
    partial class Transaction
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class ORM
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Entité_métier
    {
		List<Notification> notification_ ;
		public List<Notification> Notification_ { get => notification_; set => notification_ = value; }

		List<Notification_métier> notification_métier_ ;
		public List<Notification_métier> Notification_métier_ { get => notification_métier_; set => notification_métier_ = value; }

	}
    partial class Workflow_métier
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

		List<Vue_métier> vue_métier_ ;
		public List<Vue_métier> Vue_métier_ { get => vue_métier_; set => vue_métier_ = value; }

	}
    partial class Contexte_dapplication_métier
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Contexte_de_session_métier
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Contexte_utilisateur_métier
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Composant_client_métier
    {
	}
    partial class Container_graphique
    {
		List<Widget> widget_ ;
		public List<Widget> Widget_ { get => widget_; set => widget_ = value; }

	}
    partial class Contexte_de_session
    {
		List<Entité> entité_ ;
		public List<Entité> Entité_ { get => entité_; set => entité_ = value; }

		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Contexte_dapplication
    {
		List<Entité> entité_ ;
		public List<Entité> Entité_ { get => entité_; set => entité_ = value; }

	}
    partial class Domaine_fonctionnel_métier
    {
		List<Autorisation> autorisation_ ;
		public List<Autorisation> Autorisation_ { get => autorisation_; set => autorisation_ = value; }

	}
    partial class Role
    {
		List<Utilisateur> utilisateur_ ;
		public List<Utilisateur> Utilisateur_ { get => utilisateur_; set => utilisateur_ = value; }

		List<Domaine_fonctionnel_métier> domaine_fonctionnel_métier_ ;
		public List<Domaine_fonctionnel_métier> Domaine_fonctionnel_métier_ { get => domaine_fonctionnel_métier_; set => domaine_fonctionnel_métier_ = value; }

		List<Autorisation> autorisation_ ;
		public List<Autorisation> Autorisation_ { get => autorisation_; set => autorisation_ = value; }

	}
    partial class Tool_externe_métier
    {
		List<Composant_client_métier> composant_client_métier_ ;
		public List<Composant_client_métier> Composant_client_métier_ { get => composant_client_métier_; set => composant_client_métier_ = value; }

	}
    partial class Unité_de_travail
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Schéma_métier
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Service_CRUD_métier
    {
		List<ADO_métier> aDO_métier_ ;
		public List<ADO_métier> ADO_métier_ { get => aDO_métier_; set => aDO_métier_ = value; }

	}
    partial class Vue_métier
    {
		List<Widget> widget_ ;
		public List<Widget> Widget_ { get => widget_; set => widget_ = value; }

		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Widget_métier
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Contexte_utilisateur
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Fonctionnalité
    {
		List<Autorisation> autorisation_ ;
		public List<Autorisation> Autorisation_ { get => autorisation_; set => autorisation_ = value; }

	}
    partial class Tool
    {
		List<Composant_client> composant_client_ ;
		public List<Composant_client> Composant_client_ { get => composant_client_; set => composant_client_ = value; }

	}
    partial class Service_métier
    {
		List<Règle_métier> règle_métier_ ;
		public List<Règle_métier> Règle_métier_ { get => règle_métier_; set => règle_métier_ = value; }

	}

	// Association relationship

    partial class Lanceur
    {
		Workflow workflow_ ;
		public Workflow Workflow_ { get => workflow_; set => workflow_ = value; }

	}

    partial class Fonctionalité_technique
    {
		Service service_ ;
		public Service Service_ { get => service_; set => service_ = value; }

	}

    partial class Ressource
    {
		Fichier fichier_ ;
		public Fichier Fichier_ { get => fichier_; set => fichier_ = value; }

	}

    partial class Utilisateur
    {
		Contexte_utilisateur contexte_utilisateur_ ;
		public Contexte_utilisateur Contexte_utilisateur_ { get => contexte_utilisateur_; set => contexte_utilisateur_ = value; }

	}

    partial class Application
    {
		Contexte_dapplication contexte_dapplication_ ;
		public Contexte_dapplication Contexte_dapplication_ { get => contexte_dapplication_; set => contexte_dapplication_ = value; }

		Aide_application aide_application_ ;
		public Aide_application Aide_application_ { get => aide_application_; set => aide_application_ = value; }

	}

    partial class Factory
    {
		Moteur_IOC moteur_IOC_ ;
		public Moteur_IOC Moteur_IOC_ { get => moteur_IOC_; set => moteur_IOC_ = value; }

	}

    partial class Service
    {
		Transaction transaction_ ;
		public Transaction Transaction_ { get => transaction_; set => transaction_ = value; }

	}

    partial class ADO
    {
		Unité_de_travail unité_de_travail_ ;
		public Unité_de_travail Unité_de_travail_ { get => unité_de_travail_; set => unité_de_travail_ = value; }

		Requete requete_ ;
		public Requete Requete_ { get => requete_; set => requete_ = value; }

	}

    partial class ORM
    {
		Unité_de_travail unité_de_travail_ ;
		public Unité_de_travail Unité_de_travail_ { get => unité_de_travail_; set => unité_de_travail_ = value; }

		ADO aDO_ ;
		public ADO ADO_ { get => aDO_; set => aDO_ = value; }

		Transaction transaction_ ;
		public Transaction Transaction_ { get => transaction_; set => transaction_ = value; }

	}

    partial class Verrou
    {
		ORM oRM_ ;
		public ORM ORM_ { get => oRM_; set => oRM_ = value; }

	}

    partial class Requete
    {
	}

    partial class Service_CRUD
    {
		Entité_métier entité_métier_ ;
		public Entité_métier Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}

    partial class Entité_métier
    {
		Type_valeur_métier type_valeur_métier_ ;
		public Type_valeur_métier Type_valeur_métier_ { get => type_valeur_métier_; set => type_valeur_métier_ = value; }

	}

    partial class Aspect
    {
	}

    partial class Autorisation
    {
	}

    partial class ADO_métier
    {
		Entité_métier entité_métier_ ;
		public Entité_métier Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}

    partial class Règle_métier
    {
		Entité_métier entité_métier_ ;
		public Entité_métier Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}

    partial class Service_métier
    {
		Contrat_de_service_métier contrat_de_service_métier_ ;
		public Contrat_de_service_métier Contrat_de_service_métier_ { get => contrat_de_service_métier_; set => contrat_de_service_métier_ = value; }

	}

    partial class Fonctionnalité
    {
		Workflow_métier workflow_métier_ ;
		public Workflow_métier Workflow_métier_ { get => workflow_métier_; set => workflow_métier_ = value; }

	}

    partial class Composant_serveur_métier
    {
		Schéma_métier schéma_métier_ ;
		public Schéma_métier Schéma_métier_ { get => schéma_métier_; set => schéma_métier_ = value; }

	}

    partial class Schéma_métier
    {
		Domaine_fonctionnel_métier domaine_fonctionnel_métier_ ;
		public Domaine_fonctionnel_métier Domaine_fonctionnel_métier_ { get => domaine_fonctionnel_métier_; set => domaine_fonctionnel_métier_ = value; }

	}

    partial class Aide_contextuelle
    {
		Widget widget_ ;
		public Widget Widget_ { get => widget_; set => widget_ = value; }

	}

    partial class Type_valeur_métier
    {
	}

    partial class Unité_de_travail
    {
		Service service_ ;
		public Service Service_ { get => service_; set => service_ = value; }

	}

    partial class Service_CRUD_métier
    {
		Entité_métier entité_métier_ ;
		public Entité_métier Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}

    partial class Vue
    {
	}

    partial class Vue_métier
    {
	}

    partial class Workflow_métier
    {
	}

    partial class Notification
    {
	}

    partial class Exception_métier
    {
	}

    partial class Etat_métier
    {
	}

    partial class Etat
    {
	}

    partial class Périphérique
    {
	}

    partial class Tâche_métier
    {
		Workflow_métier workflow_métier_ ;
		public Workflow_métier Workflow_métier_ { get => workflow_métier_; set => workflow_métier_ = value; }

		Service_métier service_métier_ ;
		public Service_métier Service_métier_ { get => service_métier_; set => service_métier_ = value; }

	}

    partial class Template
    {
		Document document_ ;
		public Document Document_ { get => document_; set => document_ = value; }

	}

    partial class Workflow
    {
		Machine_à_état machine_à_état_ ;
		public Machine_à_état Machine_à_état_ { get => machine_à_état_; set => machine_à_état_ = value; }

	}

    partial class Machine_à_état
    {
		Workflow_métier workflow_métier_ ;
		public Workflow_métier Workflow_métier_ { get => workflow_métier_; set => workflow_métier_ = value; }

	}

}

