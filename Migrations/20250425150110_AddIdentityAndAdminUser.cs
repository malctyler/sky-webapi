using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityAndAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "79202516-5691-4c00-8fdc-5c472cc112a1", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "FirstName", "IsCustomer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6aa33e39-8591-4bff-9001-bc58c0313c89", 0, "42a75722-9d32-4242-9eac-0d0c5a80e63a", null, "admin@example.com", true, "Admin", false, "User", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE3S7J6n1bqSJs/HKhD1Rz0ZvAQbUviOqRHNnRlVUyKIE4wUkJqr3xxUzNAJ9JjO2Q==", null, false, "JIRVGNRNQ7Z3TPFRS4YPFN5QVMPXQY2K", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "IsCustomer", "False", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "6aa33e39-8591-4bff-9001-bc58c0313c89" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4b74547-1385-4c44-88ab-1b3dd647be9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6aa33e39-8591-4bff-9001-bc58c0313c89");
        }
    }
}
