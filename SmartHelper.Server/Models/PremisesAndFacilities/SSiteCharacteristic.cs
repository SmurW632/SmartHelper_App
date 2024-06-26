﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class SSiteCharacteristic
{
    public int SiteCharacteristicsId { get; set; }
    public int? SiteId { get; set; }

    public string? CharacteristicsCapitalConstructionFacilitiesLocated { get; set; }

    public string? FreeLandPlot { get; set; }

    public string? CadastrolNumber { get; set; }

    public string? PermittedUseOptions { get; set; }

    public string? MegevanieLandPlot { get; set; }

    public string? CategoryLand { get; set; }

    public string? FreeArea { get; set; }

    public string? CadastralNumber { get; set; }

    public string? TechnicalCharacteristics { get; set; }

    public string NameAdministrator { get; set; } = null!;

    public string InnAdministrator { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual Site? Site { get; set; }
}
