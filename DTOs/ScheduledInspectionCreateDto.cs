namespace sky_webapi.DTOs
{
    public class ScheduledInspectionCreateDto
    {
        public int HoldingID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string? Location { get; set; }
        public int? InspectorID { get; set; }
        public bool IsCompleted { get; set; }
    }
}
