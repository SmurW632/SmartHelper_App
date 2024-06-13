namespace SmartHelper.Server.Models.Auth
{
    public class AuthUser
    {
        public int UserId { get; set; }
        public string? Role { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? INN { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? NameOfOrganization { get; set; }
        public string? Post {  get; set; }
        public string? WebSiteOrganization { get; set; }
        public string? TypeOfIndustry { get; set; }
        public RequestHistory? RequestHistory { get; set; }
    }
}
