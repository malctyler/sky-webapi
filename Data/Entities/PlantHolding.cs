using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using sky_webapi.Data.Entities;

namespace sky_webapi.Data.Entities
{
    public class PlantHolding
    {
        [Key]
        public int HoldingID { get; set; }
        public int? CustID { get; set; }
        public int? PlantNameID { get; set; }
        public string? SerialNumber { get; set; }
        public int? StatusID { get; set; }
        public string? SWL { get; set; }
        public string? InspectionFrequency { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? InspectionFee { get; set; }

        // Navigation properties
        [ForeignKey("CustID")]
        public virtual CustomerEntity? Customer { get; set; }

        [ForeignKey("PlantNameID")]
        public virtual AllPlantEntity? Plant { get; set; }

        [ForeignKey("StatusID")]
        public virtual Status? Status { get; set; }
    }
}
