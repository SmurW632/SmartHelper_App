namespace SmartHelper.Server.Models.PremisesFacilities
{
    public class InfrastructureDetails
    {
        public int InfrastructureId { get; set; }
        public bool Availability { get; set; }
        public string? ConsumptionTariff { get; set; }
        public string? TransportationTariff { get; set; }
        public string? MaximumAllowableCapacity { get; set; }
        public string? FreePower { get; set; }
        public string? OtherCharacteristics { get; set; }
        public string? Bandwidth { get; set; }
    }
}