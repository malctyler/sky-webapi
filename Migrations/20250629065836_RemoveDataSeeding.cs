using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f3d65e1-e472-4e90-8158-9d60b5b7d123");

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Inspections",
                keyColumn: "UniqueRef",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4b74547-1385-4c44-88ab-1b3dd647be9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6aa33e39-8591-4bff-9001-bc58c0313c89");

            migrationBuilder.DeleteData(
                table: "Inspectors",
                keyColumn: "InspectorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inspectors",
                keyColumn: "InspectorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "8920f4b6-7671-4c8b-9c5d-1f23fe76f236", "Staff", "STAFF" },
                    { "7f3d65e1-e472-4e90-8158-9d60b5b7d123", "55f53c36-8b15-4ef1-a7d2-94946c14c716", "Customer", "CUSTOMER" },
                    { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "79202516-5691-4c00-8fdc-5c472cc112a1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "FirstName", "IsCustomer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6aa33e39-8591-4bff-9001-bc58c0313c89", 0, "42a75722-9d32-4242-9eac-0d0c5a80e63a", null, "admin@example.com", true, "Admin", false, "User", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELPDyn6G7TKxOvThBltjPcf3ieDXUmVaZlKK3Q4Qf3jTIgyCFjPXDSOixax8c/UHVg==", null, false, "JIRVGNRNQ7Z3TPFRS4YPFN5QVMPXQY2K", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustID", "CompanyName", "ContactFirstNames", "ContactSurname", "ContactTitle", "Email", "Fax", "Line1", "Line2", "Line3", "Line4", "Postcode", "Telephone" },
                values: new object[,]
                {
                    { 1, "Company A", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N7 5SL", "123-456-7890" },
                    { 2, "Company B", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BS1 9CL", "123-456-7890" },
                    { 3, "Company C", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO14 2OF", "123-456-7890" },
                    { 4, "Company D", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E6 1VD", "123-456-7890" },
                    { 5, "Company E", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E6 1NW", "123-456-7890" },
                    { 6, "Company F", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW10 4YO", "123-456-7890" },
                    { 7, "Company G", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N10 7EP", "123-456-7890" },
                    { 8, "Company H", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW10 5UT", "123-456-7890" },
                    { 9, "Company I", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N8 3BA", "123-456-7890" },
                    { 10, "Company J", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E10 5DZ", "123-456-7890" },
                    { 11, "Company K", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL1 4XW", "123-456-7890" },
                    { 12, "Company L", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N5 9UW", "123-456-7890" },
                    { 13, "Company M", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N6 5AV", "123-456-7890" },
                    { 14, "Company N", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW10 2SX", "123-456-7890" },
                    { 15, "Company O", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E3 1TV", "123-456-7890" },
                    { 16, "Company P", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN3 8LA", "123-456-7890" },
                    { 17, "Company Q", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E6 7TR", "123-456-7890" },
                    { 18, "Company R", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N7 2JX", "123-456-7890" },
                    { 19, "Company S", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO16 4JE", "123-456-7890" },
                    { 20, "Company T", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN4 4OP", "123-456-7890" },
                    { 21, "Company U", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN4 9AM", "123-456-7890" },
                    { 22, "Company V", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E7 1UY", "123-456-7890" },
                    { 23, "Company W", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BS1 7OJ", "123-456-7890" },
                    { 24, "Company X", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "EX2 7GS", "123-456-7890" },
                    { 25, "Company Y", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N5 4HT", "123-456-7890" },
                    { 26, "Company Z", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO17 1ZP", "123-456-7890" },
                    { 27, "Company A2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N6 1CD", "123-456-7890" },
                    { 28, "Company B2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "CT2 2HQ", "123-456-7890" },
                    { 29, "Company C2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N7 6HJ", "123-456-7890" },
                    { 30, "Company D2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E3 2MM", "123-456-7890" },
                    { 31, "Company E2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E9 9PC", "123-456-7890" },
                    { 32, "Company F2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BS4 2JX", "123-456-7890" },
                    { 33, "Company G2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL3 3RA", "123-456-7890" },
                    { 34, "Company H2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN3 5ZW", "123-456-7890" },
                    { 35, "Company I2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW10 1BA", "123-456-7890" },
                    { 36, "Company J2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BS4 4VS", "123-456-7890" },
                    { 37, "Company K2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BS3 3WL", "123-456-7890" },
                    { 38, "Company L2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TR3 8NP", "123-456-7890" },
                    { 39, "Company M2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "ME2 5RA", "123-456-7890" },
                    { 40, "Company N2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "EX2 5BF", "123-456-7890" },
                    { 41, "Company O2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TR3 9GL", "123-456-7890" },
                    { 42, "Company P2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN1 8TO", "123-456-7890" },
                    { 43, "Company Q2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PO2 7AC", "123-456-7890" },
                    { 44, "Company R2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N7 4RQ", "123-456-7890" },
                    { 45, "Company S2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO17 1HM", "123-456-7890" },
                    { 46, "Company T2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO16 2IU", "123-456-7890" },
                    { 47, "Company U2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N4 6UK", "123-456-7890" },
                    { 48, "Company V2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "EX4 7KC", "123-456-7890" },
                    { 49, "Company W2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL4 6EY", "123-456-7890" },
                    { 50, "Company X2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW8 6MH", "123-456-7890" },
                    { 51, "Company Y2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PO2 8BY", "123-456-7890" },
                    { 52, "Company Z2", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "CT3 5TH", "123-456-7890" },
                    { 53, "Company A3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "ME2 4WA", "123-456-7890" },
                    { 54, "Company B3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E9 6CQ", "123-456-7890" },
                    { 55, "Company C3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL2 1LP", "123-456-7890" },
                    { 56, "Company D3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E8 3UO", "123-456-7890" },
                    { 57, "Company E3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN2 2HJ", "123-456-7890" },
                    { 58, "Company F3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW7 7LY", "123-456-7890" },
                    { 59, "Company G3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN4 8IR", "123-456-7890" },
                    { 60, "Company H3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL2 8AT", "123-456-7890" },
                    { 61, "Company I3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW9 4ZF", "123-456-7890" },
                    { 62, "Company J3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO17 7XH", "123-456-7890" },
                    { 63, "Company K3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN1 3TA", "123-456-7890" },
                    { 64, "Company L3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N2 3HZ", "123-456-7890" },
                    { 65, "Company M3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO14 5DN", "123-456-7890" },
                    { 66, "Company N3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E3 7ZJ", "123-456-7890" },
                    { 67, "Company O3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N3 1HX", "123-456-7890" },
                    { 68, "Company P3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "EX3 8GJ", "123-456-7890" },
                    { 69, "Company Q3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TR4 5CA", "123-456-7890" },
                    { 70, "Company R3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL2 7ZJ", "123-456-7890" },
                    { 71, "Company S3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BN2 1EN", "123-456-7890" },
                    { 72, "Company T3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL4 7NW", "123-456-7890" },
                    { 73, "Company U3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO15 8UG", "123-456-7890" },
                    { 74, "Company V3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO16 2RU", "123-456-7890" },
                    { 75, "Company W3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PO3 3OO", "123-456-7890" },
                    { 76, "Company X3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BS4 2OD", "123-456-7890" },
                    { 77, "Company Y3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E8 2NG", "123-456-7890" },
                    { 78, "Company Z3", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW7 7ZH", "123-456-7890" },
                    { 79, "Company A4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E6 8BJ", "123-456-7890" },
                    { 80, "Company B4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E5 2DJ", "123-456-7890" },
                    { 81, "Company C4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E9 5HQ", "123-456-7890" },
                    { 82, "Company D4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E1 9OD", "123-456-7890" },
                    { 83, "Company E4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E10 6WA", "123-456-7890" },
                    { 84, "Company F4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TR3 4HN", "123-456-7890" },
                    { 85, "Company G4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E5 8TP", "123-456-7890" },
                    { 86, "Company H4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "ME1 6PV", "123-456-7890" },
                    { 87, "Company I4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW7 1RI", "123-456-7890" },
                    { 88, "Company J4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E9 6VT", "123-456-7890" },
                    { 89, "Company K4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO16 4LF", "123-456-7890" },
                    { 90, "Company L4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "PL2 5FV", "123-456-7890" },
                    { 91, "Company M4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N7 9GH", "123-456-7890" },
                    { 92, "Company N4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N5 1UP", "123-456-7890" },
                    { 93, "Company O4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N3 5UO", "123-456-7890" },
                    { 94, "Company P4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "N5 7NB", "123-456-7890" },
                    { 95, "Company Q4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO16 5TG", "123-456-7890" },
                    { 96, "Company R4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SW6 8AN", "123-456-7890" },
                    { 97, "Company S4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TR2 3BD", "123-456-7890" },
                    { 98, "Company T4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "BS3 5JL", "123-456-7890" },
                    { 99, "Company U4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "E10 9PV", "123-456-7890" },
                    { 100, "Company V4", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "TN2 1QS", "123-456-7890" }
                });

            migrationBuilder.InsertData(
                table: "Inspectors",
                columns: new[] { "InspectorID", "InspectorsName" },
                values: new object[,]
                {
                    { 1, "Allen Lee" },
                    { 2, "Aidan Lee" }
                });

            migrationBuilder.InsertData(
                table: "PlantCategories",
                columns: new[] { "CategoryID", "CategoryDescription" },
                values: new object[,]
                {
                    { 1, "Heavy Plant" },
                    { 2, "Small Plant" },
                    { 3, "Access Equipment" },
                    { 4, "Power Tools" },
                    { 5, "Safety Equipment" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusID", "StatusDescription" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "In Use" },
                    { 3, "Under Maintenance" },
                    { 4, "Out of Service" },
                    { 5, "Reserved" }
                });

            migrationBuilder.InsertData(
                table: "Summaries",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Freezing", null },
                    { 2, "Bracing", null },
                    { 3, "Chilly", null },
                    { 4, "Cool", null },
                    { 5, "Mild", null },
                    { 6, "Warm", null },
                    { 7, "Balmy", null },
                    { 8, "Hot", null },
                    { 9, "Sweltering", null },
                    { 10, "Scorching", null }
                });

            migrationBuilder.InsertData(
                table: "AllPlant",
                columns: new[] { "PlantNameID", "NormalPrice", "PlantCategory", "PlantDescription" },
                values: new object[,]
                {
                    { 1, "150.00", 1, "Excavator 2T" },
                    { 2, "95.00", 3, "Scissor Lift" },
                    { 3, "45.00", 2, "Concrete Mixer" },
                    { 4, "25.00", 4, "Power Drill" },
                    { 5, "15.00", 5, "Safety Harness" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "IsCustomer", "False", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "6aa33e39-8591-4bff-9001-bc58c0313c89" },
                    { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "6aa33e39-8591-4bff-9001-bc58c0313c89" }
                });

            migrationBuilder.InsertData(
                table: "PlantHoldings",
                columns: new[] { "HoldingID", "CustID", "InspectionFee", "InspectionFrequency", "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[,]
                {
                    { 1, 1, 105m, 12, 2, "500kg", "B2D4F6H8J0", 2 },
                    { 2, 2, 170m, 12, 3, "300kg", "C3E5G7I9K1", 3 },
                    { 3, 3, 110m, 12, 4, "N/A", "D4F6H8J0L2", 4 },
                    { 4, 4, 175m, 12, 5, "150kg", "E5G7I9K1M3", 5 },
                    { 5, 5, 115m, 12, 1, "2000kg", "F6H8J0L2N4", 1 },
                    { 6, 6, 180m, 12, 2, "500kg", "G7I9K1M3O5", 2 },
                    { 7, 7, 120m, 12, 3, "300kg", "H8J0L2N4P6", 3 },
                    { 8, 8, 185m, 12, 4, "N/A", "I9K1M3O5Q7", 4 },
                    { 9, 9, 125m, 12, 5, "150kg", "J0L2N4P6R8", 5 },
                    { 10, 10, 190m, 12, 1, "2000kg", "K1M3O5Q7S9", 1 },
                    { 11, 11, 130m, 12, 2, "500kg", "L2N4P6R8T0", 2 },
                    { 12, 12, 200m, 12, 3, "300kg", "M3O5Q7S9U1", 3 },
                    { 13, 13, 140m, 12, 4, "N/A", "N4P6R8T0V2", 4 },
                    { 14, 14, 80m, 12, 5, "150kg", "O5Q7S9U1W3", 5 },
                    { 15, 15, 145m, 12, 1, "2000kg", "P6R8T0V2X4", 1 },
                    { 16, 16, 85m, 12, 2, "500kg", "Q7S9U1W3Y5", 2 },
                    { 17, 17, 150m, 12, 3, "300kg", "R8T0V2X4Z6", 3 },
                    { 18, 18, 90m, 12, 4, "N/A", "S9U1W3Y5A7", 4 },
                    { 19, 19, 155m, 12, 5, "150kg", "T0V2X4Z6B8", 5 },
                    { 20, 20, 95m, 12, 1, "2000kg", "U1W3Y5A7C9", 1 },
                    { 21, 21, 160m, 12, 2, "500kg", "V2X4Z6B8D0", 2 },
                    { 22, 22, 100m, 12, 3, "300kg", "W3Y5A7C9E1", 3 },
                    { 23, 23, 165m, 12, 4, "N/A", "X4Z6B8D0F2", 4 },
                    { 24, 24, 105m, 12, 5, "150kg", "Y5A7C9E1G3", 5 },
                    { 25, 25, 170m, 12, 1, "2000kg", "Z6B8D0F2H4", 1 },
                    { 26, 26, 110m, 12, 2, "500kg", "A7C9E1G3I5", 2 },
                    { 27, 27, 175m, 12, 3, "300kg", "B8D0F2H4J6", 3 },
                    { 28, 28, 115m, 12, 4, "N/A", "C9E1G3I5K7", 4 },
                    { 29, 29, 185m, 12, 5, "150kg", "D0F2H4J6L8", 5 },
                    { 30, 30, 125m, 12, 1, "2000kg", "E1G3I5K7M9", 1 },
                    { 31, 31, 190m, 12, 2, "500kg", "F2H4J6L8N0", 2 },
                    { 32, 32, 130m, 12, 3, "300kg", "G3I5K7M9O1", 3 },
                    { 33, 33, 195m, 12, 4, "N/A", "H4J6L8N0P2", 4 },
                    { 34, 34, 135m, 12, 5, "150kg", "I5K7M9O1Q3", 5 },
                    { 35, 35, 75m, 12, 1, "2000kg", "J6L8N0P2R4", 1 },
                    { 36, 36, 140m, 12, 2, "500kg", "K7M9O1Q3S5", 2 },
                    { 37, 37, 80m, 12, 3, "300kg", "L8N0P2R4T6", 3 },
                    { 38, 38, 145m, 12, 4, "N/A", "M9O1Q3S5U7", 4 },
                    { 39, 39, 85m, 12, 5, "150kg", "N0P2R4T6V8", 5 },
                    { 40, 40, 150m, 12, 1, "2000kg", "O1Q3S5U7W9", 1 },
                    { 41, 41, 90m, 12, 2, "500kg", "P2R4T6V8X0", 2 },
                    { 42, 42, 155m, 12, 3, "300kg", "Q3S5U7W9Y1", 3 },
                    { 43, 43, 95m, 12, 4, "N/A", "R4T6V8X0Z2", 4 },
                    { 44, 44, 160m, 12, 5, "150kg", "S5U7W9Y1A3", 5 },
                    { 45, 45, 100m, 12, 1, "2000kg", "T6V8X0Z2B4", 1 },
                    { 46, 46, 170m, 12, 2, "500kg", "U7W9Y1A3C5", 2 },
                    { 47, 47, 110m, 12, 3, "300kg", "V8X0Z2B4D6", 3 },
                    { 48, 48, 175m, 12, 4, "N/A", "W9Y1A3C5E7", 4 },
                    { 49, 49, 115m, 12, 5, "150kg", "X0Z2B4D6F8", 5 },
                    { 50, 50, 180m, 12, 1, "2000kg", "Y1A3C5E7G9", 1 },
                    { 51, 51, 120m, 12, 2, "500kg", "Z2B4D6F8H0", 2 },
                    { 52, 52, 185m, 12, 3, "300kg", "A3C5E7G9I1", 3 },
                    { 53, 53, 125m, 12, 4, "N/A", "B4D6F8H0J2", 4 },
                    { 54, 54, 190m, 12, 5, "150kg", "C5E7G9I1K3", 5 },
                    { 55, 55, 130m, 12, 1, "2000kg", "D6F8H0J2L4", 1 },
                    { 56, 56, 195m, 12, 2, "500kg", "E7G9I1K3M5", 2 },
                    { 57, 57, 135m, 12, 3, "300kg", "F8H0J2L4N6", 3 },
                    { 58, 58, 75m, 12, 4, "N/A", "G9I1K3M5O7", 4 },
                    { 59, 59, 140m, 12, 5, "150kg", "H0J2L4N6P8", 5 },
                    { 60, 60, 80m, 12, 1, "2000kg", "I1K3M5O7Q9", 1 },
                    { 61, 61, 145m, 12, 2, "500kg", "J2L4N6P8R0", 2 },
                    { 62, 62, 85m, 12, 3, "300kg", "K3M5O7Q9S1", 3 },
                    { 63, 63, 155m, 12, 4, "N/A", "L4N6P8R0T2", 4 },
                    { 64, 64, 95m, 12, 5, "150kg", "M5O7Q9S1U3", 5 },
                    { 65, 65, 160m, 12, 1, "2000kg", "N6P8R0T2V4", 1 },
                    { 66, 66, 100m, 12, 2, "500kg", "O7Q9S1U3W5", 2 },
                    { 67, 67, 165m, 12, 3, "300kg", "P8R0T2V4X6", 3 },
                    { 68, 68, 105m, 12, 4, "N/A", "Q9S1U3W5Y7", 4 },
                    { 69, 69, 170m, 12, 5, "150kg", "R0T2V4X6Z8", 5 },
                    { 70, 70, 110m, 12, 1, "2000kg", "S1U3W5Y7A9", 1 },
                    { 71, 71, 175m, 12, 2, "500kg", "T2V4X6Z8B0", 2 },
                    { 72, 72, 115m, 12, 3, "300kg", "U3W5Y7A9C1", 3 },
                    { 73, 73, 180m, 12, 4, "N/A", "V4X6Z8B0D2", 4 },
                    { 74, 74, 120m, 12, 5, "150kg", "W5Y7A9C1E3", 5 },
                    { 75, 75, 185m, 12, 1, "2000kg", "X6Z8B0D2F4", 1 },
                    { 76, 76, 125m, 12, 2, "500kg", "Y7A9C1E3G5", 2 },
                    { 77, 77, 195m, 12, 3, "300kg", "Z8B0D2F4H6", 3 },
                    { 78, 78, 130m, 12, 4, "N/A", "A9C1E3G5I7", 4 },
                    { 79, 79, 200m, 12, 5, "150kg", "B0D2F4H6J8", 5 },
                    { 80, 80, 140m, 12, 1, "2000kg", "C1E3G5I7K9", 1 },
                    { 81, 81, 80m, 12, 2, "500kg", "D2F4H6J8L0", 2 },
                    { 82, 82, 145m, 12, 3, "300kg", "E3G5I7K9M1", 3 },
                    { 83, 83, 85m, 12, 4, "N/A", "F4H6J8L0N2", 4 },
                    { 84, 84, 150m, 12, 5, "150kg", "G5I7K9M1O3", 5 },
                    { 85, 85, 90m, 12, 1, "2000kg", "H6J8L0N2P4", 1 },
                    { 86, 86, 155m, 12, 2, "500kg", "I7K9M1O3Q5", 2 },
                    { 87, 87, 95m, 12, 3, "300kg", "J8L0N2P4R6", 3 },
                    { 88, 88, 160m, 12, 4, "N/A", "K9M1O3Q5S7", 4 },
                    { 89, 89, 100m, 12, 5, "150kg", "L0N2P4R6T8", 5 },
                    { 90, 90, 165m, 12, 1, "2000kg", "M1O3Q5S7U9", 1 },
                    { 91, 91, 105m, 12, 2, "500kg", "N2P4R6T8V0", 2 },
                    { 92, 92, 170m, 12, 3, "300kg", "O3Q5S7U9W1", 3 },
                    { 93, 93, 110m, 12, 4, "N/A", "P4R6T8V0X2", 4 },
                    { 94, 94, 180m, 12, 5, "150kg", "Q5S7U9W1Y3", 5 },
                    { 95, 95, 115m, 12, 1, "2000kg", "R6T8V0X2Z4", 1 },
                    { 96, 96, 185m, 12, 2, "500kg", "S7U9W1Y3A5", 2 },
                    { 97, 97, 125m, 12, 3, "300kg", "T8V0X2Z4B6", 3 },
                    { 98, 98, 190m, 12, 4, "N/A", "U9W1Y3A5C7", 4 },
                    { 99, 99, 130m, 12, 5, "150kg", "V0X2Z4B6D8", 5 },
                    { 100, 100, 195m, 12, 1, "2000kg", "W1Y3A5C7E9", 1 }
                });

            migrationBuilder.InsertData(
                table: "Inspections",
                columns: new[] { "UniqueRef", "Defects", "HoldingID", "InspectionDate", "InspectorID", "LatestDate", "Location", "MiscNotes", "PreviousCheck", "RecentCheck", "Rectified", "SafeWorking", "TestDetails" },
                values: new object[,]
                {
                    { 1, "None", 1, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 1", "Annual inspection for plant holding 1", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 2, "None", 2, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 2", "Annual inspection for plant holding 2", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 3, "None", 3, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 3", "Annual inspection for plant holding 3", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 4, "None", 4, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 4", "Annual inspection for plant holding 4", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 5, "None", 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 5", "Annual inspection for plant holding 5", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 6, "None", 6, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 6", "Annual inspection for plant holding 6", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 7, "None", 7, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 7", "Annual inspection for plant holding 7", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 8, "None", 8, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 8", "Annual inspection for plant holding 8", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 9, "None", 9, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 9", "Annual inspection for plant holding 9", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 10, "None", 10, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 10", "Annual inspection for plant holding 10", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 11, "None", 11, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 11", "Annual inspection for plant holding 11", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 12, "None", 12, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 12", "Annual inspection for plant holding 12", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 13, "None", 13, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 13", "Annual inspection for plant holding 13", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 14, "None", 14, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 14", "Annual inspection for plant holding 14", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 15, "None", 15, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 15", "Annual inspection for plant holding 15", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 16, "None", 16, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 16", "Annual inspection for plant holding 16", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 17, "None", 17, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 17", "Annual inspection for plant holding 17", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 18, "None", 18, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 18", "Annual inspection for plant holding 18", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 19, "None", 19, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 19", "Annual inspection for plant holding 19", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 20, "None", 20, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 20", "Annual inspection for plant holding 20", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 21, "None", 21, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 21", "Annual inspection for plant holding 21", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 22, "None", 22, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 22", "Annual inspection for plant holding 22", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 23, "None", 23, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 23", "Annual inspection for plant holding 23", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 24, "None", 24, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 24", "Annual inspection for plant holding 24", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 25, "None", 25, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 25", "Annual inspection for plant holding 25", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 26, "None", 26, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 26", "Annual inspection for plant holding 26", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 27, "None", 27, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 27", "Annual inspection for plant holding 27", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 28, "None", 28, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 28", "Annual inspection for plant holding 28", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 29, "None", 29, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 29", "Annual inspection for plant holding 29", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 30, "None", 30, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 30", "Annual inspection for plant holding 30", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 31, "None", 31, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 31", "Annual inspection for plant holding 31", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 32, "None", 32, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 32", "Annual inspection for plant holding 32", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 33, "None", 33, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 33", "Annual inspection for plant holding 33", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 34, "None", 34, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 34", "Annual inspection for plant holding 34", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 35, "None", 35, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 35", "Annual inspection for plant holding 35", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 36, "None", 36, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 36", "Annual inspection for plant holding 36", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 37, "None", 37, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 37", "Annual inspection for plant holding 37", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 38, "None", 38, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 38", "Annual inspection for plant holding 38", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 39, "None", 39, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 39", "Annual inspection for plant holding 39", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 40, "None", 40, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 40", "Annual inspection for plant holding 40", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 41, "None", 41, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 41", "Annual inspection for plant holding 41", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 42, "None", 42, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 42", "Annual inspection for plant holding 42", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 43, "None", 43, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 43", "Annual inspection for plant holding 43", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 44, "None", 44, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 44", "Annual inspection for plant holding 44", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 45, "None", 45, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 45", "Annual inspection for plant holding 45", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 46, "None", 46, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 46", "Annual inspection for plant holding 46", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 47, "None", 47, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 47", "Annual inspection for plant holding 47", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 48, "None", 48, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 48", "Annual inspection for plant holding 48", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 49, "None", 49, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 49", "Annual inspection for plant holding 49", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 50, "None", 50, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 50", "Annual inspection for plant holding 50", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 51, "None", 51, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 51", "Annual inspection for plant holding 51", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 52, "None", 52, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 52", "Annual inspection for plant holding 52", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 53, "None", 53, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 53", "Annual inspection for plant holding 53", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 54, "None", 54, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 54", "Annual inspection for plant holding 54", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 55, "None", 55, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 55", "Annual inspection for plant holding 55", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 56, "None", 56, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 56", "Annual inspection for plant holding 56", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 57, "None", 57, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 57", "Annual inspection for plant holding 57", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 58, "None", 58, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 58", "Annual inspection for plant holding 58", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 59, "None", 59, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 59", "Annual inspection for plant holding 59", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 60, "None", 60, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 60", "Annual inspection for plant holding 60", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 61, "None", 61, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 61", "Annual inspection for plant holding 61", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 62, "None", 62, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 62", "Annual inspection for plant holding 62", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 63, "None", 63, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 63", "Annual inspection for plant holding 63", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 64, "None", 64, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 64", "Annual inspection for plant holding 64", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 65, "None", 65, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 65", "Annual inspection for plant holding 65", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 66, "None", 66, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 66", "Annual inspection for plant holding 66", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 67, "None", 67, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 67", "Annual inspection for plant holding 67", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 68, "None", 68, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 68", "Annual inspection for plant holding 68", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 69, "None", 69, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 69", "Annual inspection for plant holding 69", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 70, "None", 70, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 70", "Annual inspection for plant holding 70", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 71, "None", 71, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 71", "Annual inspection for plant holding 71", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 72, "None", 72, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 72", "Annual inspection for plant holding 72", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 73, "None", 73, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 73", "Annual inspection for plant holding 73", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 74, "None", 74, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 74", "Annual inspection for plant holding 74", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 75, "None", 75, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 75", "Annual inspection for plant holding 75", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 76, "None", 76, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 76", "Annual inspection for plant holding 76", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 77, "None", 77, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 77", "Annual inspection for plant holding 77", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 78, "None", 78, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 78", "Annual inspection for plant holding 78", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 79, "None", 79, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 79", "Annual inspection for plant holding 79", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 80, "None", 80, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 80", "Annual inspection for plant holding 80", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 81, "None", 81, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 81", "Annual inspection for plant holding 81", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 82, "None", 82, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 82", "Annual inspection for plant holding 82", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 83, "None", 83, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 83", "Annual inspection for plant holding 83", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 84, "None", 84, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 84", "Annual inspection for plant holding 84", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 85, "None", 85, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 85", "Annual inspection for plant holding 85", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 86, "None", 86, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 86", "Annual inspection for plant holding 86", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 87, "None", 87, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 87", "Annual inspection for plant holding 87", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 88, "None", 88, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 88", "Annual inspection for plant holding 88", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 89, "None", 89, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 89", "Annual inspection for plant holding 89", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 90, "None", 90, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 90", "Annual inspection for plant holding 90", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 91, "None", 91, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 91", "Annual inspection for plant holding 91", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 92, "None", 92, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 92", "Annual inspection for plant holding 92", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 93, "None", 93, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 93", "Annual inspection for plant holding 93", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 94, "None", 94, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 94", "Annual inspection for plant holding 94", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 95, "None", 95, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 95", "Annual inspection for plant holding 95", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 96, "None", 96, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 96", "Annual inspection for plant holding 96", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 97, "None", 97, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 97", "Annual inspection for plant holding 97", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 98, "None", 98, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 98", "Annual inspection for plant holding 98", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 99, "None", 99, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 99", "Annual inspection for plant holding 99", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 100, "None", 100, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 100", "Annual inspection for plant holding 100", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" }
                });
        }
    }
}
