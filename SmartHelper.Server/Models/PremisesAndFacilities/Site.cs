using SmartHelper.Server.Models.TechnoparkAndSez;
using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class Site
{
    public int SiteId { get; set; }

    public string TitleSite { get; set; } = null!;

    public string PreferentialTreatment { get; set; } = null!;

    public string? NumberPreferentialTreatmentFacility { get; set; }

    public string? NamePreferentialTreatmentFacility { get; set; }

    public string SupportInfrastructureFacility { get; set; } = null!;

    public string? NumberSupportInfrastructureFacility { get; set; }

    public string? NameSupportInfrastructureFacility { get; set; }

    public string AddressObject { get; set; } = null!;

    public string FormatSite { get; set; } = null!;

    public string TypeSite { get; set; } = null!;

    public string FormOwnershipObject { get; set; } = null!;

    public string FormTransaction { get; set; } = null!;

    public string? CostObjectMonthlyRent { get; set; }

    public string? CostPerHa { get; set; }

    public string? CostPerSqm { get; set; }

    public string? MinAndMaxRentalTerms { get; set; }

    public string? ProcedureDeterminingCost { get; set; }

    public string? ClassHazardObject { get; set; }
    public virtual TasLocationObject? TasLocation { get; set; }

    public virtual SSiteCharacteristic? SSiteCharacteristic { get; set; }

    public virtual SAdditionalSiteCharacteristic? SAdditionalSiteCharacteristic { get; set; }

    public virtual SGasSupply? SGasSupplies { get; set; }

    public virtual SHeatSupply? SHeatSupply { get; set; }

    public virtual SPowerSupply? SPowerSupply { get; set; }

    public virtual SWaterDisposal? SWaterDisposably { get; set; }

    public virtual SWaterSupply? SWaterSupply { get; set; }

    public override string ToString()
    {
        return $"SiteId: {SiteId}, \n" +
             $"TitleSite: {TitleSite}, \n" +
             //$"Region: {TasLocation.Region}, \n" +
             //$"NearestCity: {TasLocation.NearestCity},\n " +
             //$"MunicipalFormation: {TasLocation.MunicipalFormation}, \n" +
             //$"Coordinates: {TasLocation.Coordinates}\n" +
             $"PreferentialTreatment: {PreferentialTreatment}, \n" +
             $"NumberPreferentialTreatmentFacility: {NumberPreferentialTreatmentFacility}, \n" +
             $"NamePreferentialTreatmentFacility: {NamePreferentialTreatmentFacility}, \n" +
             $"SupportInfrastructureFacility: {SupportInfrastructureFacility}, \n" +
             $"NumberSupportInfrastructureFacility: {NumberSupportInfrastructureFacility}, \n" +
             $"NameSupportInfrastructureFacility: {NameSupportInfrastructureFacility}, \n" +
             $"AddressObject: {AddressObject}, \n" +
             $"FormatSite: {FormatSite}, \n" +
             $"TypeSite: {TypeSite}, \n" +
             $"FormOwnershipObject: {FormOwnershipObject}, \n" +
             $"FormTransaction: {FormTransaction}, \n" +
             $"CostObjectMonthlyRent: {CostObjectMonthlyRent}, \n" +
             $"CostPerHa: {CostPerHa}, \n" +
             $"CostPerSqm: {CostPerSqm}, \n" +
             $"MinAndMaxRentalTerms: {MinAndMaxRentalTerms}, \n" +
             $"ProcedureDeterminingCost: {ProcedureDeterminingCost}, \n" +
             $"ClassHazardObject: {ClassHazardObject}\n" +
             $"CharacteristicsCapitalConstructionFacilitiesLocated: {SSiteCharacteristic.CharacteristicsCapitalConstructionFacilitiesLocated}, \n" +
             $"FreeLandPlot: {SSiteCharacteristic.FreeLandPlot}, \n" +
             $"CadastrolNumber: {SSiteCharacteristic.CadastrolNumber}, \n" +
             $"PermittedUseOptions: {SSiteCharacteristic.PermittedUseOptions}, \n" +
             $"MegevanieLandPlot: {SSiteCharacteristic.MegevanieLandPlot}, \n" +
             $"CategoryLand: {SSiteCharacteristic.CategoryLand}, \n" +
             $"FreeArea: {SSiteCharacteristic.FreeArea}, \n" +
             $"CadastralNumber: {SSiteCharacteristic.CadastralNumber}, \n" +
             $"TechnicalCharacteristics: {SSiteCharacteristic.TechnicalCharacteristics}, \n" +
             $"NameAdministrator: {SSiteCharacteristic.NameAdministrator}, \n" +
             $"InnAdministrator: {SSiteCharacteristic.InnAdministrator}, \n" +
             $"Link: {SSiteCharacteristic.Link}, \n" +
             $"Notes: {SSiteCharacteristic.Notes} \n"+
             $"Availability: {SGasSupplies.Availability}, \n" +
             $"ConsumptionTariff: {SGasSupplies.ConsumptionTariff}, \n" +
             $"TransportationTariff: {SGasSupplies.TransportationTariff}, \n" +
             $"MaximumAllowableCapacity: {SGasSupplies.MaximumAllowableCapacity}, \n" +
             $"FreePower: {SGasSupplies.FreePower}, \n" +
             $"OtherCharacteristics: {SGasSupplies.OtherCharacteristics}, \n" +
             $"Bandwidth: {SGasSupplies.Bandwidth} \n" +
             $"Availability: {SHeatSupply.Availability}, \n" +
             $"ConsumptionTariff: {SHeatSupply.ConsumptionTariff}, \n" +
             $"TransportationTariff: {SHeatSupply.TransportationTariff}, \n" +
             $"MaximumAllowableCapacity: {SHeatSupply.MaximumAllowableCapacity}, \n" +
             $"FreePower: {SHeatSupply.FreePower}, \n" +
             $"OtherCharacteristics: {SHeatSupply.OtherCharacteristics}, \n" +
             $"Bandwidth: {SHeatSupply.Bandwidth} \n" +
             $"Availability: {SPowerSupply.Availability}, \n" +
             $"ConsumptionTariff: {SPowerSupply.ConsumptionTariff}, \n" +
             $"TransportationTariff: {SPowerSupply.TransportationTariff}, \n" +
             $"MaximumAllowableCapacity: {SPowerSupply.MaximumAllowableCapacity}, \n" +
             $"FreePower: {SPowerSupply.FreePower}, \n" +
             $"OtherCharacteristics: {SPowerSupply.OtherCharacteristics}, \n" +
             $"Bandwidth: {SPowerSupply.Bandwidth}\n" +
             $"Availability: {SWaterDisposably.Availability}, \n" +
             $"ConsumptionTariff: {SWaterDisposably.ConsumptionTariff}, \n" +
             $"TransportationTariff: {SWaterDisposably.TransportationTariff}, \n" +
             $"MaximumAllowableCapacity: {SWaterDisposably.MaximumAllowableCapacity}, \n" +
             $"FreePower: {SWaterDisposably.FreePower}, \n" +
             $"OtherCharacteristics: {SWaterDisposably.OtherCharacteristics}, \n" +
             $"Bandwidth: {SWaterDisposably.Bandwidth}\n" +
             $"Availability: {SWaterSupply.Availability}, \n" +
             $"ConsumptionTariff: {SWaterSupply.ConsumptionTariff}, \n" +
             $"TransportationTariff: {SWaterSupply.TransportationTariff}, \n" +
             $"MaximumAllowableCapacity: {SWaterSupply.MaximumAllowableCapacity}, \n" +
             $"FreePower: {SWaterSupply.FreePower}, \n" +
             $"OtherCharacteristics: {SWaterSupply.OtherCharacteristics}, \n" +
             $"Bandwidth: {SWaterSupply.Bandwidth}\n" +
             $"ExportTkoAvailability: {SAdditionalSiteCharacteristic.ExportTkoAvailability}, \n" +
             $"ExportTkoTariffRubTon: {SAdditionalSiteCharacteristic.ExportTkoTariffRubTon}, \n" +
             $"ExportTkoTariffRubCub: {SAdditionalSiteCharacteristic.ExportTkoTariffRubCub}, \n" +
             $"AvailabilityAccessRoads: {SAdditionalSiteCharacteristic.AvailabilityAccessRoads}, \n" +
             $"RailwayAvailability: {SAdditionalSiteCharacteristic.RailwayAvailability}, \n" +
             $"ParkingForTruks: {SAdditionalSiteCharacteristic.ParkingForTruks}, \n" +
             $"OtherCharacteristics: {SAdditionalSiteCharacteristic.OtherCharacteristics}, \n" +
             $"DescriptionApplicationProcedure: {SAdditionalSiteCharacteristic.DescriptionApplicationProcedure}, \n" +
             $"ListDocumentsRequiredSubmitApplication: {SAdditionalSiteCharacteristic.ListDocumentsRequiredSubmitApplication}, \n" +
             $"LinkApplicationForm: {SAdditionalSiteCharacteristic.LinkApplicationForm}, \n" +
             $"ListTypesEconomicActivities: {SAdditionalSiteCharacteristic.ListTypesEconomicActivities}, \n" +
             $"UrbanCharacteristicsAndLimitations: {SAdditionalSiteCharacteristic.UrbanCharacteristicsAndLimitations}, \n" +
             $"UrbanPlanningDocument: {SAdditionalSiteCharacteristic.UrbanPlanningDocument}, \n" +
             $"OtherInformation: {SAdditionalSiteCharacteristic.OtherInformation}, \n" +
             $"PhotosObject: {SAdditionalSiteCharacteristic.PhotosObject}, \n" +
             $"AvailabilityMaip: {SAdditionalSiteCharacteristic.AvailabilityMaip}, \n" +
             $"DescriptionBenefits: {SAdditionalSiteCharacteristic.DescriptionBenefits}";
    }
}
