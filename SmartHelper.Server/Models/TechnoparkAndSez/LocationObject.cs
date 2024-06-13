using SmartHelper.Server.Models.PremisesFacilities;

namespace SmartHelper.Server.Models.TechnoparkAndSez
{
    public class LocationObject
    {
        public int TechnoparkAndSezId { get; set; }
        public int SiteId { get; set; }
        public string? Region { get; set; }
        public string? NearestCity { get; set; }
        public string? MunicipalFormation { get; set; }
        public string? Coordinates { get; set; }

        public virtual TechnoparkAndSez? TechnoparkAndSez { get; set; }
        public virtual Site? Site { get; set; }
    }
}
