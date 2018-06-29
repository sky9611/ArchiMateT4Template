




using System.Collections.Generic;

using Maidis.VNext.Consultation;
using Maidis.VNext.Personne;
using Maidis.VNext.Examen;

namespace Maidis.VNext.Personne
{

	[ModelElement("EPersonne","", ElementType = "BusinessObjectArchimate")]
	partial class EPersonne : IBusinessObject
	{
		PAPatient pAPatient_ ;

	}

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
		List<EConsultation> eConsultation_ = 
			new List<EConsultation>();
		List<EContact> contacts_ ;
		ViewPatient viewPatient_ ;

		PAPatient pAPatient_ ;

	}


	[ModelElement("EContact","contact du patient", ElementType = "BusinessObjectArchimate")]
	partial class EContact : EPersonne, IBusinessObject
	{
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

		IViewPatient vuePatient_ ;

	}

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

	}

}


