using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.TechnoparkAndSez;

public partial class TasDescriptionObject
{
    public int? TechnoparksAndSezId { get; set; }

    public string ListIndustry { get; set; } = null!;

    public string? InfrastructureAndServices { get; set; }

    public string? AdditionalServicesMngCompany { get; set; }

    public string AvailabilityFreeCustomsZoneRegime { get; set; } = null!;

    public virtual TasTechnoparksAndSez? TechnoparksAndSez { get; set; }
}
