namespace sky_webapi.DTOs
{
    public class InspectionDto
    {
        public int UniqueRef { get; set; }
        public int? HoldingID { get; set; }
        public DateTime? InspectionDate { get; set; }
        public string? Location { get; set; }
        public string? RecentCheck { get; set; }
        public string? PreviousCheck { get; set; }
        public string? SafeWorking { get; set; }
        public string? Defects { get; set; }
        public string? Rectified { get; set; }
        public DateTime? LatestDate { get; set; }
        public string? TestDetails { get; set; }
        public string? MiscNotes { get; set; }
        public int? InspectorID { get; set; }
    }
}
