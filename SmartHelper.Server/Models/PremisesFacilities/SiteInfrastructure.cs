namespace SmartHelper.Server.Models.PremisesFacilities
{
    public class SiteInfrastructure
    {
        public int SiteId { get; set; }
        public InfrastructureDetails? WaterDisposal { get; set; }
        public InfrastructureDetails? WaterSupply { get; set; }
        public InfrastructureDetails? GasSupply { get; set; }
        public InfrastructureDetails? PowerSupply { get; set; }
        public InfrastructureDetails? HeatSupply { get; set; }
    }
}
