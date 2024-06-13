namespace SmartHelper.Server.Models.PremisesFacilities
{
    public class Site
    {
        public int SiteId { get; set; }
        public string? TitleSite { get; set; }
        public string? PreferentialTreatment { get; set; }
        public string? NumberPreferentialTreatmentFacility { get; set; }
        public string? NamePreferentialTreatmentFacility { get; set; }
        public string? SupportInfrastructureFacility { get; set; }
        public string? NumberSupportInfrastructureFacility { get; set; }
        public string? NameSupportInfrastructureFacility { get; set; }
        public string? AddressObject { get; set; }
        public string? FormatSite { get; set; }
        public string? TypeSite { get; set; }
        public string? FormOwnershipObject { get; set; }
        public string? FormTransaction { get; set; }
        public string? CostObjectMonthlyRent { get; set; }
        public string? CostPerHa { get; set; }
        public string? CostPerSqm { get; set; }
        public string? MinAndMaxRentalTerms { get; set; }
        public string? ProcedureDeterminingCost { get; set; }
        public string? ClassHazardObject { get; set; }
        public SiteCharacteristic? SiteCharacteristic { get; set; }
        public AdditionalSiteCharacterestic? AdditionalSiteCharacterestic { get; set; }
    }
}
