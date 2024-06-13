namespace SmartHelper.Server.Models.PremisesFacilities
{
    public class AdditionalSiteCharacterestic
    {
        public int SiteId { get; set; }
        public string? ExportTkoAvailability { get; set; }
        public string? ExportTkoTariffRubTon { get; set; }
        public float ExportTkoTariffRubCub { get; set; }
        public bool AvailabilityAccessRoads { get; set; }
        public bool RailwayAvailability { get; set; }
        public bool ParkingForTrucks { get; set; }
        public string? OtherCharacteristics { get; set; }
        public string? DescriptionApplicationProcedure { get; set; }
        public string? ListDocumentsRequiredSubmitApplication { get; set; }
        public string? LinkApplicationForm { get; set; }
        public string? ListTypesEconomicActivities { get; set; }
        public string? UrbanCharacteristicsAndLimitations { get; set; }
        public string? UrbanPlanningDocument { get; set; }
        public string? OtherInformation { get; set; }
        public string? PhotosObject { get; set; }
        public bool? AvailabilityMaip { get; set; }
        public string? DescriptionBenefits { get; set; }
    }
}