




using System.Collections.Generic;

using Maidis.VNext.Domaine_métier;

namespace Maidis.VNext.Domaine_métier
{
	[ModelElement("Composant applicatif","Une partie modulaire, déployable, et remplaçable d'un système logiciel qui encapsule son comportement et ses données et expose ceux-ci à travers un ensemble d'interfaces exemple: couche présentation tool consultation", ElementType = "ApplicationComponentArchimate")]
	partial class Composant_applicatif : Component
	{
		Objet_données objet_données_ ;

	}

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
	}

	[ModelElement("NomClasseVue","élément perceptible (visible) associé aux entités métiers exemple: vue état-civil patient", ElementType = "RepresentationArchimate")]
	partial class NomClasseVue : NomClasseVue, Interface_applicative, Interface_IHM, Interface_métier, IView
	{
	
		 Type;
		NomClasseMetier nomClasseMetier_ ;

		NomClasseVue vue_Base_ ;

	}

}

namespace Maidis.VNext.Entrants_métier
{
	public interface Interface_métier 
	{
	}

	[ModelElement("Contrat","Une spécification formelle ou informelle d'un accord qui précise les droits et obligations liés à un produit ou un service métier exemple: application du PMSI", ElementType = "ContractArchimate")]
	partial class Contrat : Contrat, CContract
	{
		List<Contrat> contrat_ ;
	}

}

namespace Maidis.VNext.Traitements_applicatifs
{
	[ModelElement("Processus applicatif","suite de fonctions applicatives en vue de la réalisation d'un résultat. Peut intégrer des comportements non automatisés exemple: cas d'utilisation accueil consultation", ElementType = "ApplicationProcessArchimate")]
	partial class Processus_applicatif : UseCaseWorkflow
	{
		NomClasseVue workflow_ ;

		NomClasseMetier nomClasseMetier_ ;

	}

}

namespace Maidis.VNext.Entrants_applicatif
{
	public interface Interface_applicative 
	{
	}

	[ModelElement("NomClasseEvenement ou NomMethodeEvenement","un comportement applicatif qui provoque un changement d'état exemple: réception d'un message \"mise à jour du dossier patient\"", ElementType = "ApplicationEventArchimate")]
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

namespace Maidis.VNext.Structuration_technique
{
}


