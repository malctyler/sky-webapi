using System.ComponentModel.DataAnnotations;

namespace sky_webapi.Data.Entities
{
    public class RevokedToken
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string TokenId { get; set; } = string.Empty; // JWT "jti" claim
        
        [Required]
        public string UserId { get; set; } = string.Empty;
        
        [Required]
        public DateTime RevokedAt { get; set; }
        
        [Required]
        public DateTime ExpiresAt { get; set; } // Original token expiration
        
        public string? Reason { get; set; } // "logout", "security_breach", etc.
        
        public string? RevokedBy { get; set; } // IP address or user action
    }
}
