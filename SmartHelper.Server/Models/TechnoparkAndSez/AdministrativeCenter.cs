namespace SmartHelper.Server.Models.TechnoparkAndSez
{
    public class AdministrativeCenter
    {
        public int TechnoparkAndSezId { get; set; }
        public string? TitleAdministration { get; set; }
        public string? AddressAdministration { get; set; }

        public virtual TechnoparkAndSez? TechnoparkAndSez { get; set; }
    }
}
