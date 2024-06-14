using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class SInfrastructure
{
    public int? WaterDisposalId { get; set; }

    public int? WaterSupplyId { get; set; }

    public int? GasSupplyId { get; set; }

    public int? PowerSupplyId { get; set; }

    public int? HeatSupplyId { get; set; }

    public string Availability { get; set; } = null!;

    public string? ConsumptionTariff { get; set; }

    public string? TransportationTariff { get; set; }

    public string? MaximumAllowableCapacity { get; set; }

    public string? FreePower { get; set; }

    public string? OtherCharacteristics { get; set; }

    public string? Bandwidth { get; set; }

    public virtual SGasSupply? GasSupply { get; set; }

    public virtual SHeatSupply? HeatSupply { get; set; }

    public virtual SPowerSupply? PowerSupply { get; set; }

    public virtual SWaterDisposal? WaterDisposal { get; set; }

    public virtual SWaterSupply? WaterSupply { get; set; }
}
