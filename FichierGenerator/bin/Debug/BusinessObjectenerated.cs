



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

	[ModelElement("Message","un texte traduisible en plusieurs langues, ElementType = "BusinessObjectArchimate")]
	partial class Message {}

	[ModelElement("Module","ensemble d'artefacts exécutables assurant une fonctionnalité spécifique d'un composant (en général associé à une couche) un module correspond par exemple à l'ensemble des workflows d'un composant un module dépend d'autres modules d'un même composant un module s'implémente sous la forme d'un ensemble d'assemblies avec leurs dépendances un module peut être réutilisé entre plusieurs composants, ElementType = "BusinessObjectArchimate")]
	partial class Module {}

	[ModelElement("Moteur IOC",", ElementType = "BusinessObjectArchimate")]
	partial class Moteur_IOC {}

	[ModelElement("Méta-information","permet d'ajouter une information de méta-modèle à n'importe élément, comme par exemple: - une référence à une exigence - une propriété d'un élément qui peut influer l'exécution dans l'infrastructure, comme par exemple un service stateful, ElementType = "BusinessObjectArchimate")]
	partial class Métainformation {}

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

	[ModelElement("Validateur","gestion de contraintes sur des champs implémenté sous la forme d'un attribut associé à un champ peut être combinable entre eux exemple de validateur: champ numérique, champ obligatoire, taille du champ, ElementType = "BusinessObjectArchimate")]
	partial class Validateur {}

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

	[ModelElement("Application Web",", ElementType = "BusinessObjectArchimate")]
	partial class Application_Web {}

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

	[ModelElement("Classe métier","une classe métier modélisant une structure, ElementType = "BusinessObjectArchimate")]
	partial class Classe_métier {}

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

	[ModelElement("ADO générique",", ElementType = "BusinessObjectArchimate")]
	partial class ADO_générique {}

	[ModelElement("Alerte","informations associées à une alerte une alerte est crée lors de la réception de notification validant certains critères, ElementType = "BusinessObjectArchimate")]
	partial class Alerte {}

	[ModelElement("Application externe","informations associés à une application externe: localisation (url...), description, version associée, etc..., ElementType = "BusinessObjectArchimate")]
	partial class Application_externe {}

	[ModelElement("Cache appel","container de résultats de méthodes temporaire, ElementType = "BusinessObjectArchimate")]
	partial class Cache_appel {}

	[ModelElement("Cache d'objet","container d'objets métier temporaire, ElementType = "BusinessObjectArchimate")]
	partial class Cache_dobjet {}

	[ModelElement("Client","entreprise utilisatrice de l'application, ElementType = "BusinessObjectArchimate")]
	partial class Client {}

	[ModelElement("Deployeur",", ElementType = "BusinessObjectArchimate")]
	partial class Deployeur {}

	[ModelElement("Extraction","défini le sous-ensemble du schéma de données selon différents critères: - date de l'extraction - ensemble des objets métiers (schéma) - critères de recherche additionnel (par exemple, nom commençant par P) est associé aux traitements d'import-export, de synchronisation, ElementType = "BusinessObjectArchimate")]
	partial class Extraction {}

	[ModelElement("Licence","ensemble de fonctionnalités autorisés pour un client avec leur nombre d'utilisateurs simultanés, le nombre d'opérations,, ElementType = "BusinessObjectArchimate")]
	partial class Licence {}

	[ModelElement("Périphérique technique",", ElementType = "BusinessObjectArchimate")]
	partial class Périphérique_technique {}

	[ModelElement("Scénario (A COMPLETER)",", ElementType = "BusinessObjectArchimate")]
	partial class Scénario_A_COMPLETER {}

	[ModelElement("Service générique",", ElementType = "BusinessObjectArchimate")]
	partial class Service_générique {}

	[ModelElement("Tool externe",", ElementType = "BusinessObjectArchimate")]
	partial class Tool_externe {}

	[ModelElement("Tâche","traitement géré par le planificateur associe un contexte de données, un contexte d'exéctution (quand, où) un contexte de traitement (traitement à lancer) peut être suivi, ElementType = "BusinessObjectArchimate")]
	partial class Tâche {}

	[ModelElement("Version","mémorise les dépendances de composants associés à une version applicative, ElementType = "BusinessObjectArchimate")]
	partial class Version {}

	[ModelElement("Vue applicatif","vue du container, ElementType = "BusinessObjectArchimate")]
	partial class Vue_applicatif {}

	[ModelElement("Vue générique","container générique de composants graphiques peut contenir un nombre arbitraire de composants de tout type, ElementType = "BusinessObjectArchimate")]
	partial class Vue_générique {}

	[ModelElement("Workflow générique",", ElementType = "BusinessObjectArchimate")]
	partial class Workflow_générique {}

	[ModelElement("Tool externe métier",", ElementType = "BusinessObjectArchimate")]
	partial class Tool_externe_métier {}

	[ModelElement("Alerte métier",", ElementType = "BusinessObjectArchimate")]
	partial class Alerte_métier {}

	[ModelElement("Tâche métier",", ElementType = "BusinessObjectArchimate")]
	partial class Tâche_métier {}

	[ModelElement("Péripherique spécifique",", ElementType = "BusinessObjectArchimate")]
	partial class Péripherique_spécifique {}

	[ModelElement("Scénario métier","défini un service générique construit par l'utilisateur, ElementType = "BusinessObjectArchimate")]
	partial class Scénario_métier {}

	[ModelElement("ADO Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class ADO_Hapicare {}

	[ModelElement("ADO Nhibernate",", ElementType = "BusinessObjectArchimate")]
	partial class ADO_Nhibernate {}

	[ModelElement("Application Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Application_Hapicare {}

	[ModelElement("Aspects Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Aspects_Hapicare {}

	[ModelElement("Entités Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Entités_Hapicare {}

	[ModelElement("Exceptions Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Exceptions_Hapicare {}

	[ModelElement("Services CRUD Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Services_CRUD_Hapicare {}

	[ModelElement("Services Métier Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Services_Métier_Hapicare {}

	[ModelElement("Vue web",", ElementType = "BusinessObjectArchimate")]
	partial class Vue_web {}

	[ModelElement("Vues Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Vues_Hapicare {}

	[ModelElement("Workflows Hapicare",", ElementType = "BusinessObjectArchimate")]
	partial class Workflows_Hapicare {}

	[ModelElement("Entité métier","Un élément passif d'information qui est pertinent d'un point de vue métier exemple: patient, ElementType = "BusinessObjectArchimate")]
	partial class Entité_métier {}

	[ModelElement("entité:Entité métier",", ElementType = "BusinessObjectArchimate")]
	partial class EntitéEntité_métier {}

	[ModelElement("Application Function",", ElementType = "ApplicationFunctionArchimate")]
	partial class Application_Function {}

	[ModelElement("Vue Entité générique",", ElementType = "ApplicationFunctionArchimate")]
	partial class Vue_Entité_générique {}

	[ModelElement("Vue Liste générique",", ElementType = "ApplicationFunctionArchimate")]
	partial class Vue_Liste_générique {}

	[ModelElement("Application Interface",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Application_Interface {}

	[ModelElement("Application Service",", ElementType = "ApplicationServiceArchimate")]
	partial class Application_Service {}

	[ModelElement("Application Function",", ElementType = "ApplicationFunctionArchimate")]
	partial class Application_Function {}

	[ModelElement("Composant persistance NHibernate",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_persistance_NHibernate {}

	[ModelElement("Application Service",", ElementType = "ApplicationServiceArchimate")]
	partial class Application_Service {}

	[ModelElement("Client lourd gestion accueil","programme à lancer pour la saisie des informations, ElementType = "ApplicationComponentArchimate")]
	partial class Client_lourd_gestion_accueil {}

	[ModelElement("Modèle métier partagé","composant définissant les modèles d'objets métier partagé par tout les autres composants, ElementType = "ApplicationComponentArchimate")]
	partial class Modèle_métier_partagé {}

	[ModelElement("Serveur applicatif","hébergement des service applicatifs, ElementType = "ApplicationComponentArchimate")]
	partial class Serveur_applicatif {}

	[ModelElement("Services applicatif","implémentation des services applicatifs, ElementType = "ApplicationComponentArchimate")]
	partial class Services_applicatif {}

	[ModelElement("gestion patient","accès CRUD aux patients accès aux entités métier associées:, ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_patient {}

	[ModelElement("Gestion consultation","accès CRUD aux consultations, ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_consultation {}

	[ModelElement("Gestion prise en charge","accès CRUD aux prises en charge, ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_prise_en_charge {}

	[ModelElement("Gestion Examen","accès CRUD aux examens, ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_Examen {}

	[ModelElement("Evaluation des risques","évaluation des risques sur un accouchement en fonction des informations du patient, ElementType = "ApplicationServiceArchimate")]
	partial class Evaluation_des_risques {}

	[ModelElement("Gestion des personnes","accès R aux personnes, ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_des_personnes {}

	[ModelElement("Gestion de la connexion","validation ou invalidation de l'accès au système en fonction des identifiants, ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_de_la_connexion {}

	[ModelElement("Gestion vue accouchement","gestion de la saisie des données d'accueil pour l'accouchement persistance des informations, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_accouchement {}

	[ModelElement("Gestion vue connexion","gestion de la saisie des données d'identification de l'utilisateur ouverture des accès à l'utilisateur, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_connexion {}

	[ModelElement("Gestion vue consultation","gestion de la saisie des données de consultation persistance des informations, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_consultation {}

	[ModelElement("Gestion vue création patient","gestion de la saisie des données du patient persistance des informations, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_création_patient {}

	[ModelElement("Gestion vue planification echographie","gestion de la saisie des données pour la planification d'un examen d'échographie persistance des informations, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_planification_echographie {}

	[ModelElement("Gestion vue paramètres","gestion de la saisie des paramètres d'application, en particulier les informations d'accès aux outils externes (serveurs et ports) persistance des informations, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_paramètres {}

	[ModelElement("Gestion vue planification accouchement","gestion de la saisie des données de planification d'un accouchement persistance des informations, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_planification_accouchement {}

	[ModelElement("Gestion vue recherche patient","gestion de la saisie des identifiants des patients en vue de leur affichage, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_recherche_patient {}

	[ModelElement("Gestion présentation offre","affichage des informations du patient traité affichage des actionneurs (boutons, menus) en fonction de l'avancement du processus métier, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_présentation_offre {}

	[ModelElement("Gestion workflow métier","gère l'enchainement des processus applicatif en fonction de l'état en cours du processus métier, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_workflow_métier {}

	[ModelElement("Gestion vue application","gestion de la vue générale de l'application, permettant l'accès aux autres vues, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_application {}

	[ModelElement("Gestion des règles métier","affichage R des règles métier, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_des_règles_métier {}

	[ModelElement("Gestion vue examen","gestion de la saisie des données d'examen persistance des informations, ElementType = "ApplicationProcessArchimate")]
	partial class Gestion_vue_examen {}

	[ModelElement("Persistance données",", ElementType = "ApplicationFunctionArchimate")]
	partial class Persistance_données {}

	[ModelElement("Règles d'évaluation des risques",", ElementType = "ApplicationFunctionArchimate")]
	partial class Règles_dévaluation_des_risques {}

	[ModelElement("Moteur BPMN light","gère un automate d'avancement des tâches de processus métier ne gère que les fonctions mimales nécessaires ne gère pas la persistance des processus en cours d'exécution, ElementType = "ApplicationFunctionArchimate")]
	partial class Moteur_BPMN_light {}

	[ModelElement("Pilotage moteur BPMN","fonctionnalité de pilotage d'un moteur BPMN remplacable, ElementType = "ApplicationFunctionArchimate")]
	partial class Pilotage_moteur_BPMN {}

	[ModelElement("Log","log dans un fichier: - des fonctions de persistance - des erreurs applicatives, ElementType = "ApplicationFunctionArchimate")]
	partial class Log {}

	[ModelElement("Service standard","traitement commun à tout les services métier, ElementType = "ApplicationFunctionArchimate")]
	partial class Service_standard {}

	[ModelElement("Factory","créateur d'objet de service permettant leur remplacement par une autre implémentation, ElementType = "ApplicationFunctionArchimate")]
	partial class Factory {}

	[ModelElement("Services métier accueil patient","traitements métier de l'accueil du patient, ElementType = "ApplicationFunctionArchimate")]
	partial class Services_métier_accueil_patient {}

	[ModelElement("Appel de services",", ElementType = "ApplicationFunctionArchimate")]
	partial class Appel_de_services {}

	[ModelElement("Lancement de l'application",", ElementType = "ApplicationEventArchimate")]
	partial class Lancement_de_lapplication {}

	[ModelElement("IMoteurBPMN","interface d'accès à un moteur BPMN, ElementType = "ApplicationInterfaceArchimate")]
	partial class IMoteurBPMN {}

	[ModelElement("IServices métier",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IServices_métier {}

	[ModelElement("Accès  Service Métier",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Accès__Service_Métier {}

	[ModelElement("Accès Service technique",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Accès_Service_technique {}

	[ModelElement("Accès Service workflow",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Accès_Service_workflow {}

	[ModelElement("Accès Traitement CRUD",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Accès_Traitement_CRUD {}

	[ModelElement("Accès service externe",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Accès_service_externe {}

	[ModelElement("Accès service externe local",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Accès_service_externe_local {}

	[ModelElement("Bootstrap Application",", ElementType = "ApplicationComponentArchimate")]
	partial class Bootstrap_Application {}

	[ModelElement("Cas d'utilisation workflow",", ElementType = "ApplicationFunctionArchimate")]
	partial class Cas_dutilisation_workflow {}

	[ModelElement("Composant externe",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_externe {}

	[ModelElement("Composant métier externe",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_métier_externe {}

	[ModelElement("Composant persistance",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_persistance {}

	[ModelElement("Composant service métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_service_métier {}

	[ModelElement("Composant service métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_service_métier {}

	[ModelElement("Composant service technique",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_service_technique {}

	[ModelElement("Composant technique local",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_technique_local {}

	[ModelElement("Composant workflow",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_workflow {}

	[ModelElement("Container IHM",", ElementType = "ApplicationComponentArchimate")]
	partial class Container_IHM {}

	[ModelElement("Interface L2",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Interface_L2 {}

	[ModelElement("Interface pilotage externe",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Interface_pilotage_externe {}

	[ModelElement("Interface vue application",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Interface_vue_application {}

	[ModelElement("L2 Server",", ElementType = "ApplicationComponentArchimate")]
	partial class L2_Server {}

	[ModelElement("ORM standard",", ElementType = "ApplicationInterfaceArchimate")]
	partial class ORM_standard {}

	[ModelElement("Persistance objet",", ElementType = "ApplicationFunctionArchimate")]
	partial class Persistance_objet {}

	[ModelElement("Service métier",", ElementType = "ApplicationServiceArchimate")]
	partial class Service_métier {}

	[ModelElement("Service métier",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Service_métier {}

	[ModelElement("Service métier externe",", ElementType = "ApplicationServiceArchimate")]
	partial class Service_métier_externe {}

	[ModelElement("Service métier local",", ElementType = "ApplicationServiceArchimate")]
	partial class Service_métier_local {}

	[ModelElement("Service technique",", ElementType = "ApplicationServiceArchimate")]
	partial class Service_technique {}

	[ModelElement("Service technique",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Service_technique {}

	[ModelElement("Service technique local",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Service_technique_local {}

	[ModelElement("Vue application",", ElementType = "ApplicationFunctionArchimate")]
	partial class Vue_application {}

	[ModelElement("Vue tool externe",", ElementType = "ApplicationFunctionArchimate")]
	partial class Vue_tool_externe {}

	[ModelElement("Vue tool intégré",", ElementType = "ApplicationFunctionArchimate")]
	partial class Vue_tool_intégré {}

	[ModelElement("composant IHM",", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_IHM {}

	[ModelElement("interface IHM externe",", ElementType = "ApplicationInterfaceArchimate")]
	partial class Interface_IHM_externe {}

	[ModelElement("Application",", ElementType = "ApplicationComponentArchimate")]
	partial class Application {}

	[ModelElement("Certified device",", ElementType = "ApplicationComponentArchimate")]
	partial class Certified_device {}

	[ModelElement("Clinical Pathway orchestrator",", ElementType = "ApplicationComponentArchimate")]
	partial class Clinical_Pathway_orchestrator {}

	[ModelElement("Communication",", ElementType = "ApplicationComponentArchimate")]
	partial class Communication {}

	[ModelElement("Compliance Monitoring",", ElementType = "ApplicationComponentArchimate")]
	partial class Compliance_Monitoring {}

	[ModelElement("Context visualization Application",", ElementType = "ApplicationComponentArchimate")]
	partial class Context_visualization_Application {}

	[ModelElement("Decision support application",", ElementType = "ApplicationComponentArchimate")]
	partial class Decision_support_application {}

	[ModelElement("Decision support for prescription",", ElementType = "ApplicationComponentArchimate")]
	partial class Decision_support_for_prescription {}

	[ModelElement("Decision support for symptom checking Application",", ElementType = "ApplicationComponentArchimate")]
	partial class Decision_support_for_symptom_checking_Application {}

	[ModelElement("IOT business process Management",", ElementType = "ApplicationComponentArchimate")]
	partial class IOT_business_process_Management {}

	[ModelElement("Medical IoT service",", ElementType = "ApplicationComponentArchimate")]
	partial class Medical_IoT_service {}

	[ModelElement("Patient mobile application",", ElementType = "ApplicationComponentArchimate")]
	partial class Patient_mobile_application {}

	[ModelElement("Processus Triage",", ElementType = "ApplicationFunctionArchimate")]
	partial class Processus_Triage {}

	[ModelElement("Reasoning engine on complex events",", ElementType = "ApplicationFunctionArchimate")]
	partial class Reasoning_engine_on_complex_events {}

	[ModelElement("UnCertified service",", ElementType = "ApplicationComponentArchimate")]
	partial class UnCertified_service {}

	[ModelElement("Virtual medical services",", ElementType = "ApplicationComponentArchimate")]
	partial class Virtual_medical_services {}

	[ModelElement("Visualization of Patient Health Timeline",", ElementType = "ApplicationComponentArchimate")]
	partial class Visualization_of_Patient_Health_Timeline {}

	[ModelElement("Domain","implémente les mécanismes standard de toutes les entités, ElementType = "ApplicationComponentArchimate")]
	partial class Domain {}

	[ModelElement("Domaine métier","implémente toutes les entités métier, ElementType = "ApplicationComponentArchimate")]
	partial class Domaine_métier {}

	[ModelElement("Traitement Validation type métier","traitement de validation des valeurs autorisées associé aux objets métier ce traitement est commun à la couche présentation (contrôle de saisie), workflow et service (exposition en tant que service externe), ElementType = "ApplicationFunctionArchimate")]
	partial class Traitement_Validation_type_métier {}

	[ModelElement("IView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IView {}

	[ModelElement("IContainerControl","interface de manipulation d'un contrôle container pouvant intégrer des vues, ElementType = "ApplicationInterfaceArchimate")]
	partial class IContainerControl {}

	[ModelElement("IControl",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IControl {}

	[ModelElement("IViewSrv",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IViewSrv {}

	[ModelElement("IFileDialogView","interface de manipulation de l'accès à une arborescence de fichiers l'interface suit le principe de décomposition entre la vue et le workflow, ElementType = "ApplicationInterfaceArchimate")]
	partial class IFileDialogView {}

	[ModelElement("IMessageBoxView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IMessageBoxView {}

	[ModelElement("IDocumentEditorView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IDocumentEditorView {}

	[ModelElement("ITextEditorView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class ITextEditorView {}

	[ModelElement("IProgressView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IProgressView {}

	[ModelElement("IDiffView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IDiffView {}

	[ModelElement("IWaitView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IWaitView {}

	[ModelElement("IDevice","interface de communication d'un périphérique, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDevice {}

	[ModelElement("IAuthentificationView",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IAuthentificationView {}

	[ModelElement("IContainerControlExample",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IContainerControlExample {}

	[ModelElement("IControlExample",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IControlExample {}

	[ModelElement("IDeviceExample","exemple d'interface de communication d'un périphérique, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDeviceExample {}

	[ModelElement("IViewExample",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IViewExample {}

	[ModelElement("IComposerViewSrv","interface de gestion du compositeur de vues, ElementType = "ApplicationInterfaceArchimate")]
	partial class IComposerViewSrv {}

	[ModelElement("IDeviceSrv","interface du gestionnaire de périphériques, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDeviceSrv {}

	[ModelElement("IKeyboardSrv","interface pour la gestion du clavier et des raccourcis, ElementType = "ApplicationInterfaceArchimate")]
	partial class IKeyboardSrv {}

	[ModelElement("IRenderViewSrv","interface de gestion du renderer de vues, ElementType = "ApplicationInterfaceArchimate")]
	partial class IRenderViewSrv {}

	[ModelElement("IReportDocumentSrv","interface de gestion du générateur de documents report, ElementType = "ApplicationInterfaceArchimate")]
	partial class IReportDocumentSrv {}

	[ModelElement("Presentation.Interface","regroupe toutes les interfaces utilisables sur les éléments de la couche présentation, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Interface {}

	[ModelElement("Presentation",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation {}

	[ModelElement("Interface Controle",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_Controle {}

	[ModelElement("Presentation.Desktop.Web","classes de la couche présentation sur windows pour le web, par exemple la construction HTML, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Desktop_Web {}

	[ModelElement("Presentation.Smartphone","composant de classes de gestion de la mobilité, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Smartphone {}

	[ModelElement("Presentation.Tablet","classes de la couche présentation sur tout types de tablettes, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Tablet {}

	[ModelElement("Presentation.Tablet.Windows",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Tablet_Windows {}

	[ModelElement("Presentation.Desktop.Mac","classes de la couche présentation sur le desktop Mac (par exemple XCode), ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Desktop_Mac {}

	[ModelElement("Presentation.Desktop.Linux","classes de la couche présentation sur le desktop spécifique à Linux (par exemple GTK#), ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Desktop_Linux {}

	[ModelElement("Presentation.Tablet.Android","classes de la couche présentation sur tablettes android, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Tablet_Android {}

	[ModelElement("Presentation.Tablet.IOS","classes de la couche présentation sur tablettes IOS, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Tablet_IOS {}

	[ModelElement("Presentation.Smartphone.Android",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Smartphone_Android {}

	[ModelElement("Presentation.Smartphone.IOS",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Smartphone_IOS {}

	[ModelElement("Presentation.Smartphone.Web",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Smartphone_Web {}

	[ModelElement("Presentation.Tablet.Web",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Tablet_Web {}

	[ModelElement("Presentation.Desktop","classes de la couche présentation sur le desktop, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Desktop {}

	[ModelElement("Presentation.Desktop.Windows","classes de la couche présentation sur windows pour le client lourd, par exemple la construction de vues en WPF ou winforms, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Desktop_Windows {}

	[ModelElement("Presentation.Desktop.Web.Smartclient","classes de la couche présentation sur le desktop propre au web pour les application évoluées, par exemple des composants Javascripts, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Desktop_Web_Smartclient {}

	[ModelElement("Presentation.Desktop.Mac.Web","classes de la couche présentation sur le desktop Mac, ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Desktop_Mac_Web {}

	[ModelElement("Presentation.Tablet.Web.SmartClient",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Tablet_Web_SmartClient {}

	[ModelElement("Controle métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Controle_métier {}

	[ModelElement("Interface Controle métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_Controle_métier {}

	[ModelElement("Interface Vue métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_Vue_métier {}

	[ModelElement("Vue métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Vue_métier {}

	[ModelElement("Méthodes CVueExample",", ElementType = "ApplicationFunctionArchimate")]
	partial class Méthodes_CVueExample {}

	[ModelElement("Méthodes CContainerControlExample",", ElementType = "ApplicationFunctionArchimate")]
	partial class Méthodes_CContainerControlExample {}

	[ModelElement("Méthodes CControlExample",", ElementType = "ApplicationFunctionArchimate")]
	partial class Méthodes_CControlExample {}

	[ModelElement("CTransactionPresentationFct (EN COURS)","implémentation des transactions couche présentation: gestion du undo, ElementType = "ApplicationFunctionArchimate")]
	partial class CTransactionPresentationFct_EN_COURS {}

	[ModelElement("IWorkflow","interface standard d'un workflow, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflow {}

	[ModelElement("ISequence","interface standard d'une séquence d'un workflow, ElementType = "ApplicationInterfaceArchimate")]
	partial class ISequence {}

	[ModelElement("IWorkflowEngine","interface commune de gestion du moteur de workflow, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowEngine {}

	[ModelElement("IWorkflowExample",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowExample {}

	[ModelElement("IElementBPM","interface de gestion d'un élément dynamique du modèle d'exécution BPM est associé à un élément de modèle et à un acteur exécutant, ElementType = "ApplicationInterfaceArchimate")]
	partial class IElementBPM {}

	[ModelElement("IModelBPM","interface de gestion d'un élément du modèle de processus BPM est associé à un acteur responsable, ElementType = "ApplicationInterfaceArchimate")]
	partial class IModelBPM {}

	[ModelElement("IWorkflowBPMEngine","interface commune de gestion du moteur de workflow mappé sur les workflows BPM, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowBPMEngine {}

	[ModelElement("IWorkflowBPMN","interface d'accès aux informations et de gestion d'un workflow BPM, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowBPMN {}

	[ModelElement("Workflow.Interface",", ElementType = "ApplicationComponentArchimate")]
	partial class Workflow_Interface {}

	[ModelElement("Workflow","classes d'implémentation d'un workflow de pilotage des vues, ElementType = "ApplicationComponentArchimate")]
	partial class Workflow {}

	[ModelElement("Workflow.Desktop","classes d'implémentation de workflow spécifique aux ordinateurs non portable, ElementType = "ApplicationComponentArchimate")]
	partial class Workflow_Desktop {}

	[ModelElement("Workflow.BPMN.Bonita","classes d'implémentation pour la gestion de processus BPMN sur Bonita BPM, ElementType = "ApplicationComponentArchimate")]
	partial class Workflow_BPMN_Bonita {}

	[ModelElement("Interface workflow métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_workflow_métier {}

	[ModelElement("Workflow métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Workflow_métier {}

	[ModelElement("Application Component",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Component {}

	[ModelElement("Méthodes CWorkflowExample","traitement des enchaînements des services et vues métier, ElementType = "ApplicationFunctionArchimate")]
	partial class Méthodes_CWorkflowExample {}

	[ModelElement("CSynchronizedUnitOfWorkFct (EN COURS)","implémentation de la gestion unit of work synchronisé avec le serveur, ElementType = "ApplicationFunctionArchimate")]
	partial class CSynchronizedUnitOfWorkFct_EN_COURS {}

	[ModelElement("couche Service",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Service {}

	[ModelElement("IService",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IService {}

	[ModelElement("IServiceExample",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IServiceExample {}

	[ModelElement("IServiceCRUD",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IServiceCRUD {}

	[ModelElement("IServiceCRUDExample",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IServiceCRUDExample {}

	[ModelElement("ISpecification","interface de définition de règles de spécification, ElementType = "ApplicationInterfaceArchimate")]
	partial class ISpecification {}

	[ModelElement("IServiceReport","interface pour un service de génération de rapport, ElementType = "ApplicationInterfaceArchimate")]
	partial class IServiceReport {}

	[ModelElement("ITransformation","interface de gestion d'un service de transformation, ElementType = "ApplicationInterfaceArchimate")]
	partial class ITransformation {}

	[ModelElement("ILog","interface pour le service de gestion des logs, ElementType = "ApplicationInterfaceArchimate")]
	partial class ILog {}

	[ModelElement("IAutorisation","interface pour le service de gestion des autorisations, ElementType = "ApplicationInterfaceArchimate")]
	partial class IAutorisation {}

	[ModelElement("ILabel","interface pour le service de gestion des messages texte, ElementType = "ApplicationInterfaceArchimate")]
	partial class ILabel {}

	[ModelElement("INotification","interface pour le service de gestion des autorisations, ElementType = "ApplicationInterfaceArchimate")]
	partial class INotification {}

	[ModelElement("IResource","interface pour le service de gestion des ressources, ElementType = "ApplicationInterfaceArchimate")]
	partial class IResource {}

	[ModelElement("ISessionContext","interface pour le service de gestion du contexte de session, ElementType = "ApplicationInterfaceArchimate")]
	partial class ISessionContext {}

	[ModelElement("ITransaction",", ElementType = "ApplicationInterfaceArchimate")]
	partial class ITransaction {}

	[ModelElement("IStateMachine","interface pour le service de gestion d'une StateMachine, ElementType = "ApplicationInterfaceArchimate")]
	partial class IStateMachine {}

	[ModelElement("IUserContext","interface pour le service de gestion du contexte utilisateur, ElementType = "ApplicationInterfaceArchimate")]
	partial class IUserContext {}

	[ModelElement("IRuleEngine","interface d'accès au moteur de règles, ElementType = "ApplicationInterfaceArchimate")]
	partial class IRuleEngine {}

	[ModelElement("IMailSrv","interface pour le service d'envoi de mail, ElementType = "ApplicationInterfaceArchimate")]
	partial class IMailSrv {}

	[ModelElement("IHelpSrv","interface pour le service de gestion de l'aide, ElementType = "ApplicationInterfaceArchimate")]
	partial class IHelpSrv {}

	[ModelElement("IReportEngineSrv","interface pour le service de génération de rapport, ElementType = "ApplicationInterfaceArchimate")]
	partial class IReportEngineSrv {}

	[ModelElement("IJobSrv","interface pour le service d'exécution de job, ElementType = "ApplicationInterfaceArchimate")]
	partial class IJobSrv {}

	[ModelElement("IServiceLocatorSrv","interface pour le service d'annuaire de services, ElementType = "ApplicationInterfaceArchimate")]
	partial class IServiceLocatorSrv {}

	[ModelElement("ITransformEngineSrv","interface pour le service de transformation de données, ElementType = "ApplicationInterfaceArchimate")]
	partial class ITransformEngineSrv {}

	[ModelElement("IRuleEngineSrv","interface d'accès au service de gestion du moteur de règles, ElementType = "ApplicationInterfaceArchimate")]
	partial class IRuleEngineSrv {}

	[ModelElement("IWorkflowAdminSrv","interface pour le service d'administration des workflows, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowAdminSrv {}

	[ModelElement("Service.Interface","interfaces commune aux services, ElementType = "ApplicationComponentArchimate")]
	partial class Service_Interface {}

	[ModelElement("Service","élément d'impélmentation des services, ElementType = "ApplicationComponentArchimate")]
	partial class Service {}

	[ModelElement("Service.Infrastructure","implémentation de services techniques exposés dans la couche service et appelables à l'extérieur, ElementType = "ApplicationComponentArchimate")]
	partial class Service_Infrastructure {}

	[ModelElement("Service.Infrastructure.Interface","interface de services techniques exposés à la couche workflow ou à l'extérieur, ElementType = "ApplicationComponentArchimate")]
	partial class Service_Infrastructure_Interface {}

	[ModelElement("Service.Infrastructure.Windows","implémentation des services techniques sous windows, ElementType = "ApplicationComponentArchimate")]
	partial class Service_Infrastructure_Windows {}

	[ModelElement("Service.Infrastructure.Linux","implémentation des services techniques sous Unix, ElementType = "ApplicationComponentArchimate")]
	partial class Service_Infrastructure_Linux {}

	[ModelElement("Service.Infrastructure.Smartphone","implémentation des services techniques pour smartphone, ElementType = "ApplicationComponentArchimate")]
	partial class Service_Infrastructure_Smartphone {}

	[ModelElement("Service.Desktop",", ElementType = "ApplicationComponentArchimate")]
	partial class Service_Desktop {}

	[ModelElement("Interface Service métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_Service_métier {}

	[ModelElement("Service métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Service_métier {}

	[ModelElement("Méthodes CServiceExample","traitement des règles métier du service, ElementType = "ApplicationFunctionArchimate")]
	partial class Méthodes_CServiceExample {}

	[ModelElement("Méthodes CServiceCRUDExample",", ElementType = "ApplicationFunctionArchimate")]
	partial class Méthodes_CServiceCRUDExample {}

	[ModelElement("CServiceUnitOfWorkFct (EN COURS)","implémentation de la gestion des Unit of work couche service, ElementType = "ApplicationFunctionArchimate")]
	partial class CServiceUnitOfWorkFct_EN_COURS {}

	[ModelElement("CSubscriptionServiceFct",", ElementType = "ApplicationFunctionArchimate")]
	partial class CSubscriptionServiceFct {}

	[ModelElement("CSubscriptionServiceFctDesktop",", ElementType = "ApplicationFunctionArchimate")]
	partial class CSubscriptionServiceFctDesktop {}

	[ModelElement("CSubscriptionRemoteFct (EN COURS)","implémentation gestion publication-souscription en mode distribué, ElementType = "ApplicationFunctionArchimate")]
	partial class CSubscriptionRemoteFct_EN_COURS {}

	[ModelElement("IORM","interface d'accès aux fonctionnalités de la couche de persistance: - initialisation et terminaison - exécution de requêtes - opérations CUD - transactions, ElementType = "ApplicationInterfaceArchimate")]
	partial class IORM {}

	[ModelElement("IDAO","interface CRUD sur les entités métiers, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAO {}

	[ModelElement("ISession","interface d'accès aux objets de session, ElementType = "ApplicationInterfaceArchimate")]
	partial class ISession {}

	[ModelElement("IPersistenceTransformation","interface d'exécution de la persistance de la transformation (par exemple, persistance sur MongoDB), ElementType = "ApplicationInterfaceArchimate")]
	partial class IPersistenceTransformation {}

	[ModelElement("IDAODocumentText","interface de persistance CRUD d'un document type Word, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAODocumentText {}

	[ModelElement("IDAOSpreadsheet","interface de persistance CRUD d'un tableau type Excel, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOSpreadsheet {}

	[ModelElement("IDAOImage","interface CRUD de fichier de type image, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOImage {}

	[ModelElement("IDAOHelp","interface CRUD sur la persistance de l'aide, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOHelp {}

	[ModelElement("IDAOServiceLocator","interface CRUD sur la persistance de l'annuaire de service, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOServiceLocator {}

	[ModelElement("IDAOAutorisation","interface d'implémentation CRUD de la persistance des autorisations, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOAutorisation {}

	[ModelElement("IDAOText","interface d'implémentation CRUD de la persistance des messages, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOText {}

	[ModelElement("IDAOResource","interface d'implémentation CRUD de l'accès aux ressources du système, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOResource {}

	[ModelElement("IDAOConfiguration","interface d'implémentation CRUD de la persistance de la configuration, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOConfiguration {}

	[ModelElement("IDAOUserContext","interface d'implémentation CRUD de la persistance du contexte utilisateur, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOUserContext {}

	[ModelElement("IDAOSessionContext","interface d'implémentation CRUD de la persistance du contexte de session, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOSessionContext {}

	[ModelElement("IDAONotification","interface d'implémentation CRUD de la persistance des notifications, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAONotification {}

	[ModelElement("IDAOStateMachine","interface d'implémentation CRUD de la persistance d'une stateMachine, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOStateMachine {}

	[ModelElement("IDAOWorkflow","interface d'implémentation CRUD de la persistance d'un workflow, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOWorkflow {}

	[ModelElement("IDAOResourceWeb","interface d'implémentation CRUD de l'accès aux ressources web (accessible selon une URI), ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOResourceWeb {}

	[ModelElement("IDAOSchema","interface d'implémentation CRUD de la persistance du méta-modèle, ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOSchema {}

	[ModelElement("IDAOExample",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IDAOExample {}

	[ModelElement("Persistence.Interface","interface sur les fonctionnalités de persistance, ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Interface {}

	[ModelElement("Persistence","traitement commun de persistance, ElementType = "ApplicationComponentArchimate")]
	partial class Persistence {}

	[ModelElement("Persistence.Desktop.ORM.NHibernate","gestion de la persistance sur NHibernate, ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Desktop_ORM_NHibernate {}

	[ModelElement("Persistence.Windows","gestion de la persistance sur windows (par exemple, gestion de fichiers), ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Windows {}

	[ModelElement("Persistence.Lapstop","peristance en local sur un poste tel que SQLLite, ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Lapstop {}

	[ModelElement("Persistence.Linux","persistance sur Linux, par exemple la gestion de fichiers, ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Linux {}

	[ModelElement("Persistence.Windows.Store","gestion de la persistance sur windows spécifiquement pour les applications windows Store (par exemple, gestion de fichiers), ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Windows_Store {}

	[ModelElement("Persistence.Desktop.ORM",", ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Desktop_ORM {}

	[ModelElement("Persistence.Smartphone",", ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Smartphone {}

	[ModelElement("Persistence.Desktop","gestion de la persistance spécifique aux ordinateurs non portable, ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Desktop {}

	[ModelElement("Presentation.Smartphone.ORM",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Smartphone_ORM {}

	[ModelElement("Presentation.Smartphone.IOS",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Smartphone_IOS {}

	[ModelElement("Persistence.Infrastructure.Interface","interface sur les fonctionnalités de persistance de l'infrastructure, ElementType = "ApplicationComponentArchimate")]
	partial class Persistence_Infrastructure_Interface {}

	[ModelElement("Presentation.Smartphone.Android",", ElementType = "ApplicationComponentArchimate")]
	partial class Presentation_Smartphone_Android {}

	[ModelElement("Interface persistance métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_persistance_métier {}

	[ModelElement("Persistance métier",", ElementType = "ApplicationComponentArchimate")]
	partial class Persistance_métier {}

	[ModelElement("Methodes CDAOExample",", ElementType = "ApplicationFunctionArchimate")]
	partial class Methodes_CDAOExample {}

	[ModelElement("CADOPersistEngineFct (EN COURS)","implementation de l'accès au moteur de persistance basé sur ADO.NET portable, ElementType = "ApplicationFunctionArchimate")]
	partial class CADOPersistEngineFct_EN_COURS {}

	[ModelElement("CPersistentUnitOfWorkFct (EN COURS)","implémentation de la factory d'unit of work persistante, ElementType = "ApplicationFunctionArchimate")]
	partial class CPersistentUnitOfWorkFct_EN_COURS {}

	[ModelElement("CResourceFct (EN COURS)","implémentation de l'accès au ressources type fichier, ElementType = "ApplicationFunctionArchimate")]
	partial class CResourceFct_EN_COURS {}

	[ModelElement("CORMPersistEngineFct (EN COURS)","implémentation de l'accès à la persistance en s'appuyant sur un modèle d'objets métier, ElementType = "ApplicationFunctionArchimate")]
	partial class CORMPersistEngineFct_EN_COURS {}

	[ModelElement("CORMTransactionFct (EN COURS)","implémentation de la gestion de la transaction sur un ORM, ElementType = "ApplicationFunctionArchimate")]
	partial class CORMTransactionFct_EN_COURS {}

	[ModelElement("IPersistEngineFct","accès au moteur de persistance, ElementType = "ApplicationInterfaceArchimate")]
	partial class IPersistEngineFct {}

	[ModelElement("IResourceFct","gestion de l'utilisation des ressources type fichier, ElementType = "ApplicationInterfaceArchimate")]
	partial class IResourceFct {}

	[ModelElement("Common","classes communes à plusieurs couches (2 minimales) quelque soit la plateforme, ElementType = "ApplicationComponentArchimate")]
	partial class Common {}

	[ModelElement("Common.Desktop","classes communes à tout les composants fonctionnant sur le desktop: PC, Mac, Linux en mode client ou serveur classes communes spécifique à Spring.NET, comme les aspects, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Desktop {}

	[ModelElement("Common.Smartphone","classes commune à tout les smartphones les contraintes principales des smartphones concerne principalement l'impossibilité de construire dynamiquement le code, d'où l'utilisation de générateur de proxy avant compilation pour la gestion des aspects (via Fody par exemple) la solution Spring.NET est cependant à préconiser par rapport à Fody dans les autres cas car cette dernière solution est moins facilement débuggable, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Smartphone {}

	[ModelElement("Common.Desktop.Windows","classes communes à tout les composants fonctionnant sur le desktop Windows, par exemple - l'accès à la base de registre - l'interconnexion entre les classes communes et des classes pures windows comme WPF, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Desktop_Windows {}

	[ModelElement("Common.Laptop","classes communes à tout les composants fonctionnant sur un portable: PC, Mac, Linux en mode client ou serveur par exemple, des spécificités tel que l'utilisation du wifi regroupe également les composants locaux sur un poste client, comme les bases locales, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Laptop {}

	[ModelElement("Common.Tablet","classes communes à tout les composants fonctionnant sur une tablette: PC windows 8 ou plus, IOS, Android en mode client, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Tablet {}

	[ModelElement("Common.Smartphone.Android","classes communes à tout les composants fonctionnant sur un smartphone Android en mode client, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Smartphone_Android {}

	[ModelElement("Common.Smartphone.IOS","classes communes à tout les composants fonctionnant sur un smartphone IOS en mode client, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Smartphone_IOS {}

	[ModelElement("Common.Tablet.Android","classes communes à tout les composants fonctionnant sur une tablette: Android en mode client, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Tablet_Android {}

	[ModelElement("Common.Tablet.IOS","classes communes à tout les composants fonctionnant sur une tablette IOS en mode client, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Tablet_IOS {}

	[ModelElement("Common.Windows","classes communes à tout les composants fonctionnant sur Windows sur Desktop ou tablet ou smartphone, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Windows {}

	[ModelElement("Common.Windows.Store","classes communes à tout les composants fonctionnant sur Windows sur Desktop ou tablet ou smartphone avec les contraintes de l'AppStore, ElementType = "ApplicationComponentArchimate")]
	partial class Common_Windows_Store {}

	[ModelElement("Couche Commune",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Commune {}

	[ModelElement("Méthodes CStateMachine","gestion de l'enchainement des traitements pour les changements d'état en fonction de l'état de(s) entité(s) métier(s) associés, ElementType = "ApplicationFunctionArchimate")]
	partial class Méthodes_CStateMachine {}

	[ModelElement("CAssertionExtFct","implémentation des assertions évolué - comportement différentié en production et en test - trace dans un log, ElementType = "ApplicationFunctionArchimate")]
	partial class CAssertionExtFct {}

	[ModelElement("CAssertionFct","implémentation des assertions standard - comportement différentié en production et en test - trace dans un log - lancement d'une exception, ElementType = "ApplicationFunctionArchimate")]
	partial class CAssertionFct {}

	[ModelElement("CBindingFct","implémentation du binding entre 2 élements de même couche ou couche adjacente portable - binding entre propriété, méthode et objets - déclenchement du binding par évènement, ElementType = "ApplicationFunctionArchimate")]
	partial class CBindingFct {}

	[ModelElement("CClientObjectAccessFct","implémentation accès client à un objet distant portable - liste les point d'accès - obtention d'une référence sur l'objet - relâchement d'une instance d'objet - rafraîchissement de l'état d'un objet, ElementType = "ApplicationFunctionArchimate")]
	partial class CClientObjectAccessFct {}

	[ModelElement("CComponentFct","implémentation des composants portable: - gestion modèle en mémoire - pas de chargement/déchargement, ElementType = "ApplicationFunctionArchimate")]
	partial class CComponentFct {}

	[ModelElement("CConfigurationFct (EN COURS)","implémentation de la gestion de la configuration: - sauvegarde XML portable - définition de variable dynamique - traitement transactionnel de mise à jour des variables - notification des mises à jour selon la portée des variables, ElementType = "ApplicationFunctionArchimate")]
	partial class CConfigurationFct_EN_COURS {}

	[ModelElement("CContextFct","implémentation gestion du contexte portable: - initialisation d'un log par portée de contexte, ElementType = "ApplicationFunctionArchimate")]
	partial class CContextFct {}

	[ModelElement("CFunctionalDomainFct","implémentation de la gestion des domaines fonctionnels: - gestion du modèle - sauvegarde et accès à des données de contexte non typé, ElementType = "ApplicationFunctionArchimate")]
	partial class CFunctionalDomainFct {}

	[ModelElement("CIdentityFct (EN COURS)","implémentation de l'identité utilisateur - gestion du modèle, ElementType = "ApplicationFunctionArchimate")]
	partial class CIdentityFct_EN_COURS {}

	[ModelElement("CLogFct","implémentation de la gestion des logs portable - gestion du modèle - formatage des messages - activation/désactivation par programme, ElementType = "ApplicationFunctionArchimate")]
	partial class CLogFct {}

	[ModelElement("CObjectRegistryFct","implémention du registre des objets distribués - gestion du modèle, ElementType = "ApplicationFunctionArchimate")]
	partial class CObjectRegistryFct {}

	[ModelElement("CSubscriptionFct","implémentation gestion publication-souscription, ElementType = "ApplicationFunctionArchimate")]
	partial class CSubscriptionFct {}

	[ModelElement("CTaskFct","implémentation gestion des tâches parallèles - gestion de l'état par thread, ElementType = "ApplicationFunctionArchimate")]
	partial class CTaskFct {}

	[ModelElement("CTransactionFct (EN COURS)","implémentation gestion des traitements transactionnels portable - transaction sur état d'objet en mémoire, ElementType = "ApplicationFunctionArchimate")]
	partial class CTransactionFct_EN_COURS {}

	[ModelElement("CClientObjectAccessFctDesktop (EN COURS)","implémentation accès client à un objet distant pour PC desktop - gestion du modèle - demande de création d'un proxy sur l'objet distant - appel du service de dispatcher de message - obtention d'une référence sur l'objet - relâchement d'une instance d'objet - rafraîchissement de l'état d'un objet s'appuie sur WCF, ElementType = "ApplicationFunctionArchimate")]
	partial class CClientObjectAccessFctDesktop_EN_COURS {}

	[ModelElement("CComponentFctDesktop (EN COURS)","implémentation des composants portable: - connection des fonctionnalités entre composants, ElementType = "ApplicationFunctionArchimate")]
	partial class CComponentFctDesktop_EN_COURS {}

	[ModelElement("CConfigurationFctDesktop","implémentation de la gestion de la configuration version PC desktop: - intégration des options de la ligne de commande comme variable, ElementType = "ApplicationFunctionArchimate")]
	partial class CConfigurationFctDesktop {}

	[ModelElement("CIdentityFctDesktop (EN COURS)","implémentation de l'identité utilisateur sur PC desktop - récupération de l'identifiant courant selon le thread principal, ElementType = "ApplicationFunctionArchimate")]
	partial class CIdentityFctDesktop_EN_COURS {}

	[ModelElement("CObjectDispatcherFctDesktop (EN COURS)","implémentation du dispatcher de requêtes d'appel sur des objets distribués - gestion du modèle - gestion de collection d'objets avec accès concurrents - gestion des références sur les objets pour la désallocation, ElementType = "ApplicationFunctionArchimate")]
	partial class CObjectDispatcherFctDesktop_EN_COURS {}

	[ModelElement("CObjectProxyFctDesktop (EN COURS)","implémentation de la gestion des proxys d'objets - intégration de code d'interception - génération d'une classe à partir d'une interface principale, ElementType = "ApplicationFunctionArchimate")]
	partial class CObjectProxyFctDesktop_EN_COURS {}

	[ModelElement("CObjectRegistryFctDesktop","implémention du registre des objets distribués - gestion du modèle - définition du modèle dans des fichiers XML de configuration, ElementType = "ApplicationFunctionArchimate")]
	partial class CObjectRegistryFctDesktop {}

	[ModelElement("CSubscriptionFctDesktop","implémentation gestion publication-souscription pour PC desktop - configuration par fichier des publieurs et souscripteurs, ElementType = "ApplicationFunctionArchimate")]
	partial class CSubscriptionFctDesktop {}

	[ModelElement("CTransactionFctDesktop (EN COURS)","implémentation gestion des traitements transactionnels pour PC desktop - transaction sur état d'objet en mémoire, ElementType = "ApplicationFunctionArchimate")]
	partial class CTransactionFctDesktop_EN_COURS {}

	[ModelElement("CCommunicationFct","implémentation de la gestion des communications entre éléments/composants, ElementType = "ApplicationFunctionArchimate")]
	partial class CCommunicationFct {}

	[ModelElement("CPermissionFct","implémentation gestion permission d'accès à une fonctionnalité, ElementType = "ApplicationFunctionArchimate")]
	partial class CPermissionFct {}

	[ModelElement("CErrorHandlingFct","implémentation du traitement des exceptions et des code erreurs, ElementType = "ApplicationFunctionArchimate")]
	partial class CErrorHandlingFct {}

	[ModelElement("IAssertionFct","gestion des assertions: - déclenchement paramétrable d'un arrêt de l'application selon le mode d'exécution - trace de l'erreur, ElementType = "ApplicationInterfaceArchimate")]
	partial class IAssertionFct {}

	[ModelElement("IBindingFct","binding entre 2 élements de même couche ou couche adjacente - binding entre propriété, méthode et objets - déclenchement du binding par évènement, ElementType = "ApplicationInterfaceArchimate")]
	partial class IBindingFct {}

	[ModelElement("IClientObjectAccessFct","accès client à un objet distant: - liste les point d'accès - obtention d'une référence sur l'objet - relâchement d'une instance d'objet - rafraîchissement de l'état d'un objet, ElementType = "ApplicationInterfaceArchimate")]
	partial class IClientObjectAccessFct {}

	[ModelElement("IErrorHandlingFct","traitement des exceptions et des code erreurs - interception d'exception selon la plateforme - transformation d'exception en code erreur et vice-versa, ElementType = "ApplicationInterfaceArchimate")]
	partial class IErrorHandlingFct {}

	[ModelElement("IRegistryFct","registre d'objets distribués, ElementType = "ApplicationInterfaceArchimate")]
	partial class IRegistryFct {}

	[ModelElement("INotificationFct","gestion des envois de notifications, ElementType = "ApplicationInterfaceArchimate")]
	partial class INotificationFct {}

	[ModelElement("IComponentFct","gestion des composants: - enregistrement - chargement/déchargement - lancement, ElementType = "ApplicationInterfaceArchimate")]
	partial class IComponentFct {}

	[ModelElement("IContextFct","accès aux données de contexte, ElementType = "ApplicationInterfaceArchimate")]
	partial class IContextFct {}

	[ModelElement("IUnitOfWorkFct","gestion des unités de travail, ElementType = "ApplicationInterfaceArchimate")]
	partial class IUnitOfWorkFct {}

	[ModelElement("ILogFct","gestion des logs, ElementType = "ApplicationInterfaceArchimate")]
	partial class ILogFct {}

	[ModelElement("IFunctionalDomainFct","gestion des données des domaines fonctionnels - accès au modèle - sauvegarde et accès à des données de contexte non typé, ElementType = "ApplicationInterfaceArchimate")]
	partial class IFunctionalDomainFct {}

	[ModelElement("IIdentityFct","gestion de l'identité utilisateur, ElementType = "ApplicationInterfaceArchimate")]
	partial class IIdentityFct {}

	[ModelElement("IObjectRegistryFct","registre des objets distribués, ElementType = "ApplicationInterfaceArchimate")]
	partial class IObjectRegistryFct {}

	[ModelElement("ICommunicationFct","gestion des communications entre éléments/composants - gestion des piles de protocoles - information réseau sur le noeud cournat - obtention des informations de routage par défaut des éléments du noeud courant, ElementType = "ApplicationInterfaceArchimate")]
	partial class ICommunicationFct {}

	[ModelElement("ISubscriptionFct","gestion publication-souscription, ElementType = "ApplicationInterfaceArchimate")]
	partial class ISubscriptionFct {}

	[ModelElement("ITaskFct","gestion des tâches parallèles, ElementType = "ApplicationInterfaceArchimate")]
	partial class ITaskFct {}

	[ModelElement("ITransactionFct","gestion des traitements transactionnels, ElementType = "ApplicationInterfaceArchimate")]
	partial class ITransactionFct {}

	[ModelElement("IObjectProxyFct","gestion des proxys d'objets, ElementType = "ApplicationInterfaceArchimate")]
	partial class IObjectProxyFct {}

	[ModelElement("IObjectDispatcherFct","gestion du dispatching de requêtes sur un ensemble d'objets, ElementType = "ApplicationInterfaceArchimate")]
	partial class IObjectDispatcherFct {}

	[ModelElement("IUserTreatmentFct","gestion des requêtes utilisateur, ElementType = "ApplicationInterfaceArchimate")]
	partial class IUserTreatmentFct {}

	[ModelElement("IPermissionFct","gestion permission d'accès à une fonctionnalité, ElementType = "ApplicationInterfaceArchimate")]
	partial class IPermissionFct {}

	[ModelElement("CProtocolREST","implémentation de la communication en mode REST, ElementType = "ApplicationFunctionArchimate")]
	partial class CProtocolREST {}

	[ModelElement("CProtocolStack","implémentation d'une pile de protocoles - pilotage des protocoles sousjascents - traitement des évènements de communication: fermeture, erreur... - initialisation, ouverture et fermeture de session - lecture et écriture de données depuis le client ou le serveur - test d'état, ElementType = "ApplicationFunctionArchimate")]
	partial class CProtocolStack {}

	[ModelElement("CProtocolWCF","implémentation de la communication via WCF, ElementType = "ApplicationFunctionArchimate")]
	partial class CProtocolWCF {}

	[ModelElement("ILayer",", ElementType = "ApplicationInterfaceArchimate")]
	partial class ILayer {}

	[ModelElement("Application","bootstrap d'application client, ElementType = "ApplicationComponentArchimate")]
	partial class Application {}

	[ModelElement("Application.Web","bootstrap d'application spécifique pour le web, ElementType = "ApplicationComponentArchimate")]
	partial class Application_Web {}

	[ModelElement("Application.Linux","bootstrap d'application spécifique pour Linux, ElementType = "ApplicationComponentArchimate")]
	partial class Application_Linux {}

	[ModelElement("Application.Mac","bootstrap d'application spécifique pour Linux, ElementType = "ApplicationComponentArchimate")]
	partial class Application_Mac {}

	[ModelElement("Application.Smartphone",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Smartphone {}

	[ModelElement("Application.Smartphone.IOS",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Smartphone_IOS {}

	[ModelElement("Application.Smartphone.Android",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Smartphone_Android {}

	[ModelElement("Application.Tablet",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Tablet {}

	[ModelElement("Application.Windows",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Windows {}

	[ModelElement("Application.Web.SmartClient","bootstrap d'application spécifique pour le web en application smart (javascript d'initialisation de l'application), ElementType = "ApplicationComponentArchimate")]
	partial class Application_Web_SmartClient {}

	[ModelElement("Application.Tablet.Android",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Tablet_Android {}

	[ModelElement("Application.Tablet.IOS",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Tablet_IOS {}

	[ModelElement("Application.Tablet.Windows",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Tablet_Windows {}

	[ModelElement("Application.Desktop",", ElementType = "ApplicationComponentArchimate")]
	partial class Application_Desktop {}

	[ModelElement("Component","classes communes client et serveur, ElementType = "ApplicationComponentArchimate")]
	partial class Component {}

	[ModelElement("Tool","classes spécifique à un tool externe, ElementType = "ApplicationComponentArchimate")]
	partial class Tool {}

	[ModelElement("IDeploymentFct",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IDeploymentFct {}

	[ModelElement("Server","classes communes à tout les containers serveurs, ElementType = "ApplicationComponentArchimate")]
	partial class Server {}

	[ModelElement("Server.Linux",", ElementType = "ApplicationComponentArchimate")]
	partial class Server_Linux {}

	[ModelElement("Server.Windows",", ElementType = "ApplicationComponentArchimate")]
	partial class Server_Windows {}

	[ModelElement("Server.Mac",", ElementType = "ApplicationComponentArchimate")]
	partial class Server_Mac {}

	[ModelElement("Server.Web",", ElementType = "ApplicationComponentArchimate")]
	partial class Server_Web {}

	[ModelElement("Server.Web.Linux",", ElementType = "ApplicationComponentArchimate")]
	partial class Server_Web_Linux {}

	[ModelElement("Server.Web.Windows",", ElementType = "ApplicationComponentArchimate")]
	partial class Server_Web_Windows {}

	[ModelElement("CSubscriptionServerFct (EN COURS)","implémentation de la gestion de la publication-souscription sur le serveur, ElementType = "ApplicationFunctionArchimate")]
	partial class CSubscriptionServerFct_EN_COURS {}

	[ModelElement("CServerUserTreatmentFct (EN COURS)","implémentation de la gestion de la requête utilisateur coté serveur - gestion du modèle, ElementType = "ApplicationFunctionArchimate")]
	partial class CServerUserTreatmentFct_EN_COURS {}

	[ModelElement("CFunctionalityConfigurationFct","gestion des variables de configuration portable, ElementType = "ApplicationFunctionArchimate")]
	partial class CFunctionalityConfigurationFct {}

	[ModelElement("CDeploymentArchitectureFct","déploiement des assemblies d'architecture - téléchargement du fichier de manifest selon la plateforme local - téléchargement de tout les fichiers associés, ElementType = "ApplicationFunctionArchimate")]
	partial class CDeploymentArchitectureFct {}

	[ModelElement("IConfigurationFct","gestion de la configuration par variable: - création et accès à une variable associé à une portée - attachement à une variable d'un objet autres - sauvegarde des variables avec impact selon la portée des variables, ElementType = "ApplicationInterfaceArchimate")]
	partial class IConfigurationFct {}

	[ModelElement("IDeploymentArchitectureFct",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IDeploymentArchitectureFct {}

	[ModelElement("bootstrap.Common","bootstrap commun à toutes les plateformes - structure d'une fonctionnalité - interface de couches - log minimal - exceptions communes, ElementType = "ApplicationComponentArchimate")]
	partial class Bootstrap_Common {}

	[ModelElement("bootstrap.Application.Desktop",", ElementType = "ApplicationComponentArchimate")]
	partial class Bootstrap_Application_Desktop {}

	[ModelElement("bootstrap.Application",", ElementType = "ApplicationComponentArchimate")]
	partial class Bootstrap_Application {}

	[ModelElement("Interfaces Vues Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Interfaces_Vues_Hapicare {}

	[ModelElement("IVues Hapicare",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IVues_Hapicare {}

	[ModelElement("Vues Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Vues_Hapicare {}

	[ModelElement("Interfaces workflows Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Interfaces_workflows_Hapicare {}

	[ModelElement("IWorkflows Hapicare",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflows_Hapicare {}

	[ModelElement("Workflows Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Workflows_Hapicare {}

	[ModelElement("Interfaces Services Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Interfaces_Services_Hapicare {}

	[ModelElement("IServices Hapicare",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IServices_Hapicare {}

	[ModelElement("Services Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Services_Hapicare {}

	[ModelElement("Interfaces ADO",", ElementType = "ApplicationComponentArchimate")]
	partial class Interfaces_ADO {}

	[ModelElement("IADO Hapicare",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IADO_Hapicare {}

	[ModelElement("ADO Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class ADO_Hapicare {}

	[ModelElement("Entités Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Entités_Hapicare {}

	[ModelElement("Commun Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Commun_Hapicare {}

	[ModelElement("bootstrap Hapicare",", ElementType = "ApplicationComponentArchimate")]
	partial class Bootstrap_Hapicare {}

	[ModelElement("Couche Domaine",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Domaine {}

	[ModelElement("Couche Persistance",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Persistance {}

	[ModelElement("Couche Persistance NHibernate",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Persistance_NHibernate {}

	[ModelElement("Interface couche Persistance",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_couche_Persistance {}

	[ModelElement("IADO",", ElementType = "ApplicationInterfaceArchimate")]
	partial class IADO {}

	[ModelElement("Interface couche Service",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_couche_Service {}

	[ModelElement("couche Workflow",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Workflow {}

	[ModelElement("Interface couche Workflow",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_couche_Workflow {}

	[ModelElement("couche Android",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Android {}

	[ModelElement("couche Présentation","composant de classes de présentation commun à toutes les technologies, ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Présentation {}

	[ModelElement("couche Web",", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_Web {}

	[ModelElement("couche WPF","composant de classes présentation spécifique à WPF, ElementType = "ApplicationComponentArchimate")]
	partial class Couche_WPF {}

	[ModelElement("Interface couche Vue",", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_couche_Vue {}

	[ModelElement("Workflow.External","classes d'implémentation d'accès à un workflow externe, par exemple intégré à BPMN, ElementType = "ApplicationComponentArchimate")]
	partial class Workflow_External {}

	[ModelElement("IWorkflowDiffContent","interface d'accès au workflow de gestion des différences, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowDiffContent {}

	[ModelElement("IWorkflowDocumentEdition","interface d'accès au workflow de gestion des documents, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowDocumentEdition {}

	[ModelElement("IWorkflowFileAccess","interface d'accès au workflow de gestion de l'accès aux fichiers, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowFileAccess {}

	[ModelElement("IWorkflowLog","interface d'accès au workflow de gestion des accès aux logs, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowLog {}

	[ModelElement("IWorkflowTextEdition","interface d'accès au workflow de gestion de l'édition des textes, ElementType = "ApplicationInterfaceArchimate")]
	partial class IWorkflowTextEdition {}

	[ModelElement("com.archimatetool.hammer","plug-in Archi de gestion des validateurs étendus, ElementType = "ApplicationComponentArchimate")]
	partial class Com_archimatetool_hammer {}

	[ModelElement("org.maidis.foldertools","plug-in Archi de gestion d'échange de données entre dossier du modèle, ElementType = "ApplicationComponentArchimate")]
	partial class Org_maidis_foldertools {}

	[ModelElement("org.maidis.modelrefactor","plug-in Archi de gestion du refactoring du modèle, ElementType = "ApplicationComponentArchimate")]
	partial class Org_maidis_modelrefactor {}

	[ModelElement("com.archimatetool.jasperreports","plug-in Archi de génération de rapports Jasper étendu, ElementType = "ApplicationComponentArchimate")]
	partial class Com_archimatetool_jasperreports {}

	[ModelElement("org.maidis.traceabilityMatrix",", ElementType = "ApplicationComponentArchimate")]
	partial class Org_maidis_traceabilityMatrix {}

	[ModelElement("org.maidis.modeltools",", ElementType = "ApplicationComponentArchimate")]
	partial class Org_maidis_modeltools {}

	[ModelElement("org.maidis.selectionsaver",", ElementType = "ApplicationComponentArchimate")]
	partial class Org_maidis_selectionsaver {}

	[ModelElement("org.maidis.trackedChanges",", ElementType = "ApplicationComponentArchimate")]
	partial class Org_maidis_trackedChanges {}

	[ModelElement("Tool 1","composant déployable associé à une fonction métier un tool peut être intégré à plusieurs applications un tool peut utiliser plusieurs serveurs dans des données fonctionnels différents, ElementType = "ApplicationComponentArchimate")]
	partial class Tool_1 {}

	[ModelElement("Tool 2","composant déployable associé à une fonction métier un tool peut être intégré à plusieurs applications un tool peut utiliser plusieurs serveurs dans des données fonctionnels différents, ElementType = "ApplicationComponentArchimate")]
	partial class Tool_2 {}

	[ModelElement("Tool 3","composant déployable associé à une fonction métier un tool peut être intégré à plusieurs applications un tool peut utiliser plusieurs serveurs dans des données fonctionnels différents, ElementType = "ApplicationComponentArchimate")]
	partial class Tool_3 {}

	[ModelElement("Tool 4","composant déployable associé à une fonction métier un tool peut être intégré à plusieurs applications un tool peut utiliser plusieurs serveurs dans des données fonctionnels différents, ElementType = "ApplicationComponentArchimate")]
	partial class Tool_4 {}

	[ModelElement("Serveur 1","composant logiciel intégrant les services métiers associés à un domaine fonctionnel un serveur est associé à un seul domaine fonctionnel, ElementType = "ApplicationComponentArchimate")]
	partial class Serveur_1 {}

	[ModelElement("Serveur 2","composant logiciel intégrant les services métiers associés à un domaine fonctionnel un serveur est associé à un seul domaine fonctionnel, ElementType = "ApplicationComponentArchimate")]
	partial class Serveur_2 {}

	[ModelElement("Composant 1","plus petit composant de code déployable et autonome exemple: la couche présentation du tool de gestion du dossier patient un composant est associé à un domaine fonctionnel, ElementType = "ApplicationComponentArchimate")]
	partial class Composant_1 {}

	[ModelElement("Composant 2","plus petit composant de code déployable et autonome exemple: la couche workflow du tool de gestion du dossier patient un composant est associé à un domaine fonctionnel, ElementType = "ApplicationComponentArchimate")]
	partial class Composant_2 {}

	[ModelElement("Composant 3","plus petit composant de code déployable et autonome exemple: la couche présentation du tool de gestion de l'accueil patient un composant est associé à un domaine fonctionnel, ElementType = "ApplicationComponentArchimate")]
	partial class Composant_3 {}

	[ModelElement("Composant 4","plus petit composant de code déployable et autonome exemple: la couche persistance du serveur du dossier patient un composant est associé à un domaine fonctionnel, ElementType = "ApplicationComponentArchimate")]
	partial class Composant_4 {}

	[ModelElement("Composant 5","plus petit composant de code déployable et autonome exemple: la couche service du serveur d'informations radiologique un composant est associé à un domaine fonctionnel, ElementType = "ApplicationComponentArchimate")]
	partial class Composant_5 {}

	[ModelElement("Service 1","service métier apporté à l'utilisateur exemple: création du dossier patient un service métier est associé à un domaine fonctionnel, ElementType = "ApplicationServiceArchimate")]
	partial class Service_1 {}

	[ModelElement("Service 2","service métier apporté à l'utilisateur exemple: recherche de patients multicritère un service métier est associé à un domaine fonctionnel, ElementType = "ApplicationServiceArchimate")]
	partial class Service_2 {}

	[ModelElement("Intégrer des aspects","permettre l'intégration d'aspects selon le modèle de la programmations orientée aspect (AOP: https://fr.wikipedia.org/wiki/Programmation_orient%C3%A9e_aspect ) permettant l'ajout de traitements transverses configurable dynamiquement sans recompilation, ElementType = "ApplicationServiceArchimate")]
	partial class Intégrer_des_aspects {}

	[ModelElement("Gérer les assertions","permettre le contrôle de la validité des paramètres d'appel de méthode de manière configurable Le contrôle doit pouvoir être débrayable, en particulier lors de la mise en production, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_assertions {}

	[ModelElement("Générer un audit","générer des informations de traçabilité d'exécution tel que l'utilisateur appelant, le temps d'exécution, les erreurs générées... doit être configurable et débrayable le flux d'audit doit être configurable: fichier, base de données..., ElementType = "ApplicationServiceArchimate")]
	partial class Générer_un_audit {}

	[ModelElement("Autoriser des objets","permettre le contrôle d'accès aux objets selon l'utilisateur de l'objet doit être dynamiquement configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Autoriser_des_objets {}

	[ModelElement("Gérer le binding","permettre la synchronisation d'état entre plusieurs objets connectables le binding se fait entre objets de même couche ou de couche adjacente, car la création du binding nécessite la connaissance complète des objets entre eux les objets bindés peuvent être des instances de classes, des objet élémentaires ou même des méthodes avec des objets, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_binding {}

	[ModelElement("Gérer les gros objets","permettre de gérer le cycle de vie d'objets de grosse taille les spécificités à prévoir pour les gros objets concernent la gestion de la mémoire, le transfert sur le réseau, la persistance, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_gros_objets {}

	[ModelElement("Certifier les données","Pouvoir valider la certification des données gère aussi bien la génération de données de certification que la vérification de la validité d'une donnée certifiée, ElementType = "ApplicationServiceArchimate")]
	partial class Certifier_les_données {}

	[ModelElement("Accéder à des objets distants","permettre d'utiliser de manière transparente un objet distant s'appui sur modèle Corba en ce qui concerne la manipulation des objets via une interface sur un objet distant ( https://fr.wikipedia.org/wiki/Common_Object_Request_Broker_Architecture ) gère la recherche d'objet selon sa clé, le transfert d'état, l'activation de méthode, la création et la destruction de l'objet selon son utilisation partagée, ElementType = "ApplicationServiceArchimate")]
	partial class Accéder_à_des_objets_distants {}

	[ModelElement("Gérer une horloge","permettre la gestion synchronisée du temps dans l'architecture donne des informations de temps (heure) qui soit exact et égale pour tout les composants en cours d'exécution, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_une_horloge {}

	[ModelElement("Gérer les informations de communication","offrir un accès à toutes les informations sur les éléments du réseau utilisable: adresse, nom, informations sur la machine courante, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_informations_de_communication {}

	[ModelElement("Gérer les composants applicatifs","permettre la gestion du cycle de vie des composants applicatifs: initialisation, enregistrement, chargement, déchargement, obtention d'information un composant applicatif regroupe un ou plusieurs composant(s) technique(s) pouvant faire partir d'un ou plusieurs produits un tool est un exemple de composant applicatif qui s'exécute sur le poste client, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_composants_applicatifs {}

	[ModelElement("Gérer la compression des données","permettre la compression et la décompression des données selon plusieurs algorithmes configurables, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_compression_des_données {}

	[ModelElement("Gérer le contexte en cours","offrir un accès aux données de contexte d'exécution en cours: requête en cours, application en cours, données de session utilisateur permettre le partage d'information au niveau global de l'application, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_contexte_en_cours {}

	[ModelElement("Convertir des données","permettre la conversion de données d'une unité à l'autre, de manière configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Convertir_des_données {}

	[ModelElement("Gérer les informations dynamiques","permettre d'attacher des données de toute type à tout objet, de manière configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_informations_dynamiques {}

	[ModelElement("Normaliser le traitement des exceptions","permettre de traiter de manière uniforme les exceptions, de façon configurable intégrer tout les traitements de traçabilité lors de l'interception d'une exception: log automatique, transformation de l'exception, récupération des informations de pile d'appel, arrêt propre de l'application, ElementType = "ApplicationServiceArchimate")]
	partial class Normaliser_le_traitement_des_exceptions {}

	[ModelElement("Gérer le formatage de données","permettre la transformation d'une données en fonction d'un format configurable doit intégrer la réversibilité de la transformation, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_formatage_de_données {}

	[ModelElement("Gérer les domaines métier","gérer la structuration du modèle métier en terme de domaines et sous-domaines, application permettre l'association de données contextuelles à chacun de ses éléments, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_domaines_métier {}

	[ModelElement("Gérer l'aide","permettre d'attacher des informations d'aide compréhensible par l'utilisateur à tout éléments applicatifs, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_laide {}

	[ModelElement("Gérer les identifiants","gérer la génération d'identifiant unique paramétrable la génération doit pouvoir dépendre d'un contexte spécifié, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_identifiants {}

	[ModelElement("Gérer l'identité","gère les informations d'identification d'un acteur, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_lidentité {}

	[ModelElement("Gérer l'intéropérabilité (A MODIFIER LIBELLE)","gère l'exécution de traitement en dehors de l'environnement de la plateforme doit permettre l'exécution selon différents protocoles configurables, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_lintéropérabilité_A_MODIFIER_LIBELLE {}

	[ModelElement("Suivre le cycle de vie","permettre de suivre le cycle de vie de n'importe quel objet de couche, ElementType = "ApplicationServiceArchimate")]
	partial class Suivre_le_cycle_de_vie {}

	[ModelElement("Gérer la localisation des textes","permettre la tradution d'un texte d'une langue à l'autre de manière configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_localisation_des_textes {}

	[ModelElement("Gérer les locks","gérer l'utilisation d'un verrou partagé, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_locks {}

	[ModelElement("Gérer les logs","permettre la création de logs de manière configurable l'activation automatique des logs selon différents évènements ne fait pas partie de ce service, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_logs {}

	[ModelElement("Gérer les notifications","permettre la création de notifications associées à un ou des objets la notification utilise la publication-souscription pour envoyer des informations à tout les clients utilisant les objets, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_notifications {}

	[ModelElement("Gérer le dispatching entre objets","permettre la sélection d'un objet dans une collection d'objets à fournir à un client gère le cycle d'objet des objets gérées en fonction des références client (gestion d'un compteur de référence), ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_dispatching_entre_objets {}

	[ModelElement("Générer des proxys d'accès","permettre la création d'un proxy d'accès à un objet en fonction de son interface le traitement de redirection doit pouvoir être configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Générer_des_proxys_daccès {}

	[ModelElement("Gérer un registre d'objets","permettre de stocker les identifiants des objets en vue de pouvoir les retrouver ultérieurement, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_un_registre_dobjets {}

	[ModelElement("Gérer les permissions d'exécution","permettre de contrôler l'exécution d'un traitement en fonction de l'environnement d'exécution de l'appelant la gestion des permissions s'entend dans le sens .NET et ne prend pas en compte l'identifiant de l'appelant (utilisateur) un exemple de permission: - l'utilisation d'un service ne peut se faire depuis la couche présentation - la couche service ne peut pas accéder à un fichier exemples d'implémentation: http://www.c-sharpcorner.com/uploadfile/puranindia/custom-code-access-permissions/ https://marcelwouters.wordpress.com/2011/05/23/wpf-command-and-claimrole-based-security/, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_permissions_dexécution {}

	[ModelElement("Gérer la sérialisation","gérer la transformation d'un objet mémoire en un flux de données exploitable en dehors du processus en cours, et ce de manière réversible (intègre la désérialisation), ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_sérialisation {}

	[ModelElement("Gérer l'accès à une ressource partagée","obtenir un accès référencé à une ressource partagée dont le cycle de vie doit être déterministe gère le cycle de vie de la ressource en fonction des partages en cours par exemple, l'accès à une ressource de type fichier doit fermer le fichier lorsque celui-ci n'est plus utilisé, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_laccès_à_une_ressource_partagée {}

	[ModelElement("Gérer les flux","gère le cycle de vie de flux de données, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_flux {}

	[ModelElement("Gérer la souscription/publication","permettre de gérer l'échange de données entre objets selon le modèle de publication/souscription cette fonctionnalité doit être utilisée pour la communication entre objets qui ne se connaissent pas (par exemple, entre 2 couches non adjacentes, ou entre 2 composants applicatifs), ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_souscriptionpublication {}

	[ModelElement("Gérer les tâches","gérer l'exécution de tâches en parallèle de la tâche principale du processus l'exécution en mode multithread ou sous forme de co-routine est un choix d'implémentation, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_tâches {}

	[ModelElement("Gérer les transactions","permettre la validation ou l'invalidation d'un ensemble de traitements regroupés sous une même transaction, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_transactions {}

	[ModelElement("Gérer les unités de travail","gérer la synchronisation de l'état d'un ensemble d'objets par rapport à un référentiel ce référentiel peut être soit un espace de persistance (fichier, tables) soit une autre unité de travail correspond en gros au concept de session, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_unités_de_travail {}

	[ModelElement("Gérer la requête utilisateur (A FUSIONNER AVEC CONTEXTE?)","gérer les données associées à une opération déclenchée par un utilisateur, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_requête_utilisateur_A_FUSIONNER_AVEC_CONTEXTE {}

	[ModelElement("Gérer la validation de données","déclencher le traitement de validation d'un ensemble d'objets au bon moment, par exemple lors de passage entre les couches, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_validation_de_données {}

	[ModelElement("Autoriser des fonctions","permettre le contrôle d'accès aux fonction selon l'utilisateur doit être dynamiquement configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Autoriser_des_fonctions {}

	[ModelElement("Créer des instances d'objets configurables","permettre la création d'une instance d'objet dont l'état est configurable de manière externe, par exemple au travers d'une fichier. La création d'une instance d'objets doit pouvoir impliquer la création de plusieurs objets connectés à cette instance selon la configuration., ElementType = "ApplicationServiceArchimate")]
	partial class Créer_des_instances_dobjets_configurables {}

	[ModelElement("Gérer les archives de données","gérer la création et l'accès aux archives de données, container regroupant un ensemble d'objets persistants (fichiers, tables...), ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_archives_de_données {}

	[ModelElement("Gérer la migration des données","gérer la transformation des données peristante d'une version à une autre, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_migration_des_données {}

	[ModelElement("Gérer le schéma de données (A METTRE DANS INTERFACE PERSISTANCE?)","gérer la structure des données persistantes tel que tables SGBD, schéma SGBD, tablespace..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_schéma_de_données_A_METTRE_DANS_INTERFACE_PERSISTANCE {}

	[ModelElement("Gérer les caches de données","gérer le stockage en mémoire d'objets normalement à lire dans le container de persistance, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_caches_de_données {}

	[ModelElement("Gérer le système de fichiers (A METTRE DANS COUCHE PERSISTANCE?)","gérer l'accès aux fichiers, répertoires et disques, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_système_de_fichiers_A_METTRE_DANS_COUCHE_PERSISTANCE {}

	[ModelElement("Gestion des systèmes de persistance","gérer la persistance des données dans des containers de persistance, selon plusieurs modèles d'accès (ORM, SQL) et plusieurs containers (SQL Server, Oracle) configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_des_systèmes_de_persistance {}

	[ModelElement("Produire des graphiques","permettre la représentation des données numériques sous la forme de graphiques, ElementType = "ApplicationServiceArchimate")]
	partial class Produire_des_graphiques {}

	[ModelElement("Afficher en mode console","gérer l'affichage de données en mode texte, ElementType = "ApplicationServiceArchimate")]
	partial class Afficher_en_mode_console {}

	[ModelElement("Gérer l'accès aux périphériques","gérer l'accès et le pilotage de périphériques connectés aux postes de travail l'ajout de périphériques doit suivre le principe des plugins et doit être configurable, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_laccès_aux_périphériques {}

	[ModelElement("Gérer le drag and drop","gère le transfert d'information piloté par l'utilisateur entre 2 composants graphiques gère la conversion entre technologie différentiée, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_drag_and_drop {}

	[ModelElement("Gérer les périphériques d'entrée","gére la récupération des informations depuis les périphériques d'entrée tel que clavier, souris, touch..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_périphériques_dentrée {}

	[ModelElement("Gérer la reconnaissance","gérer la récupération et l'analyse des données provenant d'une source de capture d'image tel qu'une caméra, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_reconnaissance {}

	[ModelElement("Gérer le rendu d'affichage","gérer l'affichage de bas-niveau tel que tracé de points, droites, couleurs, etc... selon la plateforme d'exécution, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_rendu_daffichage {}

	[ModelElement("Gérer l'affichage de contrôles","gère l'affichage de composants graphiques construits tel que les contrôles graphiques, les vues, les boites de dialogues, selon la technologie, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_laffichage_de_contrôles {}

	[ModelElement("Gérer les écrans","gérer les informations associées aux écrans d'affichage: résolution, double écran, temps de réaction..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_écrans {}

	[ModelElement("Gérer les sons","gérer la capture et la restitution des sons, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_sons {}

	[ModelElement("Gérer les modèles de vues","gérer les documents associés à des vues comme par exemple une page HTML, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_modèles_de_vues {}

	[ModelElement("Gérer le contrôleur d'échange","gère la création et le pilotage du contrôleur entre la vue et le modèle de données en fonction de la technologie employé et du modèle d'échange choisi (MVC, MVVM, VueModel...), ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_contrôleur_déchange {}

	[ModelElement("Gérer le déploiement","gérer le déploiement de composants sur le poste client effectue le contrôle de l'existant et récupère les composants nécessaire selon l'offre de produits, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_déploiement {}

	[ModelElement("Gérer la configuration d'exécution","Permettre la récupération des informations de paramétrage de la plateforme non associées à un objet métier, en particulier les informations pour le déploiement et l'exécution de la plateforme les informations de configuration utilisent leur propre mécanisme de persistance non partagé avec le reste de l'application la configuration peut également provenir de plusieurs sources simultanées tels que les paramètres de la ligne de commande, la base de registre, le fichier config applicatif..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_configuration_dexécution {}

	[ModelElement("Gérer le déploiement de la plateforme","permettre le déploiement des composants minimales de l'architecture, en dehors des composants métiers spécifiques, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_déploiement_de_la_plateforme {}

	[ModelElement("Gérer le container serveur","gérer le cycle de vie du serveur et les intéractions externes tel que la connection et la réception de données depuis le réseau, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_container_serveur {}

	[ModelElement("Gérer le container de services","gérer le cycle de vie des services et leur déclenchement à partir des informations transmis par le container serveur, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_container_de_services {}

	[ModelElement("Générer des code-barres","à partir d'informations alphanumériques, générer un code barre selon différents formats configurables, ElementType = "ApplicationServiceArchimate")]
	partial class Générer_des_codebarres {}

	[ModelElement("Gérer le pilotage d'un workflow BPMN","gérer le cycle de vie des éléments d'un workflow métier de type BPMN, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_le_pilotage_dun_workflow_BPMN {}

	[ModelElement("Gérer les clients","gérer les informations associés à un client au sens commercial: licences, autorisations..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_clients {}

	[ModelElement("Compiler du code","permettre la compilation de code dans différents langages en vue de leur intégration dans la plateforme, ElementType = "ApplicationServiceArchimate")]
	partial class Compiler_du_code {}

	[ModelElement("Gérer des documents (A METTRE DANS COUCHE INTERFACE SERVICE?)","gérer des documents de transformation et de mise en forme de données dans différents formats configurables, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_des_documents_A_METTRE_DANS_COUCHE_INTERFACE_SERVICE {}

	[ModelElement("transférer des fichiers (A FUSIONNER AVEC GESTION FICHIERS?)","transférer des fichiers d'un noeud physique à un autre, ElementType = "ApplicationServiceArchimate")]
	partial class Transférer_des_fichiers_A_FUSIONNER_AVEC_GESTION_FICHIERS {}

	[ModelElement("Gérer les données géographiques","gérer les données de localisation tels que données GPS, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_données_géographiques {}

	[ModelElement("Gérer les graphes (A RENOMMER EN GESTION COLLECTION?)","gérer l'utilisation de donner sous forme de graphe, avec utilisation d'algorithmes spécifiques tels algo de plus court chemin..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_graphes_A_RENOMMER_EN_GESTION_COLLECTION {}

	[ModelElement("Gérer les images","gérer la construction et la manipulation d'images selon différents formats configurables, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_images {}

	[ModelElement("Interpréter du code","gérer l'interprétation de code de script dans différents langages, ElementType = "ApplicationServiceArchimate")]
	partial class Interpréter_du_code {}

	[ModelElement("Exécution un travail","exécuter un service métier comme un travail (job) au niveau du système d'exploitation avec informations de suivi d'exécution, ElementType = "ApplicationServiceArchimate")]
	partial class Exécution_un_travail {}

	[ModelElement("Gérer les licences","gérer le suivi des licences par client et par produits, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_licences {}

	[ModelElement("Gérer la langue","implémenter des traitements de la langue selon la localisation: phonétisation, correction automatique, style et grammaire, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_la_langue {}

	[ModelElement("Transférer les mails","gérer la réception et l'envoi de mails, ElementType = "ApplicationServiceArchimate")]
	partial class Transférer_les_mails {}

	[ModelElement("Envoyer des messages instantanées","gérer l'envoi de messages entre utilisateurs, ElementType = "ApplicationServiceArchimate")]
	partial class Envoyer_des_messages_instantanées {}

	[ModelElement("Gérer les méta-datas (A METTRE DANS COUCHE COMMUNE OU INTERFACE SERVICE?)","gérer les méta-datas associés aux données, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_métadatas_A_METTRE_DANS_COUCHE_COMMUNE_OU_INTERFACE_SERVICE {}

	[ModelElement("Accéder au métamodèle (A METTRE DANS COUCHE COMMUNE OU INTERFACE SERVICE?)","permettre la récupération des informations du métamodèle applicatif, ElementType = "ApplicationServiceArchimate")]
	partial class Accéder_au_métamodèle_A_METTRE_DANS_COUCHE_COMMUNE_OU_INTERFACE_SERVICE {}

	[ModelElement("Gérer les partenaires","gérer les données et l'accès aux partenaires externes tel que Vidal..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_partenaires {}

	[ModelElement("Gérer les imprimantes","gérer l'accès et la configuration des imprimantes, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_imprimantes {}

	[ModelElement("Gérer les achats","gérer les achats de licence depuis l'application: information sur le prix, paiement sécurisé, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_achats {}

	[ModelElement("Générer des rapports (A FUSIONNER AVEC DOCUMENT?)","générer des rapports à partir des données métier en vue de leur envoi vers l'imprimante un rapport est similaire à un document mais gère plus spécifiquement des listes répétitives de données, ElementType = "ApplicationServiceArchimate")]
	partial class Générer_des_rapports_A_FUSIONNER_AVEC_DOCUMENT {}

	[ModelElement("Gérer des règles métier","gérer l'ajout et la résolution dynamique de règles métier dans une approche moteur de règles, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_des_règles_métier {}

	[ModelElement("Gérer des tables de calculs (A FUSIONNER AVEC DOCUMENT?)","gérer les données sous forme de tableaux avec opérations de calculs associées, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_des_tables_de_calculs_A_FUSIONNER_AVEC_DOCUMENT {}

	[ModelElement("Application Service",", ElementType = "ApplicationServiceArchimate")]
	partial class Application_Service {}

	[ModelElement("Accéder au système","récuperer les informations propre au système d'exécution tel que version de l'OS, mémoire disponible, moteur de base de données..., ElementType = "ApplicationServiceArchimate")]
	partial class Accéder_au_système {}

	[ModelElement("Executer sur le système","permettre l'exécution de commande sur le système d''exploitation en exploitant les données produites, ElementType = "ApplicationServiceArchimate")]
	partial class Executer_sur_le_système {}

	[ModelElement("Gérer les transformations métier","gérer des ensemble de transformation de données sous forme de pipeline d'opération de transformation, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_les_transformations_métier {}

	[ModelElement("Authentifier un utilisateur","vérifier l'authentification d'un utilisateur, ElementType = "ApplicationServiceArchimate")]
	partial class Authentifier_un_utilisateur {}

	[ModelElement("Chiffer les données (A METTRE DANS COUCHE COMMUNE?)","transformer des données pour ne plus les rendre lisible sans décryptage, ElementType = "ApplicationServiceArchimate")]
	partial class Chiffer_les_données_A_METTRE_DANS_COUCHE_COMMUNE {}

	[ModelElement("Gérer l'infrastructure fonctionnelle","gérer l'organisation des services métier et des contrats par domaine métier, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_linfrastructure_fonctionnelle {}

	[ModelElement("Gérer l'infrastructure physique","gérer les informations sur l'infrastructure matériel du client, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_linfrastructure_physique {}

	[ModelElement("Gérer un registre des services","permettre de stocker les points d'accès des services en fonction de l'activité du système, ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_un_registre_des_services {}

	[ModelElement("Appeler un service","permettre l'exécution d'un service quelque soit sa localisation, ElementType = "ApplicationServiceArchimate")]
	partial class Appeler_un_service {}

	[ModelElement("Composer des vues","permettre la création d'une vue par composition de plusieurs vues imbriquées, ElementType = "ApplicationServiceArchimate")]
	partial class Composer_des_vues {}

	[ModelElement("Gérer l'accès aux objets partagés","gère l'accès à un objet dans un espace mémoire partagé: verrouillage d'accès, mémoire distribuée... à ne pas confondre avec la gestion d'une ressource partagée: une ressource n'a pas nécessairement d'état pertinent en mémoire, ce peut être par exemple une connection à une base de données qui ne contient pas de données métier utilisable. Un objet partagé peut être libéré explicitement par tout utilisateur, alors que la ressource est libéré à l'arrêt de son utilisation., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_laccès_aux_objets_partagés {}

	[ModelElement("Gérer l'accès aux vues système","gère l'affichage et le pilotage des vues standardisées tels que la boite de sélection de fichier, la boite \"à propos....\", etc..., ElementType = "ApplicationServiceArchimate")]
	partial class Gérer_laccès_aux_vues_système {}

	[ModelElement("Piloter la génératon d'un contrôle","définir la construction d'un contrôle ou d'une vue à partir des informations métier, ElementType = "ApplicationServiceArchimate")]
	partial class Piloter_la_génératon_dun_contrôle {}

	[ModelElement("Générer un workflow","construire dynamiquement l'enchainement de traitement d'un worflow à partir des données métier, ElementType = "ApplicationServiceArchimate")]
	partial class Générer_un_workflow {}

    partial class Workflow_Interface
    {
		List<IWorkflowEngine> iWorkflowEngine_ = 
			new List<IWorkflowEngine>();
		public List<IWorkflowEngine> IWorkflowEngine_ { get => iWorkflowEngine_; set => iWorkflowEngine_ = value; }

		List<IElementBPM> iElementBPM_ = 
			new List<IElementBPM>();
		public List<IElementBPM> IElementBPM_ { get => iElementBPM_; set => iElementBPM_ = value; }

		List<IModelBPM> iModelBPM_ = 
			new List<IModelBPM>();
		public List<IModelBPM> IModelBPM_ { get => iModelBPM_; set => iModelBPM_ = value; }

		List<IWorkflowBPMEngine> iWorkflowBPMEngine_ = 
			new List<IWorkflowBPMEngine>();
		public List<IWorkflowBPMEngine> IWorkflowBPMEngine_ { get => iWorkflowBPMEngine_; set => iWorkflowBPMEngine_ = value; }

		List<IWorkflowBPMN> iWorkflowBPMN_ = 
			new List<IWorkflowBPMN>();
		public List<IWorkflowBPMN> IWorkflowBPMN_ { get => iWorkflowBPMN_; set => iWorkflowBPMN_ = value; }

		List<IWorkflow> iWorkflow_ = 
			new List<IWorkflow>();
		public List<IWorkflow> IWorkflow_ { get => iWorkflow_; set => iWorkflow_ = value; }

		List<ISequence> iSequence_ = 
			new List<ISequence>();
		public List<ISequence> ISequence_ { get => iSequence_; set => iSequence_ = value; }

	}

    partial class Service_Infrastructure_Interface
    {
		List<IWorkflowAdminSrv> iWorkflowAdminSrv_ = 
			new List<IWorkflowAdminSrv>();
		public List<IWorkflowAdminSrv> IWorkflowAdminSrv_ { get => iWorkflowAdminSrv_; set => iWorkflowAdminSrv_ = value; }

		List<IRuleEngineSrv> iRuleEngineSrv_ = 
			new List<IRuleEngineSrv>();
		public List<IRuleEngineSrv> IRuleEngineSrv_ { get => iRuleEngineSrv_; set => iRuleEngineSrv_ = value; }

		List<IMailSrv> iMailSrv_ = 
			new List<IMailSrv>();
		public List<IMailSrv> IMailSrv_ { get => iMailSrv_; set => iMailSrv_ = value; }

		List<IHelpSrv> iHelpSrv_ = 
			new List<IHelpSrv>();
		public List<IHelpSrv> IHelpSrv_ { get => iHelpSrv_; set => iHelpSrv_ = value; }

		List<IReportEngineSrv> iReportEngineSrv_ = 
			new List<IReportEngineSrv>();
		public List<IReportEngineSrv> IReportEngineSrv_ { get => iReportEngineSrv_; set => iReportEngineSrv_ = value; }

		List<IJobSrv> iJobSrv_ = 
			new List<IJobSrv>();
		public List<IJobSrv> IJobSrv_ { get => iJobSrv_; set => iJobSrv_ = value; }

		List<IServiceLocatorSrv> iServiceLocatorSrv_ = 
			new List<IServiceLocatorSrv>();
		public List<IServiceLocatorSrv> IServiceLocatorSrv_ { get => iServiceLocatorSrv_; set => iServiceLocatorSrv_ = value; }

		List<ITransformEngineSrv> iTransformEngineSrv_ = 
			new List<ITransformEngineSrv>();
		public List<ITransformEngineSrv> ITransformEngineSrv_ { get => iTransformEngineSrv_; set => iTransformEngineSrv_ = value; }

	}

    partial class Bootstrap_Common
    {
		List<IConfigurationFct> iConfigurationFct_ = 
			new List<IConfigurationFct>();
		public List<IConfigurationFct> IConfigurationFct_ { get => iConfigurationFct_; set => iConfigurationFct_ = value; }

		List<IDeploymentArchitectureFct> iDeploymentArchitectureFct_ = 
			new List<IDeploymentArchitectureFct>();
		public List<IDeploymentArchitectureFct> IDeploymentArchitectureFct_ { get => iDeploymentArchitectureFct_; set => iDeploymentArchitectureFct_ = value; }

	}

    partial class Common
    {
		List<IAssertionFct> iAssertionFct_ = 
			new List<IAssertionFct>();
		public List<IAssertionFct> IAssertionFct_ { get => iAssertionFct_; set => iAssertionFct_ = value; }

		List<IBindingFct> iBindingFct_ = 
			new List<IBindingFct>();
		public List<IBindingFct> IBindingFct_ { get => iBindingFct_; set => iBindingFct_ = value; }

		List<IClientObjectAccessFct> iClientObjectAccessFct_ = 
			new List<IClientObjectAccessFct>();
		public List<IClientObjectAccessFct> IClientObjectAccessFct_ { get => iClientObjectAccessFct_; set => iClientObjectAccessFct_ = value; }

		List<IErrorHandlingFct> iErrorHandlingFct_ = 
			new List<IErrorHandlingFct>();
		public List<IErrorHandlingFct> IErrorHandlingFct_ { get => iErrorHandlingFct_; set => iErrorHandlingFct_ = value; }

		List<IRegistryFct> iRegistryFct_ = 
			new List<IRegistryFct>();
		public List<IRegistryFct> IRegistryFct_ { get => iRegistryFct_; set => iRegistryFct_ = value; }

		List<INotificationFct> iNotificationFct_ = 
			new List<INotificationFct>();
		public List<INotificationFct> INotificationFct_ { get => iNotificationFct_; set => iNotificationFct_ = value; }

		List<IComponentFct> iComponentFct_ = 
			new List<IComponentFct>();
		public List<IComponentFct> IComponentFct_ { get => iComponentFct_; set => iComponentFct_ = value; }

		List<IContextFct> iContextFct_ = 
			new List<IContextFct>();
		public List<IContextFct> IContextFct_ { get => iContextFct_; set => iContextFct_ = value; }

		List<IUnitOfWorkFct> iUnitOfWorkFct_ = 
			new List<IUnitOfWorkFct>();
		public List<IUnitOfWorkFct> IUnitOfWorkFct_ { get => iUnitOfWorkFct_; set => iUnitOfWorkFct_ = value; }

		List<ILogFct> iLogFct_ = 
			new List<ILogFct>();
		public List<ILogFct> ILogFct_ { get => iLogFct_; set => iLogFct_ = value; }

		List<IFunctionalDomainFct> iFunctionalDomainFct_ = 
			new List<IFunctionalDomainFct>();
		public List<IFunctionalDomainFct> IFunctionalDomainFct_ { get => iFunctionalDomainFct_; set => iFunctionalDomainFct_ = value; }

		List<IIdentityFct> iIdentityFct_ = 
			new List<IIdentityFct>();
		public List<IIdentityFct> IIdentityFct_ { get => iIdentityFct_; set => iIdentityFct_ = value; }

		List<IObjectRegistryFct> iObjectRegistryFct_ = 
			new List<IObjectRegistryFct>();
		public List<IObjectRegistryFct> IObjectRegistryFct_ { get => iObjectRegistryFct_; set => iObjectRegistryFct_ = value; }

		List<ICommunicationFct> iCommunicationFct_ = 
			new List<ICommunicationFct>();
		public List<ICommunicationFct> ICommunicationFct_ { get => iCommunicationFct_; set => iCommunicationFct_ = value; }

		List<ISubscriptionFct> iSubscriptionFct_ = 
			new List<ISubscriptionFct>();
		public List<ISubscriptionFct> ISubscriptionFct_ { get => iSubscriptionFct_; set => iSubscriptionFct_ = value; }

		List<ITaskFct> iTaskFct_ = 
			new List<ITaskFct>();
		public List<ITaskFct> ITaskFct_ { get => iTaskFct_; set => iTaskFct_ = value; }

		List<ITransactionFct> iTransactionFct_ = 
			new List<ITransactionFct>();
		public List<ITransactionFct> ITransactionFct_ { get => iTransactionFct_; set => iTransactionFct_ = value; }

		List<IObjectProxyFct> iObjectProxyFct_ = 
			new List<IObjectProxyFct>();
		public List<IObjectProxyFct> IObjectProxyFct_ { get => iObjectProxyFct_; set => iObjectProxyFct_ = value; }

		List<IObjectDispatcherFct> iObjectDispatcherFct_ = 
			new List<IObjectDispatcherFct>();
		public List<IObjectDispatcherFct> IObjectDispatcherFct_ { get => iObjectDispatcherFct_; set => iObjectDispatcherFct_ = value; }

		List<IUserTreatmentFct> iUserTreatmentFct_ = 
			new List<IUserTreatmentFct>();
		public List<IUserTreatmentFct> IUserTreatmentFct_ { get => iUserTreatmentFct_; set => iUserTreatmentFct_ = value; }

		List<IPermissionFct> iPermissionFct_ = 
			new List<IPermissionFct>();
		public List<IPermissionFct> IPermissionFct_ { get => iPermissionFct_; set => iPermissionFct_ = value; }

	}

    partial class Persistence_Interface
    {
		List<IPersistEngineFct> iPersistEngineFct_ = 
			new List<IPersistEngineFct>();
		public List<IPersistEngineFct> IPersistEngineFct_ { get => iPersistEngineFct_; set => iPersistEngineFct_ = value; }

		List<IResourceFct> iResourceFct_ = 
			new List<IResourceFct>();
		public List<IResourceFct> IResourceFct_ { get => iResourceFct_; set => iResourceFct_ = value; }

		List<IDAO> iDAO_ = 
			new List<IDAO>();
		public List<IDAO> IDAO_ { get => iDAO_; set => iDAO_ = value; }

		List<ISession> iSession_ = 
			new List<ISession>();
		public List<ISession> ISession_ { get => iSession_; set => iSession_ = value; }

		List<IORM> iORM_ = 
			new List<IORM>();
		public List<IORM> IORM_ { get => iORM_; set => iORM_ = value; }

		List<IDAOAutorisation> iDAOAutorisation_ = 
			new List<IDAOAutorisation>();
		public List<IDAOAutorisation> IDAOAutorisation_ { get => iDAOAutorisation_; set => iDAOAutorisation_ = value; }

		List<IDAOConfiguration> iDAOConfiguration_ = 
			new List<IDAOConfiguration>();
		public List<IDAOConfiguration> IDAOConfiguration_ { get => iDAOConfiguration_; set => iDAOConfiguration_ = value; }

		List<IDAOText> iDAOText_ = 
			new List<IDAOText>();
		public List<IDAOText> IDAOText_ { get => iDAOText_; set => iDAOText_ = value; }

		List<IDAONotification> iDAONotification_ = 
			new List<IDAONotification>();
		public List<IDAONotification> IDAONotification_ { get => iDAONotification_; set => iDAONotification_ = value; }

		List<IDAOResource> iDAOResource_ = 
			new List<IDAOResource>();
		public List<IDAOResource> IDAOResource_ { get => iDAOResource_; set => iDAOResource_ = value; }

		List<IDAOSessionContext> iDAOSessionContext_ = 
			new List<IDAOSessionContext>();
		public List<IDAOSessionContext> IDAOSessionContext_ { get => iDAOSessionContext_; set => iDAOSessionContext_ = value; }

		List<IDAOStateMachine> iDAOStateMachine_ = 
			new List<IDAOStateMachine>();
		public List<IDAOStateMachine> IDAOStateMachine_ { get => iDAOStateMachine_; set => iDAOStateMachine_ = value; }

		List<IDAOUserContext> iDAOUserContext_ = 
			new List<IDAOUserContext>();
		public List<IDAOUserContext> IDAOUserContext_ { get => iDAOUserContext_; set => iDAOUserContext_ = value; }

		List<IDAOWorkflow> iDAOWorkflow_ = 
			new List<IDAOWorkflow>();
		public List<IDAOWorkflow> IDAOWorkflow_ { get => iDAOWorkflow_; set => iDAOWorkflow_ = value; }

		List<IPersistenceTransformation> iPersistenceTransformation_ = 
			new List<IPersistenceTransformation>();
		public List<IPersistenceTransformation> IPersistenceTransformation_ { get => iPersistenceTransformation_; set => iPersistenceTransformation_ = value; }

		List<IDAODocumentText> iDAODocumentText_ = 
			new List<IDAODocumentText>();
		public List<IDAODocumentText> IDAODocumentText_ { get => iDAODocumentText_; set => iDAODocumentText_ = value; }

		List<IDAOSpreadsheet> iDAOSpreadsheet_ = 
			new List<IDAOSpreadsheet>();
		public List<IDAOSpreadsheet> IDAOSpreadsheet_ { get => iDAOSpreadsheet_; set => iDAOSpreadsheet_ = value; }

		List<IDAOResourceWeb> iDAOResourceWeb_ = 
			new List<IDAOResourceWeb>();
		public List<IDAOResourceWeb> IDAOResourceWeb_ { get => iDAOResourceWeb_; set => iDAOResourceWeb_ = value; }

		List<IDAOImage> iDAOImage_ = 
			new List<IDAOImage>();
		public List<IDAOImage> IDAOImage_ { get => iDAOImage_; set => iDAOImage_ = value; }

		List<IDAOSchema> iDAOSchema_ = 
			new List<IDAOSchema>();
		public List<IDAOSchema> IDAOSchema_ { get => iDAOSchema_; set => iDAOSchema_ = value; }

	}

    partial class Tool_1
    {
		List<Composant_1> composant_1_ = 
			new List<Composant_1>();
		public List<Composant_1> Composant_1_ { get => composant_1_; set => composant_1_ = value; }

		List<Composant_2> composant_2_ = 
			new List<Composant_2>();
		public List<Composant_2> Composant_2_ { get => composant_2_; set => composant_2_ = value; }

	}

    partial class Tool_4
    {
		List<Composant_3> composant_3_ = 
			new List<Composant_3>();
		public List<Composant_3> Composant_3_ { get => composant_3_; set => composant_3_ = value; }

	}

    partial class Serveur_1
    {
		List<Composant_4> composant_4_ = 
			new List<Composant_4>();
		public List<Composant_4> Composant_4_ { get => composant_4_; set => composant_4_ = value; }

	}

    partial class Serveur_2
    {
		List<Composant_5> composant_5_ = 
			new List<Composant_5>();
		public List<Composant_5> Composant_5_ { get => composant_5_; set => composant_5_ = value; }

	}

    partial class Interfaces_Vues_Hapicare
    {
		List<IVues_Hapicare> iVues_Hapicare_ = 
			new List<IVues_Hapicare>();
		public List<IVues_Hapicare> IVues_Hapicare_ { get => iVues_Hapicare_; set => iVues_Hapicare_ = value; }

	}

    partial class Interfaces_workflows_Hapicare
    {
		List<IWorkflows_Hapicare> iWorkflows_Hapicare_ = 
			new List<IWorkflows_Hapicare>();
		public List<IWorkflows_Hapicare> IWorkflows_Hapicare_ { get => iWorkflows_Hapicare_; set => iWorkflows_Hapicare_ = value; }

	}

    partial class Interface_couche_Workflow
    {
		List<IWorkflow> iWorkflow_ = 
			new List<IWorkflow>();
		public List<IWorkflow> IWorkflow_ { get => iWorkflow_; set => iWorkflow_ = value; }

	}

    partial class Interfaces_Services_Hapicare
    {
		List<IServices_Hapicare> iServices_Hapicare_ = 
			new List<IServices_Hapicare>();
		public List<IServices_Hapicare> IServices_Hapicare_ { get => iServices_Hapicare_; set => iServices_Hapicare_ = value; }

	}

    partial class Interface_couche_Service
    {
		List<IService> iService_ = 
			new List<IService>();
		public List<IService> IService_ { get => iService_; set => iService_ = value; }

	}

    partial class Interfaces_ADO
    {
		List<IADO_Hapicare> iADO_Hapicare_ = 
			new List<IADO_Hapicare>();
		public List<IADO_Hapicare> IADO_Hapicare_ { get => iADO_Hapicare_; set => iADO_Hapicare_ = value; }

	}

    partial class Interface_couche_Persistance
    {
		List<IADO> iADO_ = 
			new List<IADO>();
		public List<IADO> IADO_ { get => iADO_; set => iADO_ = value; }

	}

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

    partial class Interface_workflow_métier
    {
		List<IWorkflowExample> iWorkflowExample_ = 
			new List<IWorkflowExample>();
		public List<IWorkflowExample> IWorkflowExample_ { get => iWorkflowExample_; set => iWorkflowExample_ = value; }

	}

    partial class Interface_Vue_métier
    {
		List<IViewExample> iViewExample_ = 
			new List<IViewExample>();
		public List<IViewExample> IViewExample_ { get => iViewExample_; set => iViewExample_ = value; }

	}

    partial class Presentation_Interface
    {
		List<IView> iView_ = 
			new List<IView>();
		public List<IView> IView_ { get => iView_; set => iView_ = value; }

		List<IComposerViewSrv> iComposerViewSrv_ = 
			new List<IComposerViewSrv>();
		public List<IComposerViewSrv> IComposerViewSrv_ { get => iComposerViewSrv_; set => iComposerViewSrv_ = value; }

		List<IRenderViewSrv> iRenderViewSrv_ = 
			new List<IRenderViewSrv>();
		public List<IRenderViewSrv> IRenderViewSrv_ { get => iRenderViewSrv_; set => iRenderViewSrv_ = value; }

		List<IReportDocumentSrv> iReportDocumentSrv_ = 
			new List<IReportDocumentSrv>();
		public List<IReportDocumentSrv> IReportDocumentSrv_ { get => iReportDocumentSrv_; set => iReportDocumentSrv_ = value; }

		List<IViewSrv> iViewSrv_ = 
			new List<IViewSrv>();
		public List<IViewSrv> IViewSrv_ { get => iViewSrv_; set => iViewSrv_ = value; }

		List<IFileDialogView> iFileDialogView_ = 
			new List<IFileDialogView>();
		public List<IFileDialogView> IFileDialogView_ { get => iFileDialogView_; set => iFileDialogView_ = value; }

		List<IMessageBoxView> iMessageBoxView_ = 
			new List<IMessageBoxView>();
		public List<IMessageBoxView> IMessageBoxView_ { get => iMessageBoxView_; set => iMessageBoxView_ = value; }

		List<IDocumentEditorView> iDocumentEditorView_ = 
			new List<IDocumentEditorView>();
		public List<IDocumentEditorView> IDocumentEditorView_ { get => iDocumentEditorView_; set => iDocumentEditorView_ = value; }

		List<ITextEditorView> iTextEditorView_ = 
			new List<ITextEditorView>();
		public List<ITextEditorView> ITextEditorView_ { get => iTextEditorView_; set => iTextEditorView_ = value; }

		List<IProgressView> iProgressView_ = 
			new List<IProgressView>();
		public List<IProgressView> IProgressView_ { get => iProgressView_; set => iProgressView_ = value; }

		List<IDiffView> iDiffView_ = 
			new List<IDiffView>();
		public List<IDiffView> IDiffView_ { get => iDiffView_; set => iDiffView_ = value; }

		List<IWaitView> iWaitView_ = 
			new List<IWaitView>();
		public List<IWaitView> IWaitView_ { get => iWaitView_; set => iWaitView_ = value; }

		List<IDeviceSrv> iDeviceSrv_ = 
			new List<IDeviceSrv>();
		public List<IDeviceSrv> IDeviceSrv_ { get => iDeviceSrv_; set => iDeviceSrv_ = value; }

		List<IDevice> iDevice_ = 
			new List<IDevice>();
		public List<IDevice> IDevice_ { get => iDevice_; set => iDevice_ = value; }

		List<IKeyboardSrv> iKeyboardSrv_ = 
			new List<IKeyboardSrv>();
		public List<IKeyboardSrv> IKeyboardSrv_ { get => iKeyboardSrv_; set => iKeyboardSrv_ = value; }

	}

    partial class Service_Interface
    {
		List<IService> iService_ = 
			new List<IService>();
		public List<IService> IService_ { get => iService_; set => iService_ = value; }

		List<IServiceCRUD> iServiceCRUD_ = 
			new List<IServiceCRUD>();
		public List<IServiceCRUD> IServiceCRUD_ { get => iServiceCRUD_; set => iServiceCRUD_ = value; }

		List<ISpecification> iSpecification_ = 
			new List<ISpecification>();
		public List<ISpecification> ISpecification_ { get => iSpecification_; set => iSpecification_ = value; }

		List<IServiceReport> iServiceReport_ = 
			new List<IServiceReport>();
		public List<IServiceReport> IServiceReport_ { get => iServiceReport_; set => iServiceReport_ = value; }

		List<ITransformation> iTransformation_ = 
			new List<ITransformation>();
		public List<ITransformation> ITransformation_ { get => iTransformation_; set => iTransformation_ = value; }

		List<ILog> iLog_ = 
			new List<ILog>();
		public List<ILog> ILog_ { get => iLog_; set => iLog_ = value; }

		List<IAutorisation> iAutorisation_ = 
			new List<IAutorisation>();
		public List<IAutorisation> IAutorisation_ { get => iAutorisation_; set => iAutorisation_ = value; }

		List<ILabel> iLabel_ = 
			new List<ILabel>();
		public List<ILabel> ILabel_ { get => iLabel_; set => iLabel_ = value; }

		List<INotification> iNotification_ = 
			new List<INotification>();
		public List<INotification> INotification_ { get => iNotification_; set => iNotification_ = value; }

		List<IResource> iResource_ = 
			new List<IResource>();
		public List<IResource> IResource_ { get => iResource_; set => iResource_ = value; }

		List<ISessionContext> iSessionContext_ = 
			new List<ISessionContext>();
		public List<ISessionContext> ISessionContext_ { get => iSessionContext_; set => iSessionContext_ = value; }

		List<ITransaction> iTransaction_ = 
			new List<ITransaction>();
		public List<ITransaction> ITransaction_ { get => iTransaction_; set => iTransaction_ = value; }

		List<IStateMachine> iStateMachine_ = 
			new List<IStateMachine>();
		public List<IStateMachine> IStateMachine_ { get => iStateMachine_; set => iStateMachine_ = value; }

		List<IUserContext> iUserContext_ = 
			new List<IUserContext>();
		public List<IUserContext> IUserContext_ { get => iUserContext_; set => iUserContext_ = value; }

	}

    partial class Interface_Service_métier
    {
		List<IServiceExample> iServiceExample_ = 
			new List<IServiceExample>();
		public List<IServiceExample> IServiceExample_ { get => iServiceExample_; set => iServiceExample_ = value; }

		List<IServiceCRUDExample> iServiceCRUDExample_ = 
			new List<IServiceCRUDExample>();
		public List<IServiceCRUDExample> IServiceCRUDExample_ { get => iServiceCRUDExample_; set => iServiceCRUDExample_ = value; }

	}

    partial class Interface_persistance_métier
    {
		List<IDAOExample> iDAOExample_ = 
			new List<IDAOExample>();
		public List<IDAOExample> IDAOExample_ { get => iDAOExample_; set => iDAOExample_ = value; }

	}

    partial class Interface_Controle
    {
		List<IControl> iControl_ = 
			new List<IControl>();
		public List<IControl> IControl_ { get => iControl_; set => iControl_ = value; }

		List<IContainerControl> iContainerControl_ = 
			new List<IContainerControl>();
		public List<IContainerControl> IContainerControl_ { get => iContainerControl_; set => iContainerControl_ = value; }

	}

    partial class Interface_Controle_métier
    {
		List<IControlExample> iControlExample_ = 
			new List<IControlExample>();
		public List<IControlExample> IControlExample_ { get => iControlExample_; set => iControlExample_ = value; }

		List<IContainerControlExample> iContainerControlExample_ = 
			new List<IContainerControlExample>();
		public List<IContainerControlExample> IContainerControlExample_ { get => iContainerControlExample_; set => iContainerControlExample_ = value; }

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

    partial class Interface_couche_Vue
    {
		List<IView> iView_ = 
			new List<IView>();
		public List<IView> IView_ { get => iView_; set => iView_ = value; }

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

    partial class Client
    {
		List<Utilisateur> utilisateur_ = 
			new List<Utilisateur>();
		public List<Utilisateur> Utilisateur_ { get => utilisateur_; set => utilisateur_ = value; }

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

    partial class Persistence_Infrastructure_Interface
    {
		List<IDAOHelp> iDAOHelp_ = 
			new List<IDAOHelp>();
		public List<IDAOHelp> IDAOHelp_ { get => iDAOHelp_; set => iDAOHelp_ = value; }

		List<IDAOServiceLocator> iDAOServiceLocator_ = 
			new List<IDAOServiceLocator>();
		public List<IDAOServiceLocator> IDAOServiceLocator_ { get => iDAOServiceLocator_; set => iDAOServiceLocator_ = value; }

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

    partial class Services_applicatif
    {
		List<IServices_métier> iServices_métier_ = 
			new List<IServices_métier>();
		public List<IServices_métier> IServices_métier_ { get => iServices_métier_; set => iServices_métier_ = value; }

	}


	partial class CConfigurationFctDesktop : CConfigurationFct_EN_COURS {}
	partial class CIdentityFctDesktop_EN_COURS : CIdentityFct_EN_COURS {}
	partial class CObjectRegistryFctDesktop : CObjectRegistryFct {}
	partial class CSubscriptionServiceFct : CSubscriptionFct {}
	partial class CSubscriptionServiceFctDesktop : CSubscriptionFctDesktop {}
	partial class CProtocolREST : CProtocolStack {}
	partial class CProtocolWCF : CProtocolStack {}
	partial class Decision_support_for_symptom_checking_Application : Decision_support_application {}
	partial class Decision_support_for_prescription : Decision_support_application {}
	partial class GPS : Périphérique_mobile {}
	partial class Exception_technique : Exception {}
	partial class Exception_métier : Exception {}
	partial class Tool_externe : Tool {}
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
	partial class IVues_Hapicare : IView {}
	partial class IWorkflows_Hapicare : IWorkflow {}
	partial class Workflows_Hapicare : Workflow {}
	partial class Vue_web : Vue {}
	partial class Vues_Hapicare : Vue_web {}
	partial class IServices_Hapicare : IService {}
	partial class Services_Métier_Hapicare : Service {}
	partial class IADO_Hapicare : IADO {}
	partial class ADO_Hapicare : ADO_Nhibernate {}
	partial class ADO_Nhibernate : ADO {}
	partial class Services_CRUD_Hapicare : Service_CRUD {}
	partial class Entités_Hapicare : Entité_métier {}
	partial class Exceptions_Hapicare : Exception_métier {}
	partial class Aspects_Hapicare : Aspect {}
	partial class Application_Hapicare : Application_Web {}
	partial class Application_Web : Application {}
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
	partial class Type_valeur_métier : Classe_métier {}
	partial class Vue_générique : Vue {}
	partial class Vue_applicatif : Vue {}
	partial class IWorkflowExample : IWorkflow {}
	partial class IViewExample : IView {}
	partial class IServiceExample : IService {}
	partial class IDAOExample : IDAO {}
	partial class IContainerControlExample : IContainerControl {}
	partial class IControlExample : IControl {}
	partial class IServiceCRUD : IService {}
	partial class IServiceCRUDExample : IServiceCRUD {}
	partial class Domaine_fonctionnel_métier : Domaine_fonctionnel {}
	partial class Contrat_de_service_métier : Contrat_de_service {}
	partial class Aspect_métier : Aspect {}
	partial class Tool_externe_métier : Tool_externe {}
	partial class Alerte_métier : Alerte {}
	partial class Notification_métier : Notification {}
	partial class Widget_métier : Widget {}
	partial class Serveur_métier : Serveur {}
	partial class Composant_serveur_métier : Composant_serveur {}
	partial class Tâche_métier : Tâche {}
	partial class Péripherique_spécifique : Périphérique_technique {}
	partial class Scénario_métier : Scénario_A_COMPLETER {}
	partial class Etat_métier : Etat {}
	partial class Widget_externe_métier : Widget_externe {}
	partial class Transformation_métier : Transformation {}
	partial class IDAOResourceWeb : IDAOResource {}
	partial class Vue_externe_métier : Vue_externe {}
	partial class Transformation : Service {}
	partial class Périphérique_mobile : Périphérique {}
	partial class Tool_métier : Tool {}
	partial class Tâche_métier : Tâche {}
	partial class Document_texte : Document {}
	partial class Document_tableau : Document {}
	partial class Image : Document {}

    partial class Bootstrap_Application
    {
		List<Composant_IHM> composant_IHM_ ;
		public List<Composant_IHM> Composant_IHM_ { get => composant_IHM_; set => composant_IHM_ = value; }

		List<Composant_technique_local> composant_technique_local_ ;
		public List<Composant_technique_local> Composant_technique_local_ { get => composant_technique_local_; set => composant_technique_local_ = value; }

		List<Composant_service_métier> composant_service_métier_ ;
		public List<Composant_service_métier> Composant_service_métier_ { get => composant_service_métier_; set => composant_service_métier_ = value; }

		List<Composant_workflow> composant_workflow_ ;
		public List<Composant_workflow> Composant_workflow_ { get => composant_workflow_; set => composant_workflow_ = value; }

	}
    partial class Licence
    {
		List<Composant> composant_ ;
		public List<Composant> Composant_ { get => composant_; set => composant_ = value; }

	}
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
    partial class Cache_dobjet
    {
		List<Entité_métier> entité_métier_ ;
		public List<Entité_métier> Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}
    partial class Entité_métier
    {
		List<Notification> notification_ ;
		public List<Notification> Notification_ { get => notification_; set => notification_ = value; }

		List<Validateur> validateur_ ;
		public List<Validateur> Validateur_ { get => validateur_; set => validateur_ = value; }

		List<Notification_métier> notification_métier_ ;
		public List<Notification_métier> Notification_métier_ { get => notification_métier_; set => notification_métier_ = value; }

	}
    partial class Version
    {
		List<Composant> composant_ ;
		public List<Composant> Composant_ { get => composant_; set => composant_ = value; }

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
		List<Classe_métier> classe_métier_ ;
		public List<Classe_métier> Classe_métier_ { get => classe_métier_; set => classe_métier_ = value; }

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
    partial class IViewExample
    {
		List<IWorkflowExample> iWorkflowExample_ ;
		public List<IWorkflowExample> IWorkflowExample_ { get => iWorkflowExample_; set => iWorkflowExample_ = value; }

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
    partial class Workflow_générique
    {
		List<Vue_générique> vue_générique_ ;
		public List<Vue_générique> Vue_générique_ { get => vue_générique_; set => vue_générique_ = value; }

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
    partial class Scénario_A_COMPLETER
    {
		List<Service> service_ ;
		public List<Service> Service_ { get => service_; set => service_ = value; }

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
    partial class Serveur_applicatif
    {
		List<Services_applicatif> services_applicatif_ ;
		public List<Services_applicatif> Services_applicatif_ { get => services_applicatif_; set => services_applicatif_ = value; }

	}
    partial class IView
    {
		List<IWorkflow> iWorkflow_ ;
		public List<IWorkflow> IWorkflow_ { get => iWorkflow_; set => iWorkflow_ = value; }

	}

    partial class Lanceur
    {
		Workflow workflow_ ;
		public Workflow Workflow_ { get => workflow_; set => workflow_ = value; }

	}

    partial class IModelBPM
    {
		ProcessBPM processBPM_ ;
		public ProcessBPM ProcessBPM_ { get => processBPM_; set => processBPM_ = value; }

		ActivityBPM activityBPM_ ;
		public ActivityBPM ActivityBPM_ { get => activityBPM_; set => activityBPM_ = value; }

	}

    partial class IElementBPM
    {
		TaskBPM taskBPM_ ;
		public TaskBPM TaskBPM_ { get => taskBPM_; set => taskBPM_ = value; }

		CasExecutionBPM casExecutionBPM_ ;
		public CasExecutionBPM CasExecutionBPM_ { get => casExecutionBPM_; set => casExecutionBPM_ = value; }

		ActorBPM actorBPM_ ;
		public ActorBPM ActorBPM_ { get => actorBPM_; set => actorBPM_ = value; }

	}

    partial class Workflows_Hapicare
    {
		IServices_Hapicare iServices_Hapicare_ ;
		public IServices_Hapicare IServices_Hapicare_ { get => iServices_Hapicare_; set => iServices_Hapicare_ = value; }

		IVues_Hapicare iVues_Hapicare_ ;
		public IVues_Hapicare IVues_Hapicare_ { get => iVues_Hapicare_; set => iVues_Hapicare_ = value; }

	}

    partial class Services_Métier_Hapicare
    {
		Services_CRUD_Hapicare services_CRUD_Hapicare_ ;
		public Services_CRUD_Hapicare Services_CRUD_Hapicare_ { get => services_CRUD_Hapicare_; set => services_CRUD_Hapicare_ = value; }

	}

    partial class Services_CRUD_Hapicare
    {
		IADO_Hapicare iADO_Hapicare_ ;
		public IADO_Hapicare IADO_Hapicare_ { get => iADO_Hapicare_; set => iADO_Hapicare_ = value; }

	}

    partial class Aspects_Hapicare
    {
		Services_Métier_Hapicare services_Métier_Hapicare_ ;
		public Services_Métier_Hapicare Services_Métier_Hapicare_ { get => services_Métier_Hapicare_; set => services_Métier_Hapicare_ = value; }

	}

    partial class Fonctionalité_technique
    {
		Aspects_Hapicare aspects_Hapicare_ ;
		public Aspects_Hapicare Aspects_Hapicare_ { get => aspects_Hapicare_; set => aspects_Hapicare_ = value; }

		Service service_ ;
		public Service Service_ { get => service_; set => service_ = value; }

	}

    partial class Application_Hapicare
    {
		IWorkflows_Hapicare iWorkflows_Hapicare_ ;
		public IWorkflows_Hapicare IWorkflows_Hapicare_ { get => iWorkflows_Hapicare_; set => iWorkflows_Hapicare_ = value; }

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

		Version version_ ;
		public Version Version_ { get => version_; set => version_ = value; }

		Aide_application aide_application_ ;
		public Aide_application Aide_application_ { get => aide_application_; set => aide_application_ = value; }

	}

    partial class Client
    {
		Licence licence_ ;
		public Licence Licence_ { get => licence_; set => licence_ = value; }

		Exposer_des_services_métier_à_la_carte exposer_des_services_métier_à_la_carte_ ;
		public Exposer_des_services_métier_à_la_carte Exposer_des_services_métier_à_la_carte_ { get => exposer_des_services_métier_à_la_carte_; set => exposer_des_services_métier_à_la_carte_ = value; }

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

		Persistance_fiable_des_données persistance_fiable_des_données_ ;
		public Persistance_fiable_des_données Persistance_fiable_des_données_ { get => persistance_fiable_des_données_; set => persistance_fiable_des_données_ = value; }

	}

    partial class ORM
    {
		Unité_de_travail unité_de_travail_ ;
		public Unité_de_travail Unité_de_travail_ { get => unité_de_travail_; set => unité_de_travail_ = value; }

		ADO aDO_ ;
		public ADO ADO_ { get => aDO_; set => aDO_ = value; }

		Transaction transaction_ ;
		public Transaction Transaction_ { get => transaction_; set => transaction_ = value; }

		Persistance_fiable_des_données persistance_fiable_des_données_ ;
		public Persistance_fiable_des_données Persistance_fiable_des_données_ { get => persistance_fiable_des_données_; set => persistance_fiable_des_données_ = value; }

		Utilisation_des_standards_du_marché utilisation_des_standards_du_marché_ ;
		public Utilisation_des_standards_du_marché Utilisation_des_standards_du_marché_ { get => utilisation_des_standards_du_marché_; set => utilisation_des_standards_du_marché_ = value; }

	}

    partial class Verrou
    {
		ORM oRM_ ;
		public ORM ORM_ { get => oRM_; set => oRM_ = value; }

	}

    partial class Requete
    {
		Découpage_en_objet_métier découpage_en_objet_métier_ ;
		public Découpage_en_objet_métier Découpage_en_objet_métier_ { get => découpage_en_objet_métier_; set => découpage_en_objet_métier_ = value; }

	}

    partial class Deployeur
    {
		Simplifier_le_déploiement simplifier_le_déploiement_ ;
		public Simplifier_le_déploiement Simplifier_le_déploiement_ { get => simplifier_le_déploiement_; set => simplifier_le_déploiement_ = value; }

		Composant composant_ ;
		public Composant Composant_ { get => composant_; set => composant_ = value; }

	}

    partial class Licence
    {
		Exposer_des_services_métier_à_la_carte exposer_des_services_métier_à_la_carte_ ;
		public Exposer_des_services_métier_à_la_carte Exposer_des_services_métier_à_la_carte_ { get => exposer_des_services_métier_à_la_carte_; set => exposer_des_services_métier_à_la_carte_ = value; }

		Version version_ ;
		public Version Version_ { get => version_; set => version_ = value; }

	}

    partial class Version
    {
		Exposer_des_services_métier_à_la_carte exposer_des_services_métier_à_la_carte_ ;
		public Exposer_des_services_métier_à_la_carte Exposer_des_services_métier_à_la_carte_ { get => exposer_des_services_métier_à_la_carte_; set => exposer_des_services_métier_à_la_carte_ = value; }

	}

    partial class Périphérique_technique
    {
		Intégration_des_applications_externes intégration_des_applications_externes_ ;
		public Intégration_des_applications_externes Intégration_des_applications_externes_ { get => intégration_des_applications_externes_; set => intégration_des_applications_externes_ = value; }

	}

    partial class IView
    {
		IWorkflows_Hapicare iWorkflows_Hapicare_ ;
		public IWorkflows_Hapicare IWorkflows_Hapicare_ { get => iWorkflows_Hapicare_; set => iWorkflows_Hapicare_ = value; }

		IWorkflow iWorkflow_ ;
		public IWorkflow IWorkflow_ { get => iWorkflow_; set => iWorkflow_ = value; }

	}

    partial class Service_CRUD
    {
		IADO iADO_ ;
		public IADO IADO_ { get => iADO_; set => iADO_ = value; }

		Interface_ADO interface_ADO_ ;
		public Interface_ADO Interface_ADO_ { get => interface_ADO_; set => interface_ADO_ = value; }

		Entité_métier entité_métier_ ;
		public Entité_métier Entité_métier_ { get => entité_métier_; set => entité_métier_ = value; }

	}

    partial class Entité_métier
    {
		Type_valeur_métier type_valeur_métier_ ;
		public Type_valeur_métier Type_valeur_métier_ { get => type_valeur_métier_; set => type_valeur_métier_ = value; }

		Saisie_fiabilisé_des_données saisie_fiabilisé_des_données_ ;
		public Saisie_fiabilisé_des_données Saisie_fiabilisé_des_données_ { get => saisie_fiabilisé_des_données_; set => saisie_fiabilisé_des_données_ = value; }

		Affichage_consistant_des_données affichage_consistant_des_données_ ;
		public Affichage_consistant_des_données Affichage_consistant_des_données_ { get => affichage_consistant_des_données_; set => affichage_consistant_des_données_ = value; }

		Implémentation_des_cas_dutilisation_métier implémentation_des_cas_dutilisation_métier_ ;
		public Implémentation_des_cas_dutilisation_métier Implémentation_des_cas_dutilisation_métier_ { get => implémentation_des_cas_dutilisation_métier_; set => implémentation_des_cas_dutilisation_métier_ = value; }

	}

    partial class Aspect
    {
		Cache_dobjet cache_dobjet_ ;
		public Cache_dobjet Cache_dobjet_ { get => cache_dobjet_; set => cache_dobjet_ = value; }

		Cache_appel cache_appel_ ;
		public Cache_appel Cache_appel_ { get => cache_appel_; set => cache_appel_ = value; }

	}

    partial class Autorisation
    {
		Interface_de_classe interface_de_classe_ ;
		public Interface_de_classe Interface_de_classe_ { get => interface_de_classe_; set => interface_de_classe_ = value; }

		Affichage_consistant_des_données affichage_consistant_des_données_ ;
		public Affichage_consistant_des_données Affichage_consistant_des_données_ { get => affichage_consistant_des_données_; set => affichage_consistant_des_données_ = value; }

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

    partial class IORM
    {
		ORM oRM_ ;
		public ORM ORM_ { get => oRM_; set => oRM_ = value; }

		ISession iSession_ ;
		public ISession ISession_ { get => iSession_; set => iSession_ = value; }

	}

    partial class ISession
    {
		Unité_de_travail unité_de_travail_ ;
		public Unité_de_travail Unité_de_travail_ { get => unité_de_travail_; set => unité_de_travail_ = value; }

	}

    partial class IWorkflowExample
    {
		CEntityExample cEntityExample_ ;
		public CEntityExample CEntityExample_ { get => cEntityExample_; set => cEntityExample_ = value; }

		CCollection_A_REMPLACER_PAR_CRELATION cCollection_A_REMPLACER_PAR_CRELATION_ ;
		public CCollection_A_REMPLACER_PAR_CRELATION CCollection_A_REMPLACER_PAR_CRELATION_ { get => cCollection_A_REMPLACER_PAR_CRELATION_; set => cCollection_A_REMPLACER_PAR_CRELATION_ = value; }

	}

    partial class IServiceExample
    {
		CEntityExample cEntityExample_ ;
		public CEntityExample CEntityExample_ { get => cEntityExample_; set => cEntityExample_ = value; }

		CCollection_A_REMPLACER_PAR_CRELATION cCollection_A_REMPLACER_PAR_CRELATION_ ;
		public CCollection_A_REMPLACER_PAR_CRELATION CCollection_A_REMPLACER_PAR_CRELATION_ { get => cCollection_A_REMPLACER_PAR_CRELATION_; set => cCollection_A_REMPLACER_PAR_CRELATION_ = value; }

	}

    partial class Méthodes_CWorkflowExample
    {
		Exécution_workflow_métier exécution_workflow_métier_ ;
		public Exécution_workflow_métier Exécution_workflow_métier_ { get => exécution_workflow_métier_; set => exécution_workflow_métier_ = value; }

	}

    partial class IDAO
    {
		CServiceCRUD cServiceCRUD_ ;
		public CServiceCRUD CServiceCRUD_ { get => cServiceCRUD_; set => cServiceCRUD_ = value; }

		IORM iORM_ ;
		public IORM IORM_ { get => iORM_; set => iORM_ = value; }

	}

    partial class Service_métier
    {
		Contrat_de_service_métier contrat_de_service_métier_ ;
		public Contrat_de_service_métier Contrat_de_service_métier_ { get => contrat_de_service_métier_; set => contrat_de_service_métier_ = value; }

		Gestion_de_règles gestion_de_règles_ ;
		public Gestion_de_règles Gestion_de_règles_ { get => gestion_de_règles_; set => gestion_de_règles_ = value; }

	}

    partial class Fonctionnalité
    {
		Workflow_métier workflow_métier_ ;
		public Workflow_métier Workflow_métier_ { get => workflow_métier_; set => workflow_métier_ = value; }

		Implémentation_des_cas_dutilisation_métier implémentation_des_cas_dutilisation_métier_ ;
		public Implémentation_des_cas_dutilisation_métier Implémentation_des_cas_dutilisation_métier_ { get => implémentation_des_cas_dutilisation_métier_; set => implémentation_des_cas_dutilisation_métier_ = value; }

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

    partial class Workflow_générique
    {
		Service_générique service_générique_ ;
		public Service_générique Service_générique_ { get => service_générique_; set => service_générique_ = value; }

	}

    partial class Service_générique
    {
		ADO_générique aDO_générique_ ;
		public ADO_générique ADO_générique_ { get => aDO_générique_; set => aDO_générique_ = value; }

	}

    partial class Aide_contextuelle
    {
		Widget widget_ ;
		public Widget Widget_ { get => widget_; set => widget_ = value; }

		Affichage_consistant_des_données affichage_consistant_des_données_ ;
		public Affichage_consistant_des_données Affichage_consistant_des_données_ { get => affichage_consistant_des_données_; set => affichage_consistant_des_données_ = value; }

	}

    partial class Type_valeur_métier
    {
		Validateur validateur_ ;
		public Validateur Validateur_ { get => validateur_; set => validateur_ = value; }

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
		Affichage_consistant_des_données affichage_consistant_des_données_ ;
		public Affichage_consistant_des_données Affichage_consistant_des_données_ { get => affichage_consistant_des_données_; set => affichage_consistant_des_données_ = value; }

		Réutilisation_des_IHM réutilisation_des_IHM_ ;
		public Réutilisation_des_IHM Réutilisation_des_IHM_ { get => réutilisation_des_IHM_; set => réutilisation_des_IHM_ = value; }

	}

    partial class Vue_métier
    {
		Affichage_consistant_des_données affichage_consistant_des_données_ ;
		public Affichage_consistant_des_données Affichage_consistant_des_données_ { get => affichage_consistant_des_données_; set => affichage_consistant_des_données_ = value; }

	}

    partial class Méthodes_CStateMachine
    {
		Automate_détat_fini automate_détat_fini_ ;
		public Automate_détat_fini Automate_détat_fini_ { get => automate_détat_fini_; set => automate_détat_fini_ = value; }

	}

    partial class IRenderViewSrv
    {
		CRenderViewMgr cRenderViewMgr_ ;
		public CRenderViewMgr CRenderViewMgr_ { get => cRenderViewMgr_; set => cRenderViewMgr_ = value; }

	}

    partial class IReportDocumentSrv
    {
		CReportDocumentMgr cReportDocumentMgr_ ;
		public CReportDocumentMgr CReportDocumentMgr_ { get => cReportDocumentMgr_; set => cReportDocumentMgr_ = value; }

	}

    partial class ITextEditorView
    {
		CViewMgr cViewMgr_ ;
		public CViewMgr CViewMgr_ { get => cViewMgr_; set => cViewMgr_ = value; }

	}

    partial class Tool_externe
    {
		Intégration_de_lexistant intégration_de_lexistant_ ;
		public Intégration_de_lexistant Intégration_de_lexistant_ { get => intégration_de_lexistant_; set => intégration_de_lexistant_ = value; }

	}

    partial class Workflow_métier
    {
		Implémentation_des_cas_dutilisation_métier implémentation_des_cas_dutilisation_métier_ ;
		public Implémentation_des_cas_dutilisation_métier Implémentation_des_cas_dutilisation_métier_ { get => implémentation_des_cas_dutilisation_métier_; set => implémentation_des_cas_dutilisation_métier_ = value; }

	}

    partial class Validateur
    {
		Saisie_fiabilisé_des_données saisie_fiabilisé_des_données_ ;
		public Saisie_fiabilisé_des_données Saisie_fiabilisé_des_données_ { get => saisie_fiabilisé_des_données_; set => saisie_fiabilisé_des_données_ = value; }

	}

    partial class Message
    {
		Affichage_consistant_des_données affichage_consistant_des_données_ ;
		public Affichage_consistant_des_données Affichage_consistant_des_données_ { get => affichage_consistant_des_données_; set => affichage_consistant_des_données_ = value; }

	}

    partial class Notification
    {
		Affichage_consistant_des_données affichage_consistant_des_données_ ;
		public Affichage_consistant_des_données Affichage_consistant_des_données_ { get => affichage_consistant_des_données_; set => affichage_consistant_des_données_ = value; }

	}

    partial class Exception_métier
    {
		Fiabilisation_de_lexécution fiabilisation_de_lexécution_ ;
		public Fiabilisation_de_lexécution Fiabilisation_de_lexécution_ { get => fiabilisation_de_lexécution_; set => fiabilisation_de_lexécution_ = value; }

	}

    partial class Etat_métier
    {
		Génération_détat génération_détat_ ;
		public Génération_détat Génération_détat_ { get => génération_détat_; set => génération_détat_ = value; }

	}

    partial class Etat
    {
		Génération_détat génération_détat_ ;
		public Génération_détat Génération_détat_ { get => génération_détat_; set => génération_détat_ = value; }

	}

    partial class Métainformation
    {
		Relation relation_ ;
		public Relation Relation_ { get => relation_; set => relation_ = value; }

		Entité entité_ ;
		public Entité Entité_ { get => entité_; set => entité_ = value; }

	}

    partial class Périphérique
    {
		Gestion_des_objets_connectés gestion_des_objets_connectés_ ;
		public Gestion_des_objets_connectés Gestion_des_objets_connectés_ { get => gestion_des_objets_connectés_; set => gestion_des_objets_connectés_ = value; }

	}

    partial class IContainerControl
    {
		Container_graphique container_graphique_ ;
		public Container_graphique Container_graphique_ { get => container_graphique_; set => container_graphique_ = value; }

	}

    partial class IControl
    {
		Widget widget_ ;
		public Widget Widget_ { get => widget_; set => widget_ = value; }

	}

    partial class IHelpSrv
    {
		Aide_contextuelle aide_contextuelle_ ;
		public Aide_contextuelle Aide_contextuelle_ { get => aide_contextuelle_; set => aide_contextuelle_ = value; }

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

    partial class Client_lourd_gestion_accueil
    {
		Modèle_métier_partagé modèle_métier_partagé_ ;
		public Modèle_métier_partagé Modèle_métier_partagé_ { get => modèle_métier_partagé_; set => modèle_métier_partagé_ = value; }

	}

    partial class Modèle_métier_partagé
    {
		Services_applicatif services_applicatif_ ;
		public Services_applicatif Services_applicatif_ { get => services_applicatif_; set => services_applicatif_ = value; }

	}

}

