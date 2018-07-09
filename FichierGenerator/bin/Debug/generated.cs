




using System.Collections.Generic;

using Maidis.VNext.Examen;
using Maidis.VNext.Consultation;
using Maidis.VNext.Personne;

namespace Maidis.VNext.Consultation
{
	[Model(ApplicationProcessArchimate, "UseCaseConsultation")]
	[ReferenceModel(BusinessProcessArchimate, "Gestion d'une consultation")]
	partial class UseCaseConsultation : UseCaseWorkflow
	{
		Vue_consultation vue_consultation_ ;

	}

	[Model(BusinessObjectArchimate, "EConsultation")]
	partial class EConsultation : IBusinessObject
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
		IUseCaseConsultation useCaseConsultation;
		public	Vue_consultation(IWorkflow caller)
		{
			useCaseConsultation = caller as UseCaseConsultation;
		}
	}

}

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

	public interface IRechercherPatient 
	{
	}

	public interface IGererAccueilPatient 
	{
	}

	[ReferenceModel(BusinessInterfaceArchimate, "Action Création")]
	public interface Button 
	{
	}

	public interface DemandeCreerPatient 
	{
	}

	[Model(BusinessObjectArchimate, "EPatient")]
	partial class EPatient : EPersonne, IBusinessObject
	{
		Alphabétique Nom;

		Alphabétique Prenom;

		Date DateNaissance;

		List<EContact> contacts_ ;
	}

	[Model(BusinessObjectArchimate, "EContact")]
	partial class EContact : EPersonne, IBusinessObject
	{
	}

	[Model(ApplicationServiceArchimate, "ServiceGestionPatient")]
	[ReferenceModel(BusinessServiceArchimate, "Accueillir dans un service")]
	partial class ServiceGestionPatient : UseCaseWorkflow
	{
	}

	partial class StartToolEvent : EventArgs
	{
	}

	public interface IViewPatient{}

	[Reference("vue Patient générée")]
	[Model(RepresentationArchimate, "ViewPatient")]
	partial class ViewPatient : Button, IViewPatient
	{
		IUseCaseAccueilPatient workflowPatient;
		public	ViewPatient(IWorkflow caller)
		{
			workflowPatient = caller as UseCaseAccueilPatient;
		}
	}

	[Model(DataObjectArchimate, "PAPatient")]
	partial class PAPatient : DAO
	{
	
		CHAR(25) Nom;

	
		CHAR(25) Prenom;

	
		DATETIME DateNaissance;

	}

	[Model(ApplicationProcessArchimate, "UseCaseAccueilPatient")]
	[ReferenceModel(BusinessProcessArchimate, "Accueil d'un patient")]
	partial class UseCaseAccueilPatient : IVisualiserPatient, IGererAccueilPatient, DemandeRecherchePatient, UseCaseWorkflow
	{
		Vue_recherche_patient vue_recherche_patient_ ;

		ViewPatient vuePatient_ ;

		UseCaseConsultation demandeConsultation_ ;

		GestionPatient gestionPatient_ ;

	}

	[Model(ApplicationServiceArchimate, "ServiceGestionContact")]
	partial class ServiceGestionContact : UseCaseWorkflow
	{
	}

}

namespace Maidis.VNext.Personne
{
	[Model(BusinessObjectArchimate, "EPersonne")]
	partial class EPersonne : IBusinessObject
	{
	}

}

namespace Maidis.VNext.Framework_ADF_NET
{
	[Model(ApplicationServiceArchimate, "ServiceCRUD<P>")]
	partial class ServiceCRUDP : UseCaseWorkflow
	{
	}

}

namespace Maidis.VNext.Unconnu
{
}




