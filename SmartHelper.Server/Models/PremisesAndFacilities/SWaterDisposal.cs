using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class SWaterDisposal
{
    public int WaterDisposalId { get; set; }

    public int? SiteId { get; set; }

    public virtual Site? Site { get; set; }
}
