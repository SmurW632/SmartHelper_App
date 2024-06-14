using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.SupportMeasures;

public partial class SpSupportMeasure
{
    public int SupportMeasuresId { get; set; }

    public string Region { get; set; } = null!;

    public string? NameSupportMeasure { get; set; }

    public string TypeSupport { get; set; } = null!;

    public string SupportLevel { get; set; } = null!;

    public string EssenceMechanism { get; set; } = null!;

    public string NameResponsibleAuthorityAdmin { get; set; } = null!;

    public string? MinInvestVolume { get; set; }

    public string Okved { get; set; } = null!;

    public string LimitTypeActivity { get; set; } = null!;

    public string? EntryIntoRegisterSme { get; set; }
}
