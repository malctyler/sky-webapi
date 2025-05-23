using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sky_webapi.Data.Entities
{
    [Table("PlantCategories")]
    public class PlantCategoryEntity
    {
        [Key]
        public int CategoryID { get; set; }
        
        [MaxLength(50)]
        public string? CategoryDescription { get; set; }

        // Navigation property
        public virtual ICollection<AllPlantEntity>? plant { get; set; }
    }
}
