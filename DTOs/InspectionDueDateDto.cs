using System;

namespace sky_webapi.DTOs
{    
    public class InspectionDueDateDto
    {
        public int HoldingID { get; set; }
        public DateTime LastInspection { get; set; }
        public DateTime DueDate { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public int InspectionFrequency { get; set; }
        public int ScheduledInspectionCount { get; set; }
        public string Postcode { get; set; } = string.Empty;

        // UK formatted date strings
        public string FormattedLastInspection => LastInspection.ToString("dd/MM/yyyy");
        public string FormattedDueDate => DueDate.ToString("dd/MM/yyyy");
    }
}
