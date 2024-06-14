using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.SupportMeasures;

public partial class SpNpa
{
    public int? SupportMeasuresId { get; set; }

    public string Requisites { get; set; } = null!;

    public string? LinkToNpa { get; set; }

    public string? DownloadTheNpa { get; set; }

    public virtual SpSupportMeasure? SupportMeasures { get; set; }
}
