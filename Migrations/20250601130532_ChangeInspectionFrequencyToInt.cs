using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeInspectionFrequencyToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InspectionFrequency",
                table: "PlantHoldings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1,
                column: "InspectionFrequency",
                value: 12);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2,
                column: "InspectionFrequency",
                value: 12);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3,
                column: "InspectionFrequency",
                value: 12);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4,
                column: "InspectionFrequency",
                value: 12);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5,
                column: "InspectionFrequency",
                value: 12);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InspectionFrequency",
                table: "PlantHoldings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1,
                column: "InspectionFrequency",
                value: null);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2,
                column: "InspectionFrequency",
                value: null);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3,
                column: "InspectionFrequency",
                value: null);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4,
                column: "InspectionFrequency",
                value: null);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5,
                column: "InspectionFrequency",
                value: null);
        }
    }
}
