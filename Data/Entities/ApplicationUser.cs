using Microsoft.AspNetCore.Identity;

namespace sky_webapi.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsCustomer { get; set; }
        public int? CustomerId { get; set; }  // Optional link to Customer table
    }
}