



using System.Collections.Generic;

using Maidis.VnextExamen;
using Maidis.VnextConsultation;
using Maidis.VnextPersonne;

namespace Maidis.VnextConsultation
{
	[Model(ApplicationProcessArchimate, "Cas d'utilisation Consultation")]
	[ReferenceModel(BusinessProcessArchimate, "Gestion d'une consultation")]
	partial class Cas_dutilisation_Consultation : UseCaseWorkflow
	{
		Vue_consultation vue_consultation_ ;

	}

	[Model(BusinessObjectArchimate, "Consultation")]
	partial class Consultation : IBusinessObject
	{
	}

	[Model(DataObjectArchimate, "PAConsultation")]
	partial class PAConsultation : DAO
	{
		List<PAPatient> pAPatient_ ;
	}

	public interface IVue_consultation{}

	[Model(RepresentationArchimate, "Vue consultation")]
	partial class Vue_consultation : IVue_consultation
	{
	}

}

namespace Maidis.VnextPatient
{
	public interface MenuDossierPatient 
	{
	}

	public interface DemandeRecherchePatient 
	{
	}

	public interface SaisirNouveauPatient : GererAccueilPatient
	{

	}

	public interface VisualiserPatient : GererAccueilPatient
	{

	}

	public interface ListerPatients 
	{
	}

	public interface RechercherPatients 
	{
	}

	public interface GererAccueilPatient 
	{
	}

	[ReferenceModel(BusinessInterfaceArchimate, "Action Création")]
	public interface Bouton_Créer_Patient 
	{
	}

	public interface DemandeCreerPatient 
	{
	}

	[Model(BusinessObjectArchimate, "Patient")]
	partial class Patient : Personne, IBusinessObject
	{
		Alphabétique Nom;

		Alphabétique Prenom;

		Date DateNaissance;

		List<Contact> contacts_ ;
	}

	[Model(BusinessObjectArchimate, "Contact")]
	partial class Contact : Personne, IBusinessObject
	{
	}

	[Model(ApplicationServiceArchimate, "Gestion données patient")]
	[ReferenceModel(BusinessServiceArchimate, "Accueillir dans un service")]
	partial class Gestion_données_patient : UseCaseWorkflow
	{
	}

	public interface IVue_patient{}

	[Reference("vue Patient générée")]
	[Reference("Template vue Entité")]
	[Model(RepresentationArchimate, "Vue patient")]
	partial class Vue_patient : Bouton_Créer_Patient, IVue_patient
	{
	
		ViewPatient $Implementation;
	
		VueCRUD.T4 $Template;
	}

	[Model(DataObjectArchimate, "PAPatient")]
	partial class PAPatient : DAO
	{
	
		CHAR(25) Nom;

	
		CHAR(25) Prenom;

	
		DATETIME DateNaissance;

	}

	[Model(ApplicationProcessArchimate, "Cas d'utilisation accueil Patient")]
	[ReferenceModel(BusinessProcessArchimate, "Accueil d'un patient")]
	partial class Cas_dutilisation_accueil_Patient : VisualiserPatient, GererAccueilPatient, DemandeRecherchePatient, UseCaseWorkflow
	{
		Vue_recherche_patient vue_recherche_patient_ ;

		Vue_patient vuePatient_ ;

		Cas_dutilisation_Consultation demandeConsultation_ ;

		Traitement_métier_gestion_Patient traitement_métier_gestion_Patient_ ;

	}

	[Model(ApplicationServiceArchimate, "Gestion données contact")]
	partial class Gestion_données_contact : UseCaseWorkflow
	{
	}

}

namespace Maidis.VnextPersonne
{
	[Model(BusinessObjectArchimate, "Personne")]
	partial class Personne : IBusinessObject
	{
	}

}

namespace Maidis.VnextFramework_ADF_NET
{
	[Model(ApplicationServiceArchimate, "Accès CRUD sur entité métier")]
	partial class Accès_CRUD_sur_entité_métier : UseCaseWorkflow
	{
	}

}

namespace Maidis.VnextUnconnu
{
}


