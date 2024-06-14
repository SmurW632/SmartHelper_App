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
}
