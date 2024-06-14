using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.Auth;

public partial class AuthRequestHistory
{
    public int ResponseId { get; set; }

    public int? UserId { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateOnly? DataRequest { get; set; }

    public virtual AuthUser? User { get; set; }
}
