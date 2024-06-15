using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.TechnoparkAndSez;

public partial class TasFinance
{
    public int Id { get; set; }
    public int? TechnoparksAndSezId { get; set; }

    public string IncomeTax { get; set; } = null!;

    public string PropertyTax { get; set; } = null!;

    public string LandTax { get; set; } = null!;

    public string TransportTax { get; set; } = null!;

    public string InsurancePremiums { get; set; } = null!;

    public string? OtherBenefits { get; set; }

    public virtual TasTechnoparksAndSez? TechnoparksAndSez { get; set; }
}
