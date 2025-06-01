using System;

namespace sky_webapi.DTOs
{
    public class InspectionDueDateDto
    {
        public DateTime LastInspection { get; set; }
        public DateTime DueDate { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public int InspectionFrequency { get; set; }

        // UK formatted date strings
        public string FormattedLastInspection => LastInspection.ToString("dd/MM/yyyy");
        public string FormattedDueDate => DueDate.ToString("dd/MM/yyyy");
    }
}
