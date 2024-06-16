using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.TechnoparkAndSez;

public partial class TasTechnoparksAndSez
{
    public int TechnoparksAndSezId { get; set; }

    public string Category { get; set; } = null!;

    public string? SpecialEconomicZone { get; set; }

    public string? Tor { get; set; }

    public string TitleObject { get; set; } = null!;

    public int? NumberOfResidents { get; set; }

    public DateOnly YearOfFormation { get; set; }

    public string ValidityPeriod { get; set; } = null!;

    public float? TotalArea { get; set; }

    public int? MinCostRental { get; set; }

    public string? MinAmountInvestment { get; set; }

    public string PossibilityBuyingPremises { get; set; } = null!;

    public string Photos { get; set; } = null!;

    public string? TimeWork { get; set; }

    public string? Documents { get; set; }

    public string? LinkToWebsite { get; set; }

    public string RestrictionsTypeActivity { get; set; } = null!;

    public string HowBecomeResident { get; set; } = null!;

    public virtual TasAdministrativeCenter? TasAdministrativeCenter { get; set; }
    public virtual TasDescriptionObject? TasDescription { get; set; }
    public virtual TasFinance? TasFinance { get; set; }
    public virtual TasLocationObject? TasLocation { get; set; }
}
