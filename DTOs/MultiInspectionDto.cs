namespace sky_webapi.DTOs
{
    public class MultiInspectionItemDto
    {
        public int HoldingID { get; set; }
        public string? PlantDescription { get; set; }
        public string? SerialNumber { get; set; }
        public string? SWL { get; set; } // Safe Working Load
        public string? StatusDescription { get; set; }
        public string? Defects { get; set; } // Editable per item
        public bool Included { get; set; } // Boolean per item
        
        // Additional fields for display
        public int? CustID { get; set; }
        public string? CategoryDescription { get; set; }
        public int? StatusID { get; set; }
    }

    public class MultiInspectionRequestDto
    {
        public int CustomerId { get; set; }
        public int[] CategoryIds { get; set; } = Array.Empty<int>();
    }

    public class CreateMultiInspectionDto
    {
        public int CustomerId { get; set; }
        public int InspectorID { get; set; }
        public DateTime InspectionDate { get; set; }
        public string? Location { get; set; } // Common location for all items
        public DateTime? LatestDate { get; set; } // Optional field
        public string? TestDetails { get; set; }
        public string? MiscNotes { get; set; }
        
        // Array of items to inspect
        public MultiInspectionItemCreateDto[] Items { get; set; } = Array.Empty<MultiInspectionItemCreateDto>();
    }
    
    public class MultiInspectionItemCreateDto
    {
        public int HoldingID { get; set; }
        public string? Defects { get; set; }
        public string? RecentCheck { get; set; }
        public string? PreviousCheck { get; set; }
        public string? SafeWorking { get; set; }
        public string? Rectified { get; set; }
        public bool Included { get; set; } // Whether this item should be included in the inspection
    }
}
