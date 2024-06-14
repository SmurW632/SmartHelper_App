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

    public virtual ICollection<SGasSupply> SGasSupplies { get; set; } = new List<SGasSupply>();

    public virtual ICollection<SHeatSupply> SHeatSupplies { get; set; } = new List<SHeatSupply>();

    public virtual ICollection<SPowerSupply> SPowerSupplies { get; set; } = new List<SPowerSupply>();

    public virtual ICollection<SWaterDisposal> SWaterDisposals { get; set; } = new List<SWaterDisposal>();

    public virtual ICollection<SWaterSupply> SWaterSupplies { get; set; } = new List<SWaterSupply>();
}
