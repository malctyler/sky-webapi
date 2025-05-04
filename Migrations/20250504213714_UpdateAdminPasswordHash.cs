using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminPasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6aa33e39-8591-4bff-9001-bc58c0313c89",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELPDyn6G7TKxOvThBltjPcf3ieDXUmVaZlKK3Q4Qf3jTIgyCFjPXDSOixax8c/UHVg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6aa33e39-8591-4bff-9001-bc58c0313c89",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE3S7J6n1bqSJs/HKhD1Rz0ZvAQbUviOqRHNnRlVUyKIE4wUkJqr3xxUzNAJ9JjO2Q==");
        }
    }
}
