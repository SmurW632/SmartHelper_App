﻿using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class SPowerSupply
{
    public int PowerSupplyId { get; set; }

    public int? SiteId { get; set; }

    public virtual Site? Site { get; set; }
    public virtual SInfrastructure? SInfrastructure { get; set; }
}
