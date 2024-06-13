namespace SmartHelper.Server.Models.TechnoparkAndSez
{
    public class Finance
    {
        public int TechnoparkAndSezId { get; set; }
        public string? IncomeTax { get; set; }
        public string? PropertyTax { get; set; }
        public string? LandTax { get; set; }
        public string? TransportTax { get; set; }
        public string? InsurancePremiums { get; set; }
        public string? OtherBenefits { get; set; }

        public virtual TechnoparkAndSez? TechnoparkAndSez { get; set; }
    }
}
