using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.TechnoparkAndSez;

public partial class TasAdministrativeCenter
{
    public int Id { get; set; }
    public int? TechnoparksAndSezId { get; set; }

    public string TitleAdministration { get; set; } = null!;

    public string AddressAdministration { get; set; } = null!;

    public virtual TasTechnoparksAndSez? TechnoparksAndSez { get; set; }
}
