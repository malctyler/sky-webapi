using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sky_webapi.Data.Entities
{
    public class CustomerEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? ContactTitle { get; set; }

        [Required]
        [MaxLength(50)]
        public string ContactFirstNames { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string ContactSurname { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Line1 { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Line2 { get; set; }

        [MaxLength(100)]
        public string? Line3 { get; set; }

        [MaxLength(100)]
        public string? Line4 { get; set; }

        [Required]
        [MaxLength(10)]  // UK postcodes are max 8 chars but allowing some buffer
        public string Postcode { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]  // UK phone numbers with formatting
        public string Telephone { get; set; } = string.Empty;

        [MaxLength(50)]  // UK fax numbers with formatting
        public string? Fax { get; set; }

        [MaxLength(254)]  // RFC compliant email length
        public string? Email { get; set; }

        public virtual ICollection<NoteEntity>? Notes { get; set; }
    }
}
