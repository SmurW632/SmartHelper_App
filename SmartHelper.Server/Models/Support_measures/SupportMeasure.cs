using Microsoft.AspNetCore.Components.Web;

namespace SmartHelper.Server.Models.Support_measures
{
    public class SupportMeasure
    {
        public int SupportMeasureId { get; set; }
        public string? Region { get; set; }
        public string? NameSupportMeasure { get; set; }
        public string? TypeSupport { get; set; }
        public string? SupportLevel { get; set; }
        public string? EssenceMechanism { get; set; }
        public string? MinInvestVolume { get; set; }
        public string? OKVED {  get; set; }
        public string? LimitTypeActivity { get; set; }
        public bool EntryIntoRegisterSme {  get; set; }
        public NPA? Npa { get; set; }
        public SubmissionOfDocument? SubmissionOfDocument { get; set; }
    }
}
