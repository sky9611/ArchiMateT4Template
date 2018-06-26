




using System.Collections.Generic;

using Maidis.VNext.Consultation;
using Maidis.VNext.Personne;
using Maidis.VNext.Examen;

namespace Maidis.VNext.Patient
{
	public interface MenuDossierPatientID 
	{
	}

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
	partial class EPatient : EPersonne,IBusinessObject
	{
	
		Alphabétique Nom;
	
		Alphabétique Prenom;
	
		Date DateNaissance;
		List<EConsultation> eConsultation_ = 
			new List<EConsultation>();
		List<EContact> contacts_ ;
	}

	[ModelElement("EContact","contact du patient", ElementType = "BusinessObjectArchimate")]
	partial class EContact : EPersonne,IBusinessObject
	{
	}

	[ModelElement("ServiceGestionPatient","opération CRUD sur patient et associé", ElementType = "ApplicationServiceArchimate")]
	partial class ServiceGestionPatient : UseCaseWorkflow
	{
	}

	[ModelElement("StartToolEvent("Accueil patient")","", ElementType = "ApplicationEventArchimate")]
	partial class StartToolEventAccueil_patient : EventArgs
	{
	}

	[ModelElement("ViewPatient","", ElementType = "RepresentationArchimate")]
	partial class ViewPatient : ViewPatient,IView
	{
		EPatient enCours_ ;

	}

	[ModelElement("UseCaseAccueilPatient","pilotage des vues et services pour l'accueil d'un patient", ElementType = "ApplicationProcessArchimate")]
	partial class UseCaseAccueilPatient : IVisualiserPatient,IGererAccueilPatient,DemandeRecherchePatient,UseCaseWorkflow
	{
		EPatient patientEnCours_ ;

		ViewPatient vuePatient_ ;

	}

	[ModelElement("PAPatient","", ElementType = "DataObjectArchimate")]
	partial class PAPatient : DAO
	{
		EPatient ePatient_ ;

		EPersonne ePersonne_ ;

	}

}

namespace Maidis.VNext.Consultation
{
	[ModelElement("UseCaseConsultation","pilotage des vues et services pour la gestion d'une consultation", ElementType = "ApplicationProcessArchimate")]
	partial class UseCaseConsultation : UseCaseWorkflow
	{
		Vue_consultation vue_consultation_ ;

	}

	[ModelElement("EConsultation","", ElementType = "BusinessObjectArchimate")]
	partial class EConsultation : IBusinessObject
	{
	}

	[ModelElement("Vue consultation","", ElementType = "RepresentationArchimate")]
	partial class Vue_consultation : Action Consultation,IView
	{
		EConsultation eConsultation_ ;

	}

}

namespace Maidis.VNext.Personne
{
	[ModelElement("EPersonne","", ElementType = "BusinessObjectArchimate")]
	partial class EPersonne : IBusinessObject
	{
	}

}


