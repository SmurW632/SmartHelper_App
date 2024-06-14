using System;
using System.Collections.Generic;
using SmartHelper.Server.Models.PremisesAndFacilities;

namespace SmartHelper.Server.Models.TechnoparkAndSez;

public partial class TasLocationObject
{
    public int? TechnoparksAndSezId { get; set; }

    public int? SiteId { get; set; }

    public string Region { get; set; } = null!;

    public string NearestCity { get; set; } = null!;

    public string MunicipalFormation { get; set; } = null!;

    public string? Coordinates { get; set; }

    public virtual Site? Site { get; set; }

    public virtual TasTechnoparksAndSez? TechnoparksAndSez { get; set; }
}
