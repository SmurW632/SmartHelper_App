namespace SmartHelper.Server.Models.TechnoparkAndSez
{
    public class DescriptionObject
    {
        public int TechnoparkAndSezId { get; set; }
        public string? ListIndustry { get; set; }
        public string? InfrastructureAndServices { get; set; }
        public string? AdditionalServicesMngCompany { get; set; }
        public bool AvailabilityFreeCustomsZoneRegime { get; set; }

        public virtual TechnoparkAndSez TechnoparkAndSez { get; set; }
    }
}
