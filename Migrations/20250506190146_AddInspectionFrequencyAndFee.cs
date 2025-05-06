using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddInspectionFrequencyAndFee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "InspectionFee",
                table: "PlantHoldings",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectionFrequency",
                table: "PlantHoldings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1,
                columns: new[] { "InspectionFee", "InspectionFrequency" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2,
                columns: new[] { "InspectionFee", "InspectionFrequency" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3,
                columns: new[] { "InspectionFee", "InspectionFrequency" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4,
                columns: new[] { "InspectionFee", "InspectionFrequency" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5,
                columns: new[] { "InspectionFee", "InspectionFrequency" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.DropColumn(
                name: "InspectionFee",
                table: "PlantHoldings");

            migrationBuilder.DropColumn(
                name: "InspectionFrequency",
                table: "PlantHoldings");
        }
    }
}
