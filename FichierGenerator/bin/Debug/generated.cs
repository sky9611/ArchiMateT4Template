




using System.Collections.Generic;

using Maidis.VNext.Domaine_métier;
using Maidis.VNext.Patient;
using Maidis.VNext.Examen;
using Maidis.VNext.Patient;
using Maidis.VNext.Consultation;
using Maidis.VNext.Personne;

namespace Maidis.VNext.Grouping
{
}

namespace Maidis.VNext.ASIP_Santé
{

	[ModelElement("PortailDMP","", ElementType = "ApplicationComponentArchimate")]
	partial class PortailDMP : Component
	{
	}

}

namespace Maidis.VNext.Technologie__NET
{

	[ModelElement("Container VNext","", ElementType = "ApplicationComponentArchimate")]
	partial class Container_VNext : Component
	{
		Container_Amies container_Amies_ ;

	}


	[ModelElement("PersistanceExamen","gestion de la persistance du domaine examen", ElementType = "ApplicationComponentArchimate")]
	partial class PersistanceExamen : Component
	{
		Tbl_Examen tbl_Examen_ ;

	}


	[ModelElement("PersistanceRadiologie","gestion de la persistance des données radiologique", ElementType = "ApplicationComponentArchimate")]
	partial class PersistanceRadiologie : Component
	{
		Tbl_ExamenRadiologique tbl_ExamenRadiologique_ ;

	}


	[ModelElement("WorkflowAccueilPatient","cas d'utilisation de l'accueil du patient", ElementType = "ApplicationComponentArchimate")]
	partial class WorkflowAccueilPatient : Component
	{
		MessagePatient messagePatient_ ;

	}


	[ModelElement("PresentationAccueilPatientWeb","", ElementType = "ApplicationComponentArchimate")]
	partial class PresentationAccueilPatientWeb : Component
	{
	}


	[ModelElement("PresentationAccueilPatient","IHM de l'accueil patient", ElementType = "ApplicationComponentArchimate")]
	partial class PresentationAccueilPatient : Component
	{
	}


	[ModelElement("ServicePatient V2","service métier de gestion du patient", ElementType = "ApplicationComponentArchimate")]
	partial class ServicePatient_V2 : Component
	{
		InterfaceServicePatientV2 interfaceServicePatientV2_ ;

		ServeurPatient serveurPatient_ ;

	}

}

namespace Maidis.VNext.WPF
{

	[ModelElement("PresentationAccueilPatient","IHM de l'accueil patient", ElementType = "ApplicationComponentArchimate")]
	partial class PresentationAccueilPatient : Component
	{
	}

}

namespace Maidis.VNext.Domaine_métier
{

	[ModelElement("Composant applicatif","Une partie modulaire, déployable, et remplaçable d'un système logiciel qui encapsule son comportement et ses données et expose ceux-ci à travers un ensemble d'interfaces exemple: couche présentation tool consultation icône associé (propriété icon): - composition (puzzle-piece)", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_applicatif : Component
	{
	
		/icons/puzzle-piece.png icon;
		Message message_ ;

		Objet_données objet_données_ ;

	}

}

namespace Maidis.VNext.Partie_prenante
{
}

namespace Maidis.VNext.Valeurs_de_lentreprise
{
}

namespace Maidis.VNext.Financière
{
}

namespace Maidis.VNext.Interne
{
}

namespace Maidis.VNext.Apprentissage_et_Croissance
{
}

namespace Maidis.VNext.Messages_SOA
{

	[ModelElement("MessageConsultationExamen","", ElementType = "DataObjectArchimate")]
	partial class MessageConsultationExamen : DAO
	{
		List<Tbl_Examen> tbl_Examen_ ;
		List<Tbl_consultation> tbl_consultation_ ;
	}


	[ModelElement("MessagePatient","", ElementType = "DataObjectArchimate")]
	partial class MessagePatient : DAO
	{
		List<Tbl_consultation> tbl_consultation_ ;
		List<Tbl_Patient> tbl_Patient_ ;
		List<Tbl_Antecedent> tbl_Antecedent_ ;
	}

}

namespace Maidis.VNext.Comptabilité
{
}

namespace Maidis.VNext.Consultation
{
	public interface IUseCaseConsultation
	{
	}


	[ModelElement("UseCaseConsultation","pilotage des vues et services pour la gestion d'une consultation", ElementType = "ApplicationProcessArchimate")]
	partial class UseCaseConsultation : UseCaseWorkflow
	{
		IVue_consultation vue_consultation_ ;

	}


	[ModelElement("EConsultation","", ElementType = "BusinessObjectArchimate")]
	partial class EConsultation : IBusinessObject
	{
		Vue_consultation vue_consultation_ ;

		Examen examen_ ;

		PAConsultation pAConsultation_ ;

	}

	public interface IVue_consultation
	{
	}


	[ModelElement("Vue consultation","", ElementType = "RepresentationArchimate")]
	partial class Vue_consultation : Action_Consultation, IVue_consultation
	{
		IUseCaseConsultation useCaseConsultation;
		public	Vue_consultation(IWorkflow caller)
		{
			useCaseConsultation = caller as UseCaseConsultation;
		}
		EConsultation eConsultation_ ;

		Action_Consultation action_Consultation_ ;

	}

}

namespace Maidis.VNext.Examen
{
}

namespace Maidis.VNext.Patient
{
	public interface MenuDossierPatientID 
	{
	}

	[reference("Recherche d'un patient")]
	public interface DemandeRecherchePatient 
	{
	}

	public interface ISaisirNouveauPatient : IGererAccueilPatient
	{
	}

	public interface IVisualiserPatient : IGererAccueilPatient
	{
	}

	public interface ListerPatients 
	{
	}

	public interface RechercherPatients 
	{
	}

	public interface IGererAccueilPatient 
	{
	}

	public interface Button 
	{
	}

	public interface DemandeCreerPatient 
	{
	}

	public interface Action_Création 
	{
	}


	[ModelElement("EPatient","informations d'identification du patient et de ses caractéristiques", ElementType = "BusinessObjectArchimate")]
	partial class EPatient : EPersonne, IBusinessObject
	{
	
		Alphabétique Nom;
	
		Alphabétique Prenom;
	
		Date DateNaissance;
		List<Antécédent> antécédent_ = 
			new List<Antécédent>();
		List<EConsultation> eConsultation_ = 
			new List<EConsultation>();
		List<EContact> contacts_ ;
		ViewPatient viewPatient_ ;

		Vue_recherche_patient vue_recherche_patient_ ;

		PAPatient pAPatient_ ;

	}


	[ModelElement("EContact","contact du patient", ElementType = "BusinessObjectArchimate")]
	partial class EContact : EPersonne, IBusinessObject
	{
		PAContact pAContact_ ;

	}


	[ModelElement("ServiceGestionPatient","opération CRUD sur patient et associé", ElementType = "ApplicationServiceArchimate")]
	partial class ServiceGestionPatient : UseCaseWorkflow
	{
	}


	[ModelElement(""StartToolEvent"","", ElementType = "ApplicationEventArchimate")]
	partial class StartToolEvent : EventArgs
	{
	}

	public interface IViewPatient
	{
	}


	[ModelElement("ViewPatient","", ElementType = "RepresentationArchimate")]
	partial class ViewPatient : Button, IViewPatient
	{
		IUseCaseAccueilPatient workflowPatient;
		public	ViewPatient(IWorkflow caller)
		{
			workflowPatient = caller as UseCaseAccueilPatient;
		}
		EPatient enCours_ ;

		[reference("Action Création")]
		Button btnCreerPatient_ ;

		Vue_recherche_patient vue_recherche_patient_ ;

	}


	[ModelElement("PAPatient","", ElementType = "DataObjectArchimate")]
	partial class PAPatient : DAO
	{
		EPatient ePatient_ ;

		EPersonne ePersonne_ ;

	}

	public interface IUseCaseAccueilPatient
	{
	}


	[ModelElement("UseCaseAccueilPatient","pilotage des vues et services pour l'accueil d'un patient", ElementType = "ApplicationProcessArchimate")]
	partial class UseCaseAccueilPatient : IVisualiserPatient, ISaisirNouveauPatient, DemandeRecherchePatient, UseCaseWorkflow
	{
		IVisualiserPatient iVisualiserPatient_ ;

		ISaisirNouveauPatient iSaisirNouveauPatient_ ;

		DemandeRecherchePatient demandeRecherchePatient_ ;

		EPatient patientEnCours_ ;

		IVue_recherche_patient vue_recherche_patient_ ;

		IViewPatient vuePatient_ ;

	}

}

namespace Maidis.VNext.Dentaire
{

	[ModelElement("Acte Dentaire","", ElementType = "BusinessObjectArchimate")]
	partial class Acte_Dentaire : IBusinessObject
	{
		List<Produit_dentaire> produit_dentaire_ ;
		Acte_réalisé acte_réalisé_ ;

		Vue_gestion_acte vue_gestion_acte_ ;

	}


	[ModelElement("Famille","", ElementType = "BusinessObjectArchimate")]
	partial class Famille : IBusinessObject
	{
		List<Produit_dentaire> produit_dentaire_ = 
			new List<Produit_dentaire>();
		Vue_gestion_famille vue_gestion_famille_ ;

	}


	[ModelElement("Produit dentaire","", ElementType = "BusinessObjectArchimate")]
	partial class Produit_dentaire : IBusinessObject
	{
		Produit_utilisé produit_utilisé_ ;

		Vue_gestion_produit vue_gestion_produit_ ;

	}

	public interface ISaisie_acte_dentaire
	{
	}


	[ModelElement("Saisie acte dentaire","", ElementType = "RepresentationArchimate")]
	partial class Saisie_acte_dentaire : ISaisie_acte_dentaire
	{
		public	Saisie_acte_dentaire(IWorkflow caller)
		{
			 = caller as ;
		}
	}

	public interface IVue_gestion_acte
	{
	}


	[ModelElement("Vue gestion acte","", ElementType = "RepresentationArchimate")]
	partial class Vue_gestion_acte : IVue_gestion_acte
	{
		public	Vue_gestion_acte(IWorkflow caller)
		{
			 = caller as ;
		}
		Acte_Dentaire acte_Dentaire_ ;

	}

	public interface IVue_gestion_famille
	{
	}


	[ModelElement("Vue gestion famille","", ElementType = "RepresentationArchimate")]
	partial class Vue_gestion_famille : IVue_gestion_famille
	{
		public	Vue_gestion_famille(IWorkflow caller)
		{
			 = caller as ;
		}
		Famille famille_ ;

	}

	public interface IVue_gestion_lien_acte_produit__famille
	{
	}


	[ModelElement("Vue gestion lien acte -produit - famille","", ElementType = "RepresentationArchimate")]
	partial class Vue_gestion_lien_acte_produit__famille : IVue_gestion_lien_acte_produit__famille
	{
		public	Vue_gestion_lien_acte_produit__famille(IWorkflow caller)
		{
			 = caller as ;
		}
	}

	public interface IVue_gestion_produit
	{
	}


	[ModelElement("Vue gestion produit","", ElementType = "RepresentationArchimate")]
	partial class Vue_gestion_produit : IVue_gestion_produit
	{
		public	Vue_gestion_produit(IWorkflow caller)
		{
			 = caller as ;
		}
		Produit_dentaire produit_dentaire_ ;

	}

}

namespace Maidis.VNext.Consultation_dentaire
{

	[ModelElement("Acte réalisé","", ElementType = "BusinessObjectArchimate")]
	partial class Acte_réalisé : IBusinessObject
	{
		List<Produit_utilisé> produit_utilisé_ = 
			new List<Produit_utilisé>();
		Acte_Dentaire acte_Dentaire_ ;

	}


	[ModelElement("Produit utilisé","", ElementType = "BusinessObjectArchimate")]
	partial class Produit_utilisé : IBusinessObject
	{
		Produit_dentaire produit_dentaire_ ;

	}

}

namespace Maidis.VNext.Patient
{

	[ModelElement("Patient","", ElementType = "BusinessObjectArchimate")]
	partial class Patient : IBusinessObject
	{
		List<Acte_réalisé> acte_réalisé_ = 
			new List<Acte_réalisé>();
	}

}

namespace Maidis.VNext.Dossier_patient
{
}

namespace Maidis.VNext.Personne
{

	[ModelElement("EPersonne","", ElementType = "BusinessObjectArchimate")]
	partial class EPersonne : IBusinessObject
	{
		PAPatient pAPatient_ ;

		COCorresp cOCorresp_ ;

		PAContact pAContact_ ;

	}

}

namespace Maidis.VNext.Infrastructure
{

	[ModelElement("Plateforme Cloud Integration","plateforme Paas d'intégration de services", ElementType = "ApplicationComponentArchimate")]
	partial class Plateforme_Cloud_Integration : Component
	{
	}

}

namespace Maidis.VNext.Stratégies__Objectifs
{
}

namespace Maidis.VNext.Motivation
{
}

namespace Maidis.VNext.Information
{
}

namespace Maidis.VNext.Structure
{
}

namespace Maidis.VNext.Acteurs
{
}

namespace Maidis.VNext.Entrants_métier
{
	[reference("Processus métier")]
	[reference("Fonction métier")]
	public interface Interface_métier 
	{
	}


	[ModelElement("Contrat","Une spécification formelle ou informelle d'un accord qui précise les droits et obligations liés à un produit ou un service métier exemple: application du PMSI", ElementType = "ContractArchimate")]
	partial class Contrat : Interface_métier, CContract
	{
		List<Contrat> contrat_ ;
		Interface_métier interface_métier_ ;

	}

}

namespace Maidis.VNext.Projet
{
}

namespace Maidis.VNext.Traitements_métier
{
}

namespace Maidis.VNext.Structuration_métier
{

	[ModelElement("NomClasseMetier","Un élément passif d'information qui est pertinent d'un point de vue métier exemple: patient le nom et le type des attributs sont définis dans les propriétés de l'entité métier sous la forme \"att_\" plus le nom de l'attribut et le type pour valeur", ElementType = "BusinessObjectArchimate")]
	partial class NomClasseMetier : NomClasseMetier, IBusinessObject
	{
	
		typeAttribut nomAttribut;
		List<NomClasseMetier> entité_Base_ ;
		NomClasseVue nomClasseVue_ ;

		Objet_données objet_données_ ;

	}

	public interface INomClasseVue
	{
	}


	[ModelElement("NomClasseVue","élément perceptible (visible) associé aux entités métiers exemple: vue état-civil patient", ElementType = "RepresentationArchimate")]
	partial class NomClasseVue : NomClasseVue, Interface_applicative, Interface_IHM, Interface_métier, INomClasseVue
	{
	
		 Type;
		IScénario_de_test scénario_de_test;
		IProcessus_applicatif processus_applicatif;
		public	NomClasseVue(IWorkflow caller)
		{
			processus_applicatif = caller as Processus_applicatif;
		}
		[reference("Interface métier")]
		Interface_applicative interface_applicative_ ;

		Interface_IHM interface_IHM_ ;

		NomClasseEvenement_ou_NomMethodeEvenement nomClasseEvenement_ou_NomMethodeEvenement_ ;

		NomClasseMetier nomClasseMetier_ ;

		Interface_métier interface_métier_ ;

		NomClasseVue vue_Base_ ;

		NomClasseVue vue_Base_ ;

	}

}

namespace Maidis.VNext.Entrants_applicatif
{
	public interface Interface_applicative 
	{
	}


	[ModelElement("NomClasseEvenement ou NomMethodeEvenement","un comportement applicatif qui provoque un changement d'état exemple: réception d'un message \"mise à jour du dossier patient\" icône associé (propriété icon): - temporel: (calendar, clock-o, hourglass)", ElementType = "ApplicationEventArchimate")]
	partial class NomClasseEvenement_ou_NomMethodeEvenement : EventArgs
	{
		NomClasseVue nomClasseVue_ ;

	}


	[ModelElement("Service applicatif","Un service qui expose un comportement automatisé peut être associé à une fonctionnalité applicative exemple: gestion de la prise de rendez-vous", ElementType = "ApplicationServiceArchimate")]
	partial class Service_applicatif : UseCaseWorkflow
	{
		List<Service_applicatif> service_applicatif_ ;
		Contrat contrat_ ;

	}

}

namespace Maidis.VNext.Traitements_applicatifs
{
	public interface IProcessus_applicatif
	{
	}


	[ModelElement("Processus applicatif","suite de fonctions applicatives en vue de la réalisation d'un résultat. Peut intégrer des comportements non automatisés exemple: cas d'utilisation accueil consultation", ElementType = "ApplicationProcessArchimate")]
	partial class Processus_applicatif : UseCaseWorkflow
	{
		INomClasseVue workflow_ ;

		NomClasseMetier nomClasseMetier_ ;

	}

}

namespace Maidis.VNext.Structuration_applicative
{

	[ModelElement("Composant applicatif","Une partie modulaire, déployable, et remplaçable d'un système logiciel qui encapsule son comportement et ses données et expose ceux-ci à travers un ensemble d'interfaces exemple: couche présentation tool consultation icône associé (propriété icon): - composition (puzzle-piece)", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_applicatif : Component
	{
	
		/icons/puzzle-piece.png icon;
		Message message_ ;

		Objet_données objet_données_ ;

	}


	[ModelElement("Objet données","Un élément passif adapté pour le traitement automatisé, stockant des informations exemple: table Patient", ElementType = "DataObjectArchimate")]
	partial class Objet_données : DAO
	{
		List<Objet_données> objet_données_ ;
		Objet_données objet_données_ ;

		Objet_données objet_données_ ;

		NomClasseMetier nomClasseMetier_ ;

	}

}

namespace Maidis.VNext.Entrants_technologique
{
	public interface Interface_dinfrastructure 
	{
	}

}

namespace Maidis.VNext.Traitements_technologique
{
}

namespace Maidis.VNext.Structuration_technique
{
}

namespace Maidis.VNext.Matériel
{
}

namespace Maidis.VNext.Sécurité
{
}

namespace Maidis.VNext.Gestion_déploiement
{
}

namespace Maidis.VNext.Unconnu
{
	public interface WebServiceCassiopee 
	{
	}

	public interface GererContainer 
	{
	}

	public interface CreerConsultation 
	{
	}

	public interface CreerConsultationPlanifiee 
	{
	}

	public interface ObtenirHistorique 
	{
	}

	public interface Web_service 
	{
	}

	public interface REST_BPMN 
	{
	}

	public interface ODBC 
	{
	}

	public interface Port_HTTPS_Web 
	{
	}

	public interface SaisieCriteresRecherchePatient 
	{
	}

	public interface SaisieConsultation 
	{
	}

	public interface PlanifierConsultation 
	{
	}

	public interface Interface__Interface 
	{
	}

	public interface CréerEntité 
	{
	}

	public interface ModifierEntité 
	{
	}

	public interface SupprimerEntité 
	{
	}

	public interface RechercherEntités 
	{
	}

	public interface LireEntité 
	{
	}

	public interface ChoisirEntité 
	{
	}

	public interface ValiderEntité 
	{
	}

	public interface Initialiser_Recherche 
	{
	}

	public interface AfficherEntité 
	{
	}

	public interface AfficherListeEntités 
	{
	}

	public interface PersisterEntité 
	{
	}

	public interface GererInformationsExamen 
	{
	}

	public interface GererInformationsRadiologie 
	{
	}

	public interface InitialiserDonneesExamen 
	{
	}

	public interface GérerPersonne 
	{
	}

	public interface GererProfessionnel 
	{
	}

	public interface LinQ 
	{
	}

	[reference("Accueil d'un patient")]
	public interface Application_cliente_Maidina 
	{
	}

	[reference("Gérer les actes dentaires")]
	public interface Application_administration 
	{
	}

	[reference("Gestion CRUD acte")]
	public interface Menu_gestion_des_actes 
	{
	}

	[reference("Gestion CRUD produit")]
	public interface Menu_gestion_des_produits 
	{
	}

	[reference("Gestion CRUD famille")]
	public interface Menu_gestion_famille 
	{
	}

	public interface GererVueContainer 
	{
	}

	public interface DMP 
	{
	}

	public interface Email 
	{
	}

	public interface Portail_Hapicare 
	{
	}

	public interface WSGererActeDentaire 
	{
	}

	public interface WSGererAffectationProduit 
	{
	}

	public interface WSGererFamille 
	{
	}

	public interface WSGererProduit 
	{
	}

	public interface WSRealiserActeDentaire 
	{
	}

	public interface Menu_prescrire_un_soin_dentaire 
	{
	}

	public interface Menu_gestion_actes_dentaire 
	{
	}

	public interface WSAccederActeDentaire 
	{
	}

	public interface WSAccederFamille 
	{
	}

	public interface WSAccederProduit 
	{
	}

	public interface Interface_IHM 
	{
	}

	public interface MenuGestionDroits 
	{
	}

	public interface BoutonRechercherPatients 
	{
	}

	public interface BoutonValider 
	{
	}

	public interface Action_Consultation 
	{
	}

	public interface Action_Rendezvous 
	{
	}

	public interface Action_Recherche 
	{
	}

	public interface BoutonSelectionnerPatient 
	{
	}

	public interface BoutonSupprimer 
	{
	}

	public interface BoutonAnnuler 
	{
	}

	public interface BoutonFermer 
	{
	}

	public interface BoutonCreer 
	{
	}

	public interface ITechnicalFonctionality 
	{
	}

	public interface Interface_fonctionnalité_IfonctionnaliteFct : ITechnicalFonctionality
	{
	}

	public interface IObjectLayer 
	{
	}

	public interface ILayer 
	{
	}

	public interface Interface_implémentationIServiceSrv 
	{
	}

	public interface API 
	{
	}

	public interface OMI 
	{
	}

	public interface Sockets 
	{
	}

	public interface Sockets_v2 
	{
	}


	[ModelElement("Gestion examen","opération CRUD sur examen et associé", ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_examen : UseCaseWorkflow
	{
	}


	[ModelElement("Accès dossier patient DMP","", ElementType = "ApplicationServiceArchimate")]
	partial class Accès_dossier_patient_DMP : UseCaseWorkflow
	{
	}


	[ModelElement("Tool Accueil Patient","", ElementType = "ApplicationComponentArchimate")]
	partial class Tool_Accueil_Patient : Component
	{
		Tbl_consultation tbl_consultation_ ;

	}


	[ModelElement("DataServer","", ElementType = "ApplicationComponentArchimate")]
	partial class DataServer : Component
	{
	}


	[ModelElement("PersistancePatient","gestion de la persistance du domaine patient", ElementType = "ApplicationComponentArchimate")]
	partial class PersistancePatient : Component
	{
		Tbl_Patient tbl_Patient_ ;

		Tbl_Contact tbl_Contact_ ;

		Tbl_Antecedent tbl_Antecedent_ ;

	}


	[ModelElement("EntitePatient","modèle d'entités du service patient", ElementType = "ApplicationComponentArchimate")]
	partial class EntitePatient : Component
	{
		EPatient ePatient_ ;

	}


	[ModelElement("Container Amies","", ElementType = "ApplicationComponentArchimate")]
	partial class Container_Amies : Component
	{
		List<Tool_Examen> tool_Examen_ ;
		Container_VNext container_VNext_ ;

	}


	[ModelElement("ServicePatient","", ElementType = "ApplicationComponentArchimate")]
	partial class ServicePatient : Component
	{
	}


	[ModelElement("PersistanceConsultation","gestion de la persistance du domaine consultation", ElementType = "ApplicationComponentArchimate")]
	partial class PersistanceConsultation : Component
	{
		Tbl_consultation tbl_consultation_ ;

	}


	[ModelElement("ServiceConsultation","service métier de gestion des consultations", ElementType = "ApplicationComponentArchimate")]
	partial class ServiceConsultation : Component
	{
	}


	[ModelElement("PresentationEntreeService","IHM de l'entrée dans un service en vue de la planification d'examen", ElementType = "ApplicationComponentArchimate")]
	partial class PresentationEntreeService : Component
	{
	}


	[ModelElement("PresentationRadiologie","IHM de réalisation des examens de radiologie", ElementType = "ApplicationComponentArchimate")]
	partial class PresentationRadiologie : Component
	{
	}


	[ModelElement("WorkflowRadiologie","cas d'utilisation de la gestion du service radiologie", ElementType = "ApplicationComponentArchimate")]
	partial class WorkflowRadiologie : Component
	{
	}


	[ModelElement("WorkflowServiceMedical","cas d'utilisation de gestion du service médical", ElementType = "ApplicationComponentArchimate")]
	partial class WorkflowServiceMedical : Component
	{
	}


	[ModelElement("dsModel","", ElementType = "ApplicationComponentArchimate")]
	partial class DsModel : Component
	{
	}


	[ModelElement("EntiteConsultation","modèle d'entités de la gestion des consultations", ElementType = "ApplicationComponentArchimate")]
	partial class EntiteConsultation : Component
	{
	}


	[ModelElement("Tbl_consultation","", ElementType = "DataObjectArchimate")]
	partial class Tbl_consultation : DAO
	{
	}


	[ModelElement("Gestion consultation","opération CRUD sur consultation et associé", ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_consultation : UseCaseWorkflow
	{
		PMSI pMSI_ ;

	}

	public interface IVue_container_Vnext
	{
	}


	[ModelElement("Vue container Vnext","", ElementType = "RepresentationArchimate")]
	partial class Vue_container_Vnext : MenuDossierPatientID, MenuGestionDroits, IVue_container_Vnext
	{
		IScénario_Accueil_dun_patient scénario_Accueil_dun_patient;
		IAccès_aux_fonctionnalités_partagées accès_aux_fonctionnalités_partagées;
		IScénario_administration_des_droits_des_patients scénario_administration_des_droits_des_patients;
		public	Vue_container_Vnext(IWorkflow caller)
		{
			scénario_administration_des_droits_des_patients = caller as Scénario_administration_des_droits_des_patients;
		}
		List<Vue_tool_patient> vue_tool_patient_ ;
		List<Vue_tool_rendezvous> vue_tool_rendezvous_ ;
		MenuDossierPatientID menuDossierPatientID_ ;

		MenuGestionDroits menuGestionDroits_ ;

	}


	[ModelElement("Tool Accueil Patient V2","", ElementType = "ApplicationComponentArchimate")]
	partial class Tool_Accueil_Patient_V2 : Component
	{
		List<WorkflowConsultation> workflowConsultation_ = 
			new List<WorkflowConsultation>();
		List<PresentationAccueilPatient> presentationAccueilPatient_ = 
			new List<PresentationAccueilPatient>();
		List<WorkflowAccueilPatient> workflowAccueilPatient_ = 
			new List<WorkflowAccueilPatient>();
	}


	[ModelElement("ServeurPatient","composant réutilisable de gestion du patient", ElementType = "ApplicationComponentArchimate")]
	partial class ServeurPatient : Component
	{
		List<PersistancePatient> persistancePatient_ = 
			new List<PersistancePatient>();
		List<ServicePatient_V2> servicePatient_V2_ ;
		List<ServicePatient> servicePatient_ ;
		List<PersistanceConsultation> persistanceConsultation_ ;
		List<ServiceConsultation> serviceConsultation_ ;
		List<ServicePersonne> servicePersonne_ ;
		List<PersistancePersonne> persistancePersonne_ ;
		List<PersistanceNomenclature> persistanceNomenclature_ ;
		List<ServiceNomenclature> serviceNomenclature_ ;
		ServicePatient_V2 servicePatient_V2_ ;

	}


	[ModelElement("Tool Examen","", ElementType = "ApplicationComponentArchimate")]
	partial class Tool_Examen : Component
	{
	}


	[ModelElement("Anomalie applicative","évènement non désiré provoqué par une erreur applicative", ElementType = "ApplicationEventArchimate")]
	partial class Anomalie_applicative : NomClasseEvenement_ou_NomMethodeEvenement, EventArgs
	{
	}

	public interface IWorkflowtraitementCRUDEntite
	{
	}


	[ModelElement("workflow:traitementCRUDEntite","", ElementType = "ApplicationProcessArchimate")]
	partial class WorkflowtraitementCRUDEntite : UseCaseWorkflow
	{
	}


	[ModelElement("Message d'erreur technique","", ElementType = "ApplicationEventArchimate")]
	partial class Message_derreur_technique : EventArgs
	{
	}


	[ModelElement("Professionnel Agree RPPS","professionnel identifié par un numéro unique présent dans le répertoire partagé des professionnels intervenant dans le système de santé", ElementType = "ContractArchimate")]
	partial class Professionnel_Agree_RPPS : CContract
	{
	}


	[ModelElement("PMSI","", ElementType = "ContractArchimate")]
	partial class PMSI : CContract
	{
	}


	[ModelElement("Gestion CRUD nomenclatures","", ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_CRUD_nomenclatures : UseCaseWorkflow
	{
	}


	[ModelElement("PersistanceNomenclature","", ElementType = "ApplicationComponentArchimate")]
	partial class PersistanceNomenclature : Component
	{
	}


	[ModelElement("ServiceNomenclature","", ElementType = "ApplicationComponentArchimate")]
	partial class ServiceNomenclature : Component
	{
	}

	public interface ICas_dutilisation_accueil_dans_Service
	{
	}


	[ModelElement("Cas d'utilisation accueil dans Service","pilotage des vues et services pour l'accueil d'un patient dans un service", ElementType = "ApplicationProcessArchimate")]
	partial class Cas_dutilisation_accueil_dans_Service : UseCaseWorkflow
	{
	}


	[ModelElement("ServicePersonne","", ElementType = "ApplicationComponentArchimate")]
	partial class ServicePersonne : Component
	{
	}


	[ModelElement("PersistancePersonne","", ElementType = "ApplicationComponentArchimate")]
	partial class PersistancePersonne : Component
	{
		Tbl_Personne tbl_Personne_ ;

		Tbl_Professionnel tbl_Professionnel_ ;

	}


	[ModelElement("WorkflowConsultation","", ElementType = "ApplicationComponentArchimate")]
	partial class WorkflowConsultation : Component
	{
	}


	[ModelElement("InterfaceServicePatientV2","", ElementType = "ApplicationComponentArchimate")]
	partial class InterfaceServicePatientV2 : Component
	{
		ServicePatient_V2 servicePatient_V2_ ;

	}


	[ModelElement("Examen","", ElementType = "BusinessObjectArchimate")]
	partial class Examen : IBusinessObject
	{
		EConsultation eConsultation_ ;

		PAMedicalItem pAMedicalItem_ ;

	}


	[ModelElement("Antécédent","", ElementType = "BusinessObjectArchimate")]
	partial class Antécédent : IBusinessObject
	{
		PAMedicalItem pAMedicalItem_ ;

	}


	[ModelElement("Professionnel","", ElementType = "BusinessObjectArchimate")]
	partial class Professionnel : EPersonne, IBusinessObject
	{
		COCorresp cOCorresp_ ;

	}


	[ModelElement("Tbl_ExamenRadiologique","", ElementType = "DataObjectArchimate")]
	partial class Tbl_ExamenRadiologique : Tbl_Examen, DAO
	{
	}


	[ModelElement("Tbl_Examen","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Examen : DAO
	{
	}


	[ModelElement("Tbl_Patient","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Patient : Tbl_Personne, DAO
	{
		List<Tbl_Antecedent> tbl_Antecedent_ = 
			new List<Tbl_Antecedent>();
		List<Tbl_consultation> tbl_consultation_ = 
			new List<Tbl_consultation>();
	}


	[ModelElement("Tbl_Antecedent","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Antecedent : DAO
	{
	}


	[ModelElement("Tbl_Contact","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Contact : Tbl_Personne, DAO
	{
	}


	[ModelElement("Tbl_Personne","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Personne : DAO
	{
	}


	[ModelElement("Tbl_Professionnel","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Professionnel : Tbl_Personne, DAO
	{
	}


	[ModelElement("COCorresp","", ElementType = "DataObjectArchimate")]
	partial class COCorresp : DAO
	{
		Professionnel professionnel_ ;

		EPersonne ePersonne_ ;

	}


	[ModelElement("PAContact","", ElementType = "DataObjectArchimate")]
	partial class PAContact : DAO
	{
		TblPersonne tblPersonne_ ;

		EContact eContact_ ;

		EPersonne ePersonne_ ;

	}


	[ModelElement("PAConsultation","", ElementType = "DataObjectArchimate")]
	partial class PAConsultation : DAO
	{
		EConsultation eConsultation_ ;

		TblConsultation tblConsultation_ ;

	}


	[ModelElement("PAMedicalItem","", ElementType = "DataObjectArchimate")]
	partial class PAMedicalItem : DAO
	{
		Examen examen_ ;

		Antécédent antécédent_ ;

	}


	[ModelElement("TblConsultation","", ElementType = "DataObjectArchimate")]
	partial class TblConsultation : DAO
	{
		PAConsultation pAConsultation_ ;

	}


	[ModelElement("TblPatient","", ElementType = "DataObjectArchimate")]
	partial class TblPatient : DAO
	{
	}


	[ModelElement("TblPersonne","", ElementType = "DataObjectArchimate")]
	partial class TblPersonne : DAO
	{
		PAContact pAContact_ ;

	}


	[ModelElement("Tbl_Contact","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Contact : DAO
	{
	}


	[ModelElement("Licence VNextSrv n°2314","", ElementType = "ContractArchimate")]
	partial class Licence_VNextSrv_n2314 : CContract
	{
		Licence_VNext_n57869 licence_VNext_n57869_ ;

	}


	[ModelElement("Licence VNext n°2420","", ElementType = "ContractArchimate")]
	partial class Licence_VNext_n2420 : CContract
	{
	}


	[ModelElement("Licence VNext n°57869","", ElementType = "ContractArchimate")]
	partial class Licence_VNext_n57869 : CContract
	{
		Licence_VNextSrv_n2314 licence_VNextSrv_n2314_ ;

	}


	[ModelElement("Microsoft n°3683-JFZO-ZZ80","", ElementType = "ContractArchimate")]
	partial class Microsoft_n3683JFZOZZ80 : CContract
	{
	}


	[ModelElement("Licence","Un contrat particulier qui spécifie les conditions dans lesquelles le programme associé peut être utilisé, diffusé ou modifié.", ElementType = "ContractArchimate")]
	partial class Licence : Contrat, CContract
	{
	}


	[ModelElement("Aucune information affichée","", ElementType = "ApplicationEventArchimate")]
	partial class Aucune_information_affichée : EventArgs
	{
	}

	public interface IScénario_administration_des_droits_des_patients
	{
	}


	[ModelElement("Scénario administration des droits des patients","", ElementType = "ApplicationProcessArchimate")]
	partial class Scénario_administration_des_droits_des_patients : Cas_dutilisation_administration_des_droits_du_patient, UseCaseWorkflow
	{
		IVue_container_Vnext vue_container_Vnext_ ;

	}

	public interface ICas_dutilisation_administration_des_droits_du_patient
	{
	}


	[ModelElement("Cas d'utilisation administration des droits du patient","", ElementType = "ApplicationProcessArchimate")]
	partial class Cas_dutilisation_administration_des_droits_du_patient : UseCaseWorkflow
	{
	}

	public interface IScénario_de_test
	{
	}


	[ModelElement("Scénario de test","décrit le scénario de test, associé à un processus ou une fonction applicative", ElementType = "ApplicationProcessArchimate")]
	partial class Scénario_de_test : Grouping, UseCaseWorkflow
	{
		INomClasseVue nomClasseVue_ ;

	}

	public interface IProcessus_testé
	{
	}


	[ModelElement("Processus testé","Processus appelé par un scénario de test", ElementType = "ApplicationProcessArchimate")]
	partial class Processus_testé : UseCaseWorkflow
	{
	}


	[ModelElement("Message","objet de données associés aux messages entre composants applicatifs peut être persistant pour des raisons d'optimisation: cache...", ElementType = "DataObjectArchimate")]
	partial class Message : DAO
	{
		List<Objet_données> objet_données_ ;
	}


	[ModelElement("ServiceExamen","service métier de gestion des examens", ElementType = "ApplicationComponentArchimate")]
	partial class ServiceExamen : Component
	{
	}


	[ModelElement("ServiceRadiologie","service métier de gestion de la radiologie", ElementType = "ApplicationComponentArchimate")]
	partial class ServiceRadiologie : Component
	{
	}

	public interface IProcessus_Migration
	{
	}


	[ModelElement("Processus Migration","", ElementType = "ApplicationProcessArchimate")]
	partial class Processus_Migration : UseCaseWorkflow
	{
	}


	[ModelElement("évènement : Evènement","", ElementType = "ApplicationEventArchimate")]
	partial class Évènement__Evènement : EventArgs
	{
	}


	[ModelElement("entité:Entité métier","", ElementType = "BusinessObjectArchimate")]
	partial class EntitéEntité_métier : IBusinessObject
	{
	}

	public interface IVue_Vue
	{
	}


	[ModelElement("vue: Vue","", ElementType = "RepresentationArchimate")]
	partial class Vue_Vue : IVue_Vue
	{
		public	Vue_Vue(IWorkflow caller)
		{
			 = caller as ;
		}
	}

	public interface IProcessus__Processus
	{
	}


	[ModelElement("processus : Processus","", ElementType = "ApplicationProcessArchimate")]
	partial class Processus__Processus : UseCaseWorkflow
	{
	}


	[ModelElement("composant: Composant","", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_Composant : Component
	{
	}


	[ModelElement("service : Service","", ElementType = "ApplicationServiceArchimate")]
	partial class Service__Service : UseCaseWorkflow
	{
	}


	[ModelElement("données :Donnée Entité","", ElementType = "DataObjectArchimate")]
	partial class Données_Donnée_Entité : DAO
	{
	}


	[ModelElement("couche entité","", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_entité : Component
	{
		NomClasseMetier nomClasseMetier_ ;

	}


	[ModelElement("couche présentation","", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_présentation : Component
	{
	}

	public interface IVueEntitéVue_entité_complète
	{
	}


	[ModelElement("vueEntité:Vue entité complète","", ElementType = "RepresentationArchimate")]
	partial class VueEntitéVue_entité_complète : IVueEntitéVue_entité_complète
	{
		public	VueEntitéVue_entité_complète(IWorkflow caller)
		{
			 = caller as ;
		}
	}

	public interface IVueListeVue_Liste_entités
	{
	}


	[ModelElement("vueListe:Vue Liste entités","", ElementType = "RepresentationArchimate")]
	partial class VueListeVue_Liste_entités : IVueListeVue_Liste_entités
	{
		public	VueListeVue_Liste_entités(IWorkflow caller)
		{
			 = caller as ;
		}
	}


	[ModelElement("couche workflow","", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_workflow : Component
	{
	}


	[ModelElement("interface couche service","", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_couche_service : Component
	{
	}


	[ModelElement("interface couche workflow","", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_couche_workflow : Component
	{
	}


	[ModelElement("couche service","", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_service : Component
	{
	}


	[ModelElement("interface couche persistance","", ElementType = "ApplicationComponentArchimate")]
	partial class Interface_couche_persistance : Component
	{
	}


	[ModelElement("couche persistance","", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_persistance : Component
	{
	}


	[ModelElement("déclenchement du pattern","", ElementType = "ApplicationEventArchimate")]
	partial class Déclenchement_du_pattern : EventArgs
	{
	}

	public interface IMigrationTransformation_CRUD
	{
	}


	[ModelElement("<<migration>>Transformation CRUD","", ElementType = "ApplicationProcessArchimate")]
	partial class MigrationTransformation_CRUD : UseCaseWorkflow
	{
	}


	[ModelElement("1 er jour du mois","", ElementType = "ApplicationEventArchimate")]
	partial class 1_er_jour_du_mois : EventArgs
	{
	}


	[ModelElement("ADF.Common","", ElementType = "ApplicationComponentArchimate")]
	partial class ADF_Common : Component
	{
	}


	[ModelElement("ADF.Persistance","", ElementType = "ApplicationComponentArchimate")]
	partial class ADF_Persistance : Component
	{
	}

	public interface ICas_dutilisation_Contact
	{
	}


	[ModelElement("Cas d'utilisation Contact","", ElementType = "ApplicationProcessArchimate")]
	partial class Cas_dutilisation_Contact : UseCaseWorkflow
	{
		IVue_liste_contact vue_liste_contact_ ;

	}

	public interface IAccès_aux_fonctionnalités_partagées
	{
	}


	[ModelElement("Accès aux fonctionnalités partagées","", ElementType = "ApplicationProcessArchimate")]
	partial class Accès_aux_fonctionnalités_partagées : UseCaseWorkflow
	{
		IVue_container_Vnext vue_container_Vnext_ ;

	}


	[ModelElement("Gestion données contact","", ElementType = "ApplicationServiceArchimate")]
	partial class Gestion_données_contact : UseCaseWorkflow
	{
	}

	public interface IVue_recherche_patient
	{
	}


	[ModelElement("Vue recherche patient","saisie des informations de critères de recherche (!vueRecherchePatient.png) - nom: texte(30), obligatoire - prenom: texte(30), optionnel - code postal:numerique(6), optionnel - date de naissance: date, obligatoire", ElementType = "RepresentationArchimate")]
	partial class Vue_recherche_patient : Action_Recherche, IVue_recherche_patient
	{
		IUseCaseAccueilPatient useCaseAccueilPatient;
		public	Vue_recherche_patient(IWorkflow caller)
		{
			useCaseAccueilPatient = caller as UseCaseAccueilPatient;
		}
		EPatient ePatient_ ;

		Action_Recherche action_Recherche_ ;

		ViewPatient viewPatient_ ;

	}

	public interface IVue_liste_contact
	{
	}


	[ModelElement("Vue liste contact","", ElementType = "RepresentationArchimate")]
	partial class Vue_liste_contact : IVue_liste_contact
	{
		ICas_dutilisation_Contact cas_dutilisation_Contact;
		public	Vue_liste_contact(IWorkflow caller)
		{
			cas_dutilisation_Contact = caller as Cas_dutilisation_Contact;
		}
	}

	public interface ICas_dutilisation_gestion_actes
	{
	}


	[ModelElement("cas d'utilisation gestion actes","", ElementType = "ApplicationProcessArchimate")]
	partial class Cas_dutilisation_gestion_actes : UseCaseWorkflow
	{
	}

	public interface ICas_dutilisation_réalisation_acte_dentaire
	{
	}


	[ModelElement("cas d'utilisation réalisation acte dentaire","", ElementType = "ApplicationProcessArchimate")]
	partial class Cas_dutilisation_réalisation_acte_dentaire : UseCaseWorkflow
	{
	}


	[ModelElement("Tbl_ActeDentaire","", ElementType = "DataObjectArchimate")]
	partial class Tbl_ActeDentaire : DAO
	{
	}


	[ModelElement("Tbl_Famille","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Famille : DAO
	{
	}


	[ModelElement("Tbl_Produit","", ElementType = "DataObjectArchimate")]
	partial class Tbl_Produit : DAO
	{
	}


	[ModelElement("Tbl_ActeRealise","", ElementType = "DataObjectArchimate")]
	partial class Tbl_ActeRealise : DAO
	{
	}

	public interface ICas_dutilisation_déroulement_radio
	{
	}


	[ModelElement("Cas d'utilisation déroulement radio","pilotage des vues et services pour l'exécution de la radio application purement orientée médecin de pilotage d'appareil", ElementType = "ApplicationProcessArchimate")]
	partial class Cas_dutilisation_déroulement_radio : UseCaseWorkflow
	{
	}

	public interface ICas_dutilisation_préparation_radio
	{
	}


	[ModelElement("Cas d'utilisation préparation radio","pilotage des vues et services pour la préparation d'une radio gère un dialogue avec un patient", ElementType = "ApplicationProcessArchimate")]
	partial class Cas_dutilisation_préparation_radio : UseCaseWorkflow
	{
	}


	[ModelElement("Evènement de terminaison de test","évènement de terminaison de test attendu", ElementType = "ApplicationEventArchimate")]
	partial class Evènement_de_terminaison_de_test : EventArgs
	{
	}


	[ModelElement("Tool Gestion des droits","", ElementType = "ApplicationComponentArchimate")]
	partial class Tool_Gestion_des_droits : Component
	{
	}

	public interface IVue_gestion_des_droits
	{
	}


	[ModelElement("Vue gestion des droits","", ElementType = "RepresentationArchimate")]
	partial class Vue_gestion_des_droits : IVue_gestion_des_droits
	{
		public	Vue_gestion_des_droits(IWorkflow caller)
		{
			 = caller as ;
		}
	}

	public interface IScénario_Accueil_dun_patient_externe
	{
	}


	[ModelElement("Scénario Accueil d'un patient externe","", ElementType = "ApplicationProcessArchimate")]
	partial class Scénario_Accueil_dun_patient_externe : UseCaseWorkflow
	{
	}

	public interface IScénario_Accueil_dun_patient
	{
	}


	[ModelElement("Scénario Accueil d'un patient","", ElementType = "ApplicationProcessArchimate")]
	partial class Scénario_Accueil_dun_patient : UseCaseWorkflow
	{
		IVue_container_Vnext vue_container_Vnext_ ;

	}


	[ModelElement("Licence Amies n°22338","", ElementType = "ContractArchimate")]
	partial class Licence_Amies_n22338 : CContract
	{
	}

	public interface IVue_contact
	{
	}


	[ModelElement("Vue contact","", ElementType = "RepresentationArchimate")]
	partial class Vue_contact : IVue_contact
	{
		public	Vue_contact(IWorkflow caller)
		{
			 = caller as ;
		}
	}


	[ModelElement("Modeleur Archimate","outil de modélisation", ElementType = "ApplicationComponentArchimate")]
	partial class Modeleur_Archimate : Component
	{
	}


	[ModelElement("Compilateur/editeur","", ElementType = "ApplicationComponentArchimate")]
	partial class Compilateurediteur : Component
	{
	}

	public interface IMontée_en_charge_Accueil_patient
	{
	}


	[ModelElement("montée en charge Accueil patient","", ElementType = "ApplicationProcessArchimate")]
	partial class Montée_en_charge_Accueil_patient : UseCaseWorkflow
	{
	}

	public interface IVue_tool_patient
	{
	}


	[ModelElement("Vue tool patient","", ElementType = "RepresentationArchimate")]
	partial class Vue_tool_patient : IVue_tool_patient
	{
		public	Vue_tool_patient(IWorkflow caller)
		{
			 = caller as ;
		}
	}

	public interface IVue_tool_rendezvous
	{
	}


	[ModelElement("Vue tool rendez-vous","", ElementType = "RepresentationArchimate")]
	partial class Vue_tool_rendezvous : IVue_tool_rendezvous
	{
		public	Vue_tool_rendezvous(IWorkflow caller)
		{
			 = caller as ;
		}
	}

	public interface IVue_prise_de_rendezvous
	{
	}


	[ModelElement("Vue prise de rendez-vous","", ElementType = "RepresentationArchimate")]
	partial class Vue_prise_de_rendezvous : Action_Rendezvous, IVue_prise_de_rendezvous
	{
		public	Vue_prise_de_rendezvous(IWorkflow caller)
		{
			 = caller as ;
		}
		Action_Rendezvous action_Rendezvous_ ;

	}

	public interface IVue_Gestion_Nomenclature
	{
	}


	[ModelElement("Vue Gestion Nomenclature","", ElementType = "RepresentationArchimate")]
	partial class Vue_Gestion_Nomenclature : IVue_Gestion_Nomenclature
	{
		public	Vue_Gestion_Nomenclature(IWorkflow caller)
		{
			 = caller as ;
		}
	}


	[ModelElement("Patient Modifié","", ElementType = "ApplicationEventArchimate")]
	partial class Patient_Modifié : EventArgs
	{
	}


	[ModelElement("Patient Supprimé","", ElementType = "ApplicationEventArchimate")]
	partial class Patient_Supprimé : EventArgs
	{
	}


	[ModelElement("Fin","fin du test, sans information sur sa réussite ou son échec", ElementType = "ApplicationEventArchimate")]
	partial class Fin : Evènement_de_terminaison_de_test, EventArgs
	{
	}


	[ModelElement("Patient crée","le patient a été crée", ElementType = "ApplicationEventArchimate")]
	partial class Patient_crée : EventArgs
	{
	}


	[ModelElement("Aucun changement","indique que l'action en cours ne doit pas provoquer de changement de l'état de l'application", ElementType = "ApplicationEventArchimate")]
	partial class Aucun_changement : EventArgs
	{
	}


	[ModelElement("couche commune","", ElementType = "ApplicationComponentArchimate")]
	partial class Couche_commune : Component
	{
	}


	[ModelElement("ImplementationFacade","gestion d'un ensemble de singletons: structuration, accès concurrent", ElementType = "DataObjectArchimate")]
	partial class ImplementationFacade : DAO
	{
	}


	[ModelElement("Facade<T>","singleton typé", ElementType = "DataObjectArchimate")]
	partial class FacadeT : ImplementationFacade, DAO
	{
	}


	[ModelElement("CManager","gestion de l'accès aux fonctionnalités selon la couche retourne, pour un objet d'une couche donnée, la fonctionnalité qui va être utilisé par exemple, en donnant en paramètre un objet de la couche service, le Manager de log va retourner la fonctionnalité de log de la couche service (par exemple, dans une base de données distante)", ElementType = "DataObjectArchimate")]
	partial class CManager : IObjectLayer, ITechnicalFonctionality, DAO
	{
		IObjectLayer currentObjectConcerned_ ;

		ITechnicalFonctionality implementations_ ;

	}


	[ModelElement("CLayerMgr","", ElementType = "DataObjectArchimate")]
	partial class CLayerMgr : DAO
	{
	}


	[ModelElement("CLayer","", ElementType = "DataObjectArchimate")]
	partial class CLayer : FacadeT, ILayer, DAO
	{
		ILayer iLayer_ ;

	}


	[ModelElement("manager:ManagerMgr","classe d'implémentation d'un manager typage du traitement d'un manager spécifiquement pour la fonctionnalité associé", ElementType = "DataObjectArchimate")]
	partial class ManagerManagerMgr : CManager, ITechnicalFonctionality, DAO
	{
		ITechnicalFonctionality iTechnicalFonctionality_ ;

	}


	[ModelElement("CTechnicalFonctionality","mécanismes communs à l'implémentation d'une fonctionnalité technique gère l'accès dynamique à l'implémentation concrète de la fonctionnalité: par exemple, dans le cas de l'implémentation sous la forme d'un service, fait un appel dynamique au service", ElementType = "DataObjectArchimate")]
	partial class CTechnicalFonctionality : DAO
	{
	}


	[ModelElement("fonctionnalité: FonctionnaliteFct","classe d'implémentation de la fonctionnalité gère l'état des objets de la fonctionnalité, par exemple une référence à un log gère les traitements de la fonctionnalité soit directement, soit en déléguant le traitement à une classe d'implémentation sous la forme d'un service, donc sans état", ElementType = "DataObjectArchimate")]
	partial class Fonctionnalité_FonctionnaliteFct : CTechnicalFonctionality, DAO
	{
		ObjetFonctionnalite_ObjectFonctionnality objetFonctionnalite_ObjectFonctionnality_ ;

	}


	[ModelElement("objetFonctionnalite: ObjectFonctionnality","les objets gérés par une fonctionnalité: par exemple un log, un message, pour une fonctionnalité de traçage défini les objets qui sont passés comme paramètre à la classe d'implémentation pas obligatoire pour les fonctionnalités sans état", ElementType = "DataObjectArchimate")]
	partial class ObjetFonctionnalite_ObjectFonctionnality : DAO
	{
		Fonctionnalité_FonctionnaliteFct fonctionnalité_FonctionnaliteFct_ ;

	}


	[ModelElement("implementation: classeImplementationSrv","", ElementType = "DataObjectArchimate")]
	partial class Implementation_classeImplementationSrv : DAO
	{
	}

}


