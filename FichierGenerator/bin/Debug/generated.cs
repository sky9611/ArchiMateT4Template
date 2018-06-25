




using System.Collections.Generic;

using Maidis.VNext.Consultation
using Maidis.VNext.Personne
using Maidis.VNext.Examen

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

	[ModelElement("EPatient","informations d'identification du patient et de ses caractéristiques, ElementType = "BusinessObjectArchimate")]
	partial class EPatient : EPersonne
	{
	
		Alphabétique Nom;
	
		Alphabétique Prenom;
	
		Date DateNaissance;
	
		EPatient Implementation;
		List<EConsultation> eConsultation_ = 
			new List<EConsultation>();
		List<EContact> eContact_ ;
	}
	[ModelElement("EContact","contact du patient, ElementType = "BusinessObjectArchimate")]
	partial class EContact : EPersonne
	{
	
		EContact Implementation;
	}
	[ModelElement("ServiceGestionPatient","opération CRUD sur patient et associé, ElementType = "ApplicationServiceArchimate")]
	partial class ServiceGestionPatient 
	{
	
		ServiceGestionPatient Implementation;
	}
	[ModelElement("StartToolEvent("Accueil patient")",", ElementType = "ApplicationEventArchimate")]
	partial class StartToolEventAccueil_patient 
	{
	
		StartToolEvent("Accueil patient") Implementation;
	}
	[ModelElement("ViewPatient",", ElementType = "RepresentationArchimate")]
	partial class ViewPatient 
	{
	
		ViewPatient Implementation;
		EPatient ePatient_ ;

		Button button_ ;

	}
	[ModelElement("UseCaseAccueilPatient","pilotage des vues et services pour l'accueil d'un patient, ElementType = "ApplicationProcessArchimate")]
	partial class UseCaseAccueilPatient 
	{
	
		UseCaseAccueilPatient Implementation;
		List<Traitement_scénario_accueil_patient> traitement_scénario_accueil_patient_ = 
			new List<Traitement_scénario_accueil_patient>();
		IGererAccueilPatient iGererAccueilPatient_ ;

		DemandeRecherchePatient demandeRecherchePatient_ ;

	}
	[ModelElement("PAPatient",", ElementType = "DataObjectArchimate")]
	partial class PAPatient 
	{
		EPatient ePatient_ ;

		EPersonne ePersonne_ ;

	}
}
namespace Maidis.VNext.Consultation
{
	[ModelElement("UseCaseConsultation","pilotage des vues et services pour la gestion d'une consultation, ElementType = "ApplicationProcessArchimate")]
	partial class UseCaseConsultation 
	{
	
		UseCaseConsultation Implementation;
	}
	[ModelElement("EConsultation",", ElementType = "BusinessObjectArchimate")]
	partial class EConsultation 
	{
	
		EConsultation Implementation;
	}
	[ModelElement("Vue consultation",", ElementType = "RepresentationArchimate")]
	partial class Vue_consultation 
	{
		EConsultation eConsultation_ ;

	}
}
namespace Maidis.VNext.Personne
{
	[ModelElement("EPersonne",", ElementType = "BusinessObjectArchimate")]
	partial class EPersonne 
	{
	
		EPersonne Implementation;
	}
}

