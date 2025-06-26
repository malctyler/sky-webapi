using System.ComponentModel.DataAnnotations;

namespace sky_webapi.DTOs
{
    public class ForgotPasswordDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public required string Email { get; set; }
    }

    public class ResetPasswordDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Reset token is required")]
        [StringLength(1024, MinimumLength = 16, ErrorMessage = "Reset token must be between 16 and 1024 characters")]
        public required string Token { get; set; }

        [Required(ErrorMessage = "New password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "New password must be between 8 and 100 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", 
            ErrorMessage = "New password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character")]
        public required string NewPassword { get; set; }
    }
}
