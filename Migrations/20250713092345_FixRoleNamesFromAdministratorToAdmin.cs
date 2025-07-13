using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class FixRoleNamesFromAdministratorToAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJR8E4GFjDQhs/An1R/wNVqpLtWHpsjdPrLXNx0AUHYl1xeqlnRgjGTJp1D2XU08Kw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFMsm6S3sBGLhcB3Bnr7P/jBFqtYhIbz9pXnrGg+1YmOvhr2eXbO5yGDYJolviK1hg==");
        }
    }
}
