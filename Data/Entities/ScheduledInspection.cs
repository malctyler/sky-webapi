using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sky_webapi.Data.Entities
{
    public class ScheduledInspection
    {        [Key]
        public int Id { get; set; }
        public int HoldingID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string? Location { get; set; }
        public int? InspectorID { get; set; }
        public bool IsCompleted { get; set; }

        // Navigation properties
        [ForeignKey("HoldingID")]
        public virtual PlantHolding? PlantHolding { get; set; }
        
        [ForeignKey("InspectorID")]
        public virtual InspectorEntity? Inspector { get; set; }
    }
}
