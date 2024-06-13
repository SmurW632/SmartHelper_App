namespace SmartHelper.Server.Models.Support_measures
{
    public class SubmissionOfDocument
    {
        public int SupportMeasureId { get; set; }
        public string? LinkToApplicationsForm { get; set; }
        public string? RequrementsForApplicant { get; set; }
        public string? ApplicationProcedure {  get; set; }
        public string? RequiredDocuments {  get; set; }
    }
}