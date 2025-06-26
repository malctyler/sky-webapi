using System;
using System.ComponentModel.DataAnnotations;

namespace sky_webapi.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters")]
        public string Password { get; set; } = string.Empty;
    }

    public class SecureLoginDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password hash is required")]
        [StringLength(128, MinimumLength = 16, ErrorMessage = "Password hash must be between 16 and 128 characters")]
        [RegularExpression(@"^[A-Za-z0-9+/=]+$", ErrorMessage = "Password hash must be a valid Base64 string")]
        public string PasswordHash { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nonce is required")]
        [StringLength(32, MinimumLength = 16, ErrorMessage = "Nonce must be between 16 and 32 characters")]
        [RegularExpression(@"^[A-Za-z0-9+/=]+$", ErrorMessage = "Nonce must be a valid Base64 string")]
        public string Nonce { get; set; } = string.Empty;

        [Range(1, long.MaxValue, ErrorMessage = "Timestamp must be a positive value")]
        public long Timestamp { get; set; }
    }

    public class RegisterDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", 
            ErrorMessage = "Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "First name can only contain letters, spaces, hyphens, apostrophes, and periods")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Last name must be between 1 and 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "Last name can only contain letters, spaces, hyphens, apostrophes, and periods")]
        public string LastName { get; set; } = string.Empty;

        public bool IsCustomer { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Customer ID must be a positive value")]
        public int? CustomerId { get; set; }

        public bool EmailConfirmed { get; set; }
    }

    public class AuthResponseDto
    {
        [Required]
        public string Id { get; set; } = string.Empty;

        [Required]
        public string Token { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(254)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        public List<string> Roles { get; set; } = new List<string>();
        
        public bool IsCustomer { get; set; }
        
        public bool EmailConfirmed { get; set; }
        
        public int? CustomerId { get; set; }
    }

    public class ChangePasswordDto
    {
        [Required(ErrorMessage = "Current password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Current password must be between 8 and 100 characters")]
        public string CurrentPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "New password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "New password must be between 8 and 100 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", 
            ErrorMessage = "New password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character")]
        public string NewPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password confirmation is required")]
        [Compare("NewPassword", ErrorMessage = "New password and confirmation password do not match")]
        public string ConfirmNewPassword { get; set; } = string.Empty;
    }

    public class UserDto
    {
        [Required]
        public required string Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(254)]
        public required string Email { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "First name can only contain letters, spaces, hyphens, apostrophes, and periods")]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "Last name can only contain letters, spaces, hyphens, apostrophes, and periods")]
        public required string LastName { get; set; }

        public bool IsCustomer { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Customer ID must be a positive value")]
        public int? CustomerId { get; set; }

        public bool EmailConfirmed { get; set; }
    }

    public class RoleAssignmentDto
    {
        [Required(ErrorMessage = "Role name is required")]
        [StringLength(256, MinimumLength = 1, ErrorMessage = "Role name must be between 1 and 256 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_\.]+$", ErrorMessage = "Role name can only contain letters, numbers, spaces, hyphens, underscores, and periods")]
        public required string RoleName { get; set; }
    }

    public class RoleDto
    {
        [Required]
        public required string Id { get; set; }

        [Required]
        [StringLength(256)]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_\.]+$", ErrorMessage = "Role name can only contain letters, numbers, spaces, hyphens, underscores, and periods")]
        public required string Name { get; set; }
    }

    public class ClaimDto
    {
        [Required(ErrorMessage = "Claim type is required")]
        [StringLength(256, MinimumLength = 1, ErrorMessage = "Claim type must be between 1 and 256 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\-_\.:/]+$", ErrorMessage = "Claim type contains invalid characters")]
        public string Type { get; set; } = string.Empty;

        [Required(ErrorMessage = "Claim value is required")]
        [StringLength(1024, MinimumLength = 1, ErrorMessage = "Claim value must be between 1 and 1024 characters")]
        public string Value { get; set; } = string.Empty;
    }

    public class ResetUserPasswordDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "New password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "New password must be between 8 and 100 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", 
            ErrorMessage = "New password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character")]
        public string NewPassword { get; set; } = string.Empty;
    }

    public class ConfirmUserDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public string Email { get; set; } = string.Empty;
    }
}