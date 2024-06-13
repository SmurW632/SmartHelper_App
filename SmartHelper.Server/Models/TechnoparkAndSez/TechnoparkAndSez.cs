namespace SmartHelper.Server.Models.TechnoparkAndSez
{
    public class TechnoparkAndSez
    {
        public int TechnoparkAndSezId { get; set; }
        public string? Category { get; set; }
        public string? SpecialEconomicZone { get; set; }
        public string? Tor { get; set; }
        public string? TitleObject { get; set; }
        public int NumberOfResidents { get; set; }
        public DateTime YearOfFormation { get; set; }
        public string? ValidityPeriod { get; set; }
        public double TotalArea { get; set; }
        public int MinCostRental { get; set; }
        public string? MinAmountInvestment { get; set; }
        public bool PossibilityBuyingPremises { get; set; }
        public string? Photos { get; set; }
        public string? TimeWork { get; set; }
        public string? Documents { get; set; }
        public string? LinkToWebsite { get; set; }
        public string? RestrictionsTypeActivity { get; set; }
        public string? HowBecomeResident { get; set; }
    }
}
