




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


