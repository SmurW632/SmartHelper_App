using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartHelper.Server.Models.PremisesAndFacilities;

public partial class SAdditionalSiteCharacteristic
{
    [Key]
    public int Id { get; set; }
    public int? SiteId { get; set; }

    public string? ExportTkoAvailability { get; set; }

    public string? ExportTkoTariffRubTon { get; set; }

    public float? ExportTkoTariffRubCub { get; set; }

    public string? AvailabilityAccessRoads { get; set; }

    public string RailwayAvailability { get; set; } = null!;

    public string ParkingForTruks { get; set; } = null!;

    public string? OtherCharacteristics { get; set; }

    public string DescriptionApplicationProcedure { get; set; } = null!;

    public string? ListDocumentsRequiredSubmitApplication { get; set; }

    public string LinkApplicationForm { get; set; } = null!;

    public string ListTypesEconomicActivities { get; set; } = null!;

    public string? UrbanCharacteristicsAndLimitations { get; set; }

    public string? UrbanPlanningDocument { get; set; }

    public string? OtherInformation { get; set; }

    public string PhotosObject { get; set; } = null!;

    public string? AvailabilityMaip { get; set; }

    public string? DescriptionBenefits { get; set; }

    public virtual Site? Site { get; set; }
}
