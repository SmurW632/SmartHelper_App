namespace SmartHelper.Server.Models.PremisesFacilities
{
    public class SiteCharacteristic
    {
        public int SiteId { get; set; }
        public string? ConstructionFacilitiesLocated { get; set; }
        public float FreeLandPlot { get; set; }
        public string? CadastrolNumber { get; set; }
        public string? PermittedUseOptions { get; set; }
        public bool MegevanieLandPlot { get; set; }
        public string? CategoryLand { get; set; }
        public int FreeArea { get; set; }
        public string? CadastralNumber { get; set; }
        public string? TechnicalCharacteristics { get; set; }
        public string? NameAdministrator { get; set; }
        public string? InnAdministrator { get; set; }
        public string? Link { get; set; }
        public string? Notes { get; set; }
    }
}