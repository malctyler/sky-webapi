namespace sky_webapi.DTOs
{
    public class ScheduledInspectionDto
    {        public int Id { get; set; }
        public int HoldingID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string? Location { get; set; }
        public string? Notes { get; set; }
        public int? InspectorID { get; set; }
        public bool IsCompleted { get; set; }
        
        // Additional fields from PlantHolding for convenience
        public string? PlantDescription { get; set; }
        public string? SerialNumber { get; set; }
        public string? CustomerCompanyName { get; set; }
        public string? CustomerContactName { get; set; }
        public string? InspectorName { get; set; }
    }
}
