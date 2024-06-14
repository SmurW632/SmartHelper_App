using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class SGasSupply
{
    public int GasSupplyId { get; set; }

    public int? SiteId { get; set; }

    public virtual Site? Site { get; set; }
}
