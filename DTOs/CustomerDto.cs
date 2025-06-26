using System.ComponentModel.DataAnnotations;

namespace sky_webapi.DTOs
{
    public class CustomerDto
    {
        public int CustID { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Company name must be between 2 and 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-'&\.\(\),]+$", ErrorMessage = "Company name contains invalid characters")]
        public string CompanyName { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "Contact title cannot exceed 20 characters")]
        [RegularExpression(@"^[a-zA-Z\s\.]+$", ErrorMessage = "Contact title can only contain letters, spaces, and periods")]
        public string? ContactTitle { get; set; }

        [Required(ErrorMessage = "Contact first name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "Names can only contain letters, spaces, hyphens, apostrophes, and periods")]
        public string ContactFirstNames { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact surname is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Surname must be between 1 and 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "Names can only contain letters, spaces, hyphens, apostrophes, and periods")]
        public string ContactSurname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address line 1 is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Address line 1 must be between 3 and 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-'&\.\(\),/]+$", ErrorMessage = "Address line 1 contains invalid characters")]
        public string Line1 { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Address line 2 cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-'&\.\(\),/]*$", ErrorMessage = "Address line 2 contains invalid characters")]
        public string? Line2 { get; set; }

        [StringLength(100, ErrorMessage = "Address line 3 cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-'&\.\(\),/]*$", ErrorMessage = "Address line 3 contains invalid characters")]
        public string? Line3 { get; set; }

        [StringLength(100, ErrorMessage = "Address line 4 cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-'&\.\(\),/]*$", ErrorMessage = "Address line 4 contains invalid characters")]
        public string? Line4 { get; set; }

        [Required(ErrorMessage = "Postcode is required")]
        [RegularExpression(@"^[A-Z]{1,2}[0-9R][0-9A-Z]?\s?[0-9][A-Z]{2}$", ErrorMessage = "Please enter a valid UK postcode")]
        public string Postcode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telephone number is required")]
        [RegularExpression(@"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}$|^(\+44\s?1\d{3}|\(?01\d{3}\)?)\s?\d{6}$|^(\+44\s?1\d{2}|\(?01\d{2}\)?)\s?\d{7}$|^(\+44\s?20|\(?020\)?)\s?\d{4}\s?\d{4}$", ErrorMessage = "Please enter a valid UK telephone number")]
        public string Telephone { get; set; } = string.Empty;

        [RegularExpression(@"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}$|^(\+44\s?1\d{3}|\(?01\d{3}\)?)\s?\d{6}$|^(\+44\s?1\d{2}|\(?01\d{2}\)?)\s?\d{7}$|^(\+44\s?20|\(?020\)?)\s?\d{4}\s?\d{4}$", ErrorMessage = "Please enter a valid UK fax number")]
        public string? Fax { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(254, ErrorMessage = "Email address cannot exceed 254 characters")]
        public string? Email { get; set; }
    }
}
