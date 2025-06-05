namespace sky_webapi.DTOs
{    /// <summary>
    /// Data transfer object for creating or updating a scheduled inspection
    /// </summary>
    public class CreateUpdateScheduledInspectionDto
    {
        /// <summary>
        /// The ID of the plant holding to be inspected
        /// </summary>
        public int HoldingID { get; set; }

        /// <summary>
        /// The scheduled date and time of the inspection
        /// </summary>
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Optional location where the inspection will take place
        /// </summary>
        public string? Location { get; set; }        /// <summary>
        /// Additional notes about the scheduled inspection
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Optional ID of the inspector assigned to this inspection
        /// </summary>
        public int? InspectorID { get; set; }

        /// <summary>
        /// Whether the inspection has been completed
        /// </summary>
        public bool IsCompleted { get; set; }
    }
}
