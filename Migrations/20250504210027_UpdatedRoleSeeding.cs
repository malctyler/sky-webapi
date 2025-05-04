using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRoleSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4b74547-1385-4c44-88ab-1b3dd647be9c",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "8920f4b6-7671-4c8b-9c5d-1f23fe76f236", "Staff", "STAFF" },
                    { "7f3d65e1-e472-4e90-8158-9d60b5b7d123", "55f53c36-8b15-4ef1-a7d2-94946c14c716", "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f3d65e1-e472-4e90-8158-9d60b5b7d123");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4b74547-1385-4c44-88ab-1b3dd647be9c",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Staff", "STAFF" });
        }
    }
}
