using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class SHeatSupply
{
    public int HeatSupplyId { get; set; }

    public int? SiteId { get; set; }

    public string Availability { get; set; } = null!;

    public string? ConsumptionTariff { get; set; }

    public string? TransportationTariff { get; set; }

    public string? MaximumAllowableCapacity { get; set; }

    public string? FreePower { get; set; }

    public string? OtherCharacteristics { get; set; }

    public string? Bandwidth { get; set; }

    public virtual Site? Site { get; set; }
}
