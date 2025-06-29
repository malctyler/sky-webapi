using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class FixRoleSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert roles only if they don't already exist
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM AspNetRoles WHERE Id = 'd4b74547-1385-4c44-88ab-1b3dd647be9c')
                BEGIN
                    INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp)
                    VALUES ('d4b74547-1385-4c44-88ab-1b3dd647be9c', 'Admin', 'ADMIN', '79202516-5691-4c00-8fdc-5c472cc112a1')
                END
                
                IF NOT EXISTS (SELECT 1 FROM AspNetRoles WHERE Id = '64f2f5e1-e472-4e90-8158-9d60b5b7d0fe')
                BEGIN
                    INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp)
                    VALUES ('64f2f5e1-e472-4e90-8158-9d60b5b7d0fe', 'Staff', 'STAFF', '8920f4b6-7671-4c8b-9c5d-1f23fe76f236')
                END
                
                IF NOT EXISTS (SELECT 1 FROM AspNetRoles WHERE Id = '7f3d65e1-e472-4e90-8158-9d60b5b7d123')
                BEGIN
                    INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp)
                    VALUES ('7f3d65e1-e472-4e90-8158-9d60b5b7d123', 'Customer', 'CUSTOMER', '55f53c36-8b15-4ef1-a7d2-94946c14c716')
                END
            ");

            // Insert admin user only if it doesn't already exist
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM AspNetUsers WHERE Id = '6aa33e39-8591-4bff-9001-bc58c0313c89')
                BEGIN
                    INSERT INTO AspNetUsers (Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, FirstName, LastName, IsCustomer)
                    VALUES ('6aa33e39-8591-4bff-9001-bc58c0313c89', 'admin@example.com', 'ADMIN@EXAMPLE.COM', 'admin@example.com', 'ADMIN@EXAMPLE.COM', 1, 'AQAAAAIAAYagAAAAELPDyn6G7TKxOvThBltjPcf3ieDXUmVaZlKK3Q4Qf3jTIgyCFjPXDSOixax8c/UHVg==', 'JIRVGNRNQ7Z3TPFRS4YPFN5QVMPXQY2K', '42a75722-9d32-4242-9eac-0d0c5a80e63a', 'Admin', 'User', 0)
                END
            ");

            // Assign admin role to admin user only if not already assigned
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM AspNetUserRoles WHERE UserId = '6aa33e39-8591-4bff-9001-bc58c0313c89' AND RoleId = 'd4b74547-1385-4c44-88ab-1b3dd647be9c')
                BEGIN
                    INSERT INTO AspNetUserRoles (UserId, RoleId)
                    VALUES ('6aa33e39-8591-4bff-9001-bc58c0313c89', 'd4b74547-1385-4c44-88ab-1b3dd647be9c')
                END
                
                IF NOT EXISTS (SELECT 1 FROM AspNetUserRoles WHERE UserId = '6aa33e39-8591-4bff-9001-bc58c0313c89' AND RoleId = '64f2f5e1-e472-4e90-8158-9d60b5b7d0fe')
                BEGIN
                    INSERT INTO AspNetUserRoles (UserId, RoleId)
                    VALUES ('6aa33e39-8591-4bff-9001-bc58c0313c89', '64f2f5e1-e472-4e90-8158-9d60b5b7d0fe')
                END
            ");

            // Add admin user claims only if they don't exist
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM AspNetUserClaims WHERE UserId = '6aa33e39-8591-4bff-9001-bc58c0313c89' AND ClaimType = 'IsCustomer')
                BEGIN
                    INSERT INTO AspNetUserClaims (UserId, ClaimType, ClaimValue)
                    VALUES ('6aa33e39-8591-4bff-9001-bc58c0313c89', 'IsCustomer', 'False')
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove the seeded data in reverse order
            migrationBuilder.Sql("DELETE FROM AspNetUserClaims WHERE UserId = '6aa33e39-8591-4bff-9001-bc58c0313c89' AND ClaimType = 'IsCustomer'");
            migrationBuilder.Sql("DELETE FROM AspNetUserRoles WHERE UserId = '6aa33e39-8591-4bff-9001-bc58c0313c89'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Id = '6aa33e39-8591-4bff-9001-bc58c0313c89'");
            migrationBuilder.Sql("DELETE FROM AspNetRoles WHERE Id IN ('d4b74547-1385-4c44-88ab-1b3dd647be9c', '64f2f5e1-e472-4e90-8158-9d60b5b7d0fe', '7f3d65e1-e472-4e90-8158-9d60b5b7d123')");
        }
    }
}
