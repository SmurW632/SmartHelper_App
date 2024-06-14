using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.SupportMeasures;

public partial class SpSubmissionOfDocument
{
    public int? SupportMeasuresId { get; set; }

    public string LinkToApplicationForm { get; set; } = null!;

    public string RequirementsForApplicant { get; set; } = null!;

    public string ApplicationProcedure { get; set; } = null!;

    public string? RequiredDocuments { get; set; }

    public virtual SpSupportMeasure? SupportMeasures { get; set; }
}
