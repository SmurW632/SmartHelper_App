using System;
using System.Collections.Generic;

namespace SmartHelper.Server.Models.Auth;

public partial class AuthUser
{
    public int UserId { get; set; }

    public string Role { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? NameOfOrganization { get; set; }

    public string? Post { get; set; }

    public string? WebsiteOrganization { get; set; }

    public string? TypeOfIndustry { get; set; }

    public virtual AuthRequestHistory? AuthRequestHistory { get; set; }
}
