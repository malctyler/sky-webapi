using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using sky_webapi.Data.Entities;

namespace sky_webapi.Data
{
    public static class DatabaseSeeder
    {
        private const string AdminRoleId = "d4b74547-1385-4c44-88ab-1b3dd647be9c";
        private const string StaffRoleId = "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe";
        private const string CustomerRoleId = "7f3d65e1-e472-4e90-8158-9d60b5b7d123";
        private const string AdminUserId = "6aa33e39-8591-4bff-9001-bc58c0313c89";
        private const string AdminRoleConcurrencyStamp = "79202516-5691-4c00-8fdc-5c472cc112a1";
        private const string StaffRoleConcurrencyStamp = "8920f4b6-7671-4c8b-9c5d-1f23fe76f236";
        private const string CustomerRoleConcurrencyStamp = "55f53c36-8b15-4ef1-a7d2-94946c14c716";
        private const string AdminUserConcurrencyStamp = "42a75722-9d32-4242-9eac-0d0c5a80e63a";
        private const string AdminUserSecurityStamp = "JIRVGNRNQ7Z3TPFRS4YPFN5QVMPXQY2K";
        // Pre-hashed password for "Admin123!" - Compatible with ASP.NET Core Identity v9
        private const string AdminPasswordHash = "AQAAAAIAAYagAAAAELPDyn6G7TKxOvThBltjPcf3ieDXUmVaZlKK3Q4Qf3jTIgyCFjPXDSOixax8c/UHVg==";

        public static void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Summaries
            modelBuilder.Entity<Summary>().HasData(
                new Summary { Id = 1, Description = "Freezing" },
                new Summary { Id = 2, Description = "Bracing" },
                new Summary { Id = 3, Description = "Chilly" },
                new Summary { Id = 4, Description = "Cool" },
                new Summary { Id = 5, Description = "Mild" },
                new Summary { Id = 6, Description = "Warm" },
                new Summary { Id = 7, Description = "Balmy" },
                new Summary { Id = 8, Description = "Hot" },
                new Summary { Id = 9, Description = "Sweltering" },
                new Summary { Id = 10, Description = "Scorching" }
            );

            // Seed Plant Categories
            modelBuilder.Entity<PlantCategoryEntity>().HasData(
                new PlantCategoryEntity { CategoryID = 1, CategoryDescription = "Heavy Plant" },
                new PlantCategoryEntity { CategoryID = 2, CategoryDescription = "Small Plant" },
                new PlantCategoryEntity { CategoryID = 3, CategoryDescription = "Access Equipment" },
                new PlantCategoryEntity { CategoryID = 4, CategoryDescription = "Power Tools" },
                new PlantCategoryEntity { CategoryID = 5, CategoryDescription = "Safety Equipment" }
            );

            // Seed Status
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusID = 1, StatusDescription = "Available" },
                new Status { StatusID = 2, StatusDescription = "In Use" },
                new Status { StatusID = 3, StatusDescription = "Under Maintenance" },
                new Status { StatusID = 4, StatusDescription = "Out of Service" },
                new Status { StatusID = 5, StatusDescription = "Reserved" }
            );

            // Seed Inspectors
            modelBuilder.Entity<InspectorEntity>().HasData(
                new InspectorEntity { InspectorID = 1, InspectorsName = "Allen Lee" },
                new InspectorEntity { InspectorID = 2, InspectorsName = "Aidan Lee" }
            );

            // Seed Customers (keeping existing logic)
            var customers = new List<CustomerEntity>();
            var notes = new List<NoteEntity>();

            for (int i = 1; i <= 100; i++)
            {
                char letter = (char)((i % 26) + 65);
                customers.Add(new CustomerEntity
                {
                    CustID = i,
                    CompanyName = $"Company {letter}",
                    ContactTitle = "Mr.",
                    ContactFirstNames = "John",
                    ContactSurname = "Doe",
                    Line1 = "123 Main St",
                    Line2 = "",
                    Line3 = "",
                    Line4 = "",
                    Postcode = "12345",
                    Telephone = "123-456-7890",
                    Fax = "123-456-7891",
                    Email = "john.doe@companya.com"
                });

                notes.Add(new NoteEntity
                {
                    NoteID = i,
                    CustID = i,
                    Date = new DateTime(2023, 1, 1),
                    Notes = $"Dummy note 1 for customer {i}"
                });
                notes.Add(new NoteEntity
                {
                    NoteID = i + 100,
                    CustID = i,
                    Date = new DateTime(2023, 1, 2),
                    Notes = $"Dummy note 2 for customer {i}"
                });
            }

            // Add sample plant
            modelBuilder.Entity<AllPlantEntity>().HasData(
                new AllPlantEntity { PlantNameID = 1, PlantDescription = "Excavator 2T", PlantCategory = 1, NormalPrice = "150.00" },
                new AllPlantEntity { PlantNameID = 2, PlantDescription = "Scissor Lift", PlantCategory = 3, NormalPrice = "95.00" },
                new AllPlantEntity { PlantNameID = 3, PlantDescription = "Concrete Mixer", PlantCategory = 2, NormalPrice = "45.00" },
                new AllPlantEntity { PlantNameID = 4, PlantDescription = "Power Drill", PlantCategory = 4, NormalPrice = "25.00" },
                new AllPlantEntity { PlantNameID = 5, PlantDescription = "Safety Harness", PlantCategory = 5, NormalPrice = "15.00" }
            );

            // Add sample plant holdings
            var plantHoldings = new List<PlantHolding>();
            for (int i = 1; i <= 100; i++) // One holding per customer
            {
                var plantId = (i % 5) + 1; // Cycles through plant IDs 1-5
                var statusId = (i % 5) + 1; // Cycles through status IDs 1-5
                
                // Generate a 10-character alphanumeric serial number
                var serialNumber = string.Concat(Enumerable.Range(0, 10)
                    .Select(x => x % 2 == 0 ? 
                        ((char)('A' + (i + x) % 26)).ToString() : 
                        ((i + x) % 10).ToString()));

                plantHoldings.Add(new PlantHolding 
                { 
                    HoldingID = i,
                    CustID = i,
                    PlantNameID = plantId,
                    SerialNumber = serialNumber,
                    StatusID = statusId,
                    SWL = plantId switch
                    {
                        1 => "2000kg", // Heavy Plant
                        2 => "500kg",  // Small Plant
                        3 => "300kg",  // Access Equipment
                        4 => "N/A",    // Power Tools
                        _ => "150kg"    // Safety Equipment
                    }
                });
            }

            modelBuilder.Entity<PlantHolding>().HasData(plantHoldings);

            // Add sample inspections with dates spread across the last year
            var inspections = new List<Inspection>();
            var baseDate = new DateTime(2025, 6, 1); // Current date from context

            for (int i = 1; i <= 100; i++)
            {
                var monthsAgo = i % 12; // Spreads inspections across the last year
                inspections.Add(new Inspection
                {
                    UniqueRef = i,
                    HoldingID = i,
                    InspectorID = (i % 2) + 1, // Alternates between inspector 1 and 2
                    InspectionDate = baseDate.AddMonths(-monthsAgo),
                    Location = $"Site {i}",
                    RecentCheck = "Completed",
                    PreviousCheck = "N/A",
                    SafeWorking = "Yes",
                    Defects = "None",
                    Rectified = "N/A",
                    LatestDate = baseDate.AddMonths(-monthsAgo),
                    TestDetails = "Standard inspection completed",
                    MiscNotes = $"Annual inspection for plant holding {i}"
                });
            }

            modelBuilder.Entity<Inspection>().HasData(inspections);

            modelBuilder.Entity<CustomerEntity>().HasData(customers);

            // Seed initial roles with static GUIDs
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = AdminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = AdminRoleConcurrencyStamp
                },
                new IdentityRole
                {
                    Id = StaffRoleId,
                    Name = "Staff",
                    NormalizedName = "STAFF",
                    ConcurrencyStamp = StaffRoleConcurrencyStamp
                },
                new IdentityRole
                {
                    Id = CustomerRoleId,
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    ConcurrencyStamp = CustomerRoleConcurrencyStamp
                }
            );

            // Seed initial admin user with static values
            var adminUser = new ApplicationUser
            {
                Id = AdminUserId,
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = AdminPasswordHash,
                SecurityStamp = AdminUserSecurityStamp,
                ConcurrencyStamp = AdminUserConcurrencyStamp,
                FirstName = "Admin",
                LastName = "User",
                IsCustomer = false
            };

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Assign admin role to admin user (now using AdminRoleId)
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = AdminUserId,
                    RoleId = AdminRoleId  // Note: Changed from Staff to Admin role
                },
                new IdentityUserRole<string>
                {
                    UserId = AdminUserId,
                    RoleId = StaffRoleId
                }
            );

            // Add admin user claims
            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
                new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = AdminUserId,
                    ClaimType = "IsCustomer",
                    ClaimValue = "False"
                }
            );
        }
    }
}
