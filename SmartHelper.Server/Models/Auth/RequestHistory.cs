namespace SmartHelper.Server.Models.Auth
{
    public class RequestHistory
    {
        public int UserId { get; set; }
        public int ResponseId { get; set; }
        public string? Request {  get; set; }
        public string? Response { get; set; }
        public DateTime DateRequest { get; set; }
    }
}