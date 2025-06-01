using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlantHoldingsAndInspections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 1,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 2,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 3,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 4,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 5,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 6,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 7,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 8,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 9,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 10,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 11,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 12,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 13,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 14,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 15,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 16,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 17,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 18,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 19,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 20,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 21,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 22,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 23,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 24,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 25,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 26,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 27,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 28,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 29,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 30,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 31,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 32,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 33,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 34,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 35,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 36,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 37,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 38,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 39,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 40,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 41,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 42,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 43,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 44,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 45,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 46,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 47,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 48,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 49,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 50,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 51,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 52,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 53,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 54,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 55,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 56,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 57,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 58,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 59,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 60,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 61,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 62,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 63,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 64,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 65,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 66,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 67,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 68,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 69,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 70,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 71,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 72,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 73,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 74,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 75,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 76,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 77,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 78,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 79,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 80,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 81,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 82,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 83,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 84,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 85,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 86,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 87,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 88,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 89,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 90,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 91,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 92,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 93,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 94,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 95,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 96,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 97,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 98,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 99,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 100,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "500kg", "B2D4F6H8J0" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "300kg", "C3E5G7I9K1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "D4F6H8J0L2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "150kg", "E5G7I9K1M3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "F6H8J0L2N4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 6,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "500kg", "G7I9K1M3O5", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 7,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "300kg", "H8J0L2N4P6", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 8,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "N/A", "I9K1M3O5Q7" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 9,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "J0L2N4P6R8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 10,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 1, "2000kg", "K1M3O5Q7S9" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 11,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "500kg", "L2N4P6R8T0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 12,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "M3O5Q7S9U1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 13,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "N/A", "N4P6R8T0V2" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 14,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "O5Q7S9U1W3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 15,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "P6R8T0V2X4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 16,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "Q7S9U1W3Y5", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 17,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "R8T0V2X4Z6", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 18,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "S9U1W3Y5A7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 19,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "T0V2X4Z6B8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 20,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "U1W3Y5A7C9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 21,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "V2X4Z6B8D0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 22,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "300kg", "W3Y5A7C9E1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 23,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "X4Z6B8D0F2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 24,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "Y5A7C9E1G3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 25,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 1, "2000kg", "Z6B8D0F2H4" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 26,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "A7C9E1G3I5", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 27,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "300kg", "B8D0F2H4J6", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 28,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "C9E1G3I5K7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 29,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "D0F2H4J6L8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 30,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "2000kg", "E1G3I5K7M9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 31,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "500kg", "F2H4J6L8N0" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 32,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "G3I5K7M9O1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 33,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "N/A", "H4J6L8N0P2" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 34,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "150kg", "I5K7M9O1Q3" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 35,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "J6L8N0P2R4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 36,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "K7M9O1Q3S5", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 37,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "300kg", "L8N0P2R4T6" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 38,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "M9O1Q3S5U7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 39,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "150kg", "N0P2R4T6V8" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 40,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "O1Q3S5U7W9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 41,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "500kg", "P2R4T6V8X0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 42,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "Q3S5U7W9Y1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 43,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "N/A", "R4T6V8X0Z2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 44,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "S5U7W9Y1A3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 45,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "T6V8X0Z2B4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 46,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "U7W9Y1A3C5", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 47,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "V8X0Z2B4D6", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 48,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "N/A", "W9Y1A3C5E7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 49,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "150kg", "X0Z2B4D6F8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 50,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "2000kg", "Y1A3C5E7G9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 51,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "Z2B4D6F8H0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 52,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 3, "300kg", "A3C5E7G9I1" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 53,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "B4D6F8H0J2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 54,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "C5E7G9I1K3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 55,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 1, "2000kg", "D6F8H0J2L4" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 56,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "500kg", "E7G9I1K3M5" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 57,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "F8H0J2L4N6", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 58,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "G9I1K3M5O7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 59,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "H0J2L4N6P8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 60,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 1, "2000kg", "I1K3M5O7Q9" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 61,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "500kg", "J2L4N6P8R0" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 62,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "K3M5O7Q9S1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 63,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "L4N6P8R0T2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 64,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "150kg", "M5O7Q9S1U3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 65,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "N6P8R0T2V4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 66,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "O7Q9S1U3W5", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 67,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 3, "300kg", "P8R0T2V4X6" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 68,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "Q9S1U3W5Y7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 69,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "R0T2V4X6Z8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 70,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "S1U3W5Y7A9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 71,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "T2V4X6Z8B0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 72,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "U3W5Y7A9C1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 73,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "N/A", "V4X6Z8B0D2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 74,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "W5Y7A9C1E3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 75,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "X6Z8B0D2F4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 76,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "500kg", "Y7A9C1E3G5" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 77,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "300kg", "Z8B0D2F4H6" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 78,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "N/A", "A9C1E3G5I7" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 79,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "B0D2F4H6J8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 80,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "C1E3G5I7K9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 81,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "D2F4H6J8L0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 82,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "E3G5I7K9M1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 83,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "F4H6J8L0N2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 84,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "G5I7K9M1O3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 85,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "H6J8L0N2P4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 86,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "500kg", "I7K9M1O3Q5", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 87,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "J8L0N2P4R6", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 88,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "N/A", "K9M1O3Q5S7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 89,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "150kg", "L0N2P4R6T8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 90,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "M1O3Q5S7U9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 91,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "500kg", "N2P4R6T8V0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 92,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "O3Q5S7U9W1", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 93,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "N/A", "P4R6T8V0X2", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 94,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "Q5S7U9W1Y3", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 95,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 1, "2000kg", "R6T8V0X2Z4" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 96,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "500kg", "S7U9W1Y3A5" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 97,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "300kg", "T8V0X2Z4B6", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 98,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "N/A", "U9W1Y3A5C7" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 99,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "150kg", "V0X2Z4B6D8", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 100,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "2000kg", "W1Y3A5C7E9", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 1,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 2,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 3,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 4,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 5,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 6,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 7,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 8,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 9,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 10,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 11,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 12,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 13,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 14,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 15,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 16,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 17,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 18,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 19,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 20,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 21,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 22,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 23,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 24,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 25,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 26,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 27,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 28,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 29,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 30,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 31,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 32,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 33,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 34,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 35,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 36,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 37,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 38,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 39,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 40,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 41,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 42,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 43,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 44,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 45,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 46,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 47,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 48,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 49,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 50,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 51,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 52,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 53,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 54,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 55,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 56,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 57,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 58,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 59,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 60,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 61,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 62,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 63,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 64,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 65,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 66,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 67,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 68,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 69,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 70,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 71,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 72,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 73,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 74,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 75,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 76,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 77,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 78,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 79,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 80,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 81,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 82,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 83,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 84,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 85,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 86,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 87,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 88,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 89,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 90,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 91,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 92,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 93,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 94,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 95,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 96,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 97,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 98,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 99,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 100,
                columns: new[] { "InspectionDate", "LatestDate" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "Standard", "FESGJ0SG1I" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "LNJSB3UOFD", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "TBZF6YSGBL", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "AT20NFAB2W", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "1KXFBVSBPZ", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 6,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "ANJCZCQA2P", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 7,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "A3AACXB67Q", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 8,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "Standard", "BNFP2TOK6V" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 9,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "58LZFDQL1F", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 10,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "Standard", "VS91YZKT9X" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 11,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "7AHJBHVPD9", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 12,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "LL13AB46I7", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 13,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "Standard", "TWWGKGBI79" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 14,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "5GKUUZEVO5", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 15,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "8QT83EDAG7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 16,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "VOE686GMTW", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 17,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "0KMS2I5XGJ", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 18,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "XCP25287Q6", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 19,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "VHWSZD3MSZ", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 20,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "2UH7BCHLGK", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 21,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "QNQ1X9M4LG", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 22,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "WN8CQ5L756", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 23,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "UA6OYX9K71", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 24,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "XBYSNMHVXV", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 25,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "Standard", "DE4K9MAUMF" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 26,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "D8GXHXX4MW", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 27,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "H2TTYOX9ZI", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 28,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "3YLV1Q9S4B", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 29,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "FUOA8QLRZO", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 30,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "2Q67SH85WX", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 31,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 3, "Standard", "LCD6W7UFNE" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 32,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "AXAI633OVE", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 33,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "Standard", "TBAXDT2SZ6" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 34,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "Standard", "MO42473XD2" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 35,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "GZ833P6HJ3", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 36,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "77C4M4OD9E", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 37,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "Standard", "8BTXLEH0EF" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 38,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "U9ZJ9RWTBK", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 39,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "Standard", "58LIO35B3Q" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 40,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "6J5FWWQ1QY", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 41,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "FEDRSMQYFW", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 42,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "38MKKOTDF7", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 43,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "VR6P3ERHY8", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 44,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "ZNTR9FWJRS", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 45,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "JGRBEGIH0N", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 46,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "PB5BFUY55B", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 47,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "5CE9KEJCFI", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 48,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "WPCS05UMRS", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 49,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "KVD64Q2IWU", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 50,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "BI7VD35G5H", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 51,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "RFF9RHOMBG", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 52,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "Standard", "ANIYQ7BBJB" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 53,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "88JYW4CCGN", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 54,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "L31OF3A5TH", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 55,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "Standard", "VG08GNRQZX" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 56,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 3, "Standard", "800HEWTW8T" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 57,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "GW5PAV81NT", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 58,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "DD62689X3I", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 59,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "C317Y82B3E", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 60,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 3, "Standard", "RBPDZIEOXL" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 61,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 1, "Standard", "Z009TZ37GQ" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 62,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "4BDP1BV9LN", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 63,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "S58UDB11Z0", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 64,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "I2SDL5NBYH", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 65,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "FZXWZEZMP4", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 66,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "0I3EYVSD3F", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 67,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 5, "Standard", "SRYQ9JHLVK" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 68,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "NFCVB4SNL4", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 69,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "BIMDZG49TZ", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 70,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "QJMFXFCQ3P", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 71,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "T6B9X2XYEV", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 72,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "7EVPQP4YC4", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 73,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "RM0F26IVR3", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 74,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "F5M0BOC44V", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 75,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "UXAOVCQY1J", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 76,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "Standard", "CS6IM2KDU3" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 77,
                columns: new[] { "SWL", "SerialNumber" },
                values: new object[] { "Standard", "CEXX2K76EG" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 78,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 1, "Standard", "63AON5A6NB" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 79,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "S4RCKE90NP", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 80,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "P35QLUF571", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 81,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "160Y2NHAQE", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 82,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "35WAH41QRU", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 83,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "AUU362V0R8", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 84,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "NL89HLALX7", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 85,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 3, "Standard", "8FYCA5BH7G", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 86,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "2NEYSPQ4VI", 4 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 87,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "51JGTX6C6F", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 88,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "DS0W7CQHX0", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 89,
                columns: new[] { "SWL", "SerialNumber", "StatusID" },
                values: new object[] { "Standard", "HM2IQ24ZS2", 2 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 90,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "W4XJKVLXSN", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 91,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "Y47S1PIEVP", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 92,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "5YVDLFIKLS", 5 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 93,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 1, "Standard", "PG7BPTL412", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 94,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 4, "Standard", "5M8DTCWH5Q", 3 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 95,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 4, "Standard", "9HMNEJYG45" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 96,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 3, "Standard", "RGZBDFQCE9" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 97,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "GE1I52G81L", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 98,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber" },
                values: new object[] { 2, "Standard", "H8ZREN1AJN" });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 99,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 2, "Standard", "NVD0AMRA8N", 1 });

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 100,
                columns: new[] { "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[] { 5, "Standard", "SPKCYE2GEQ", 5 });
        }
    }
}
