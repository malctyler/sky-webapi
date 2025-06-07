using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddLedgerReferenceUniqueConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            // Drop column if it exists (to handle case where previous migration attempt was incomplete)
            migrationBuilder.Sql(@"
                IF COL_LENGTH('Ledgers', 'ReferenceWithoutInitials') IS NOT NULL
                BEGIN
                    DECLARE @DropIndexSQL nvarchar(max) = '';
                    SELECT @DropIndexSQL = @DropIndexSQL + 'DROP INDEX ' + name + ' ON Ledgers;' + CHAR(13)
                    FROM sys.indexes 
                    WHERE object_id = OBJECT_ID('Ledgers')
                    AND name LIKE 'IX_Ledgers_ReferenceWithoutInitials%'

                    EXEC sp_executesql @DropIndexSQL;

                    ALTER TABLE Ledgers DROP COLUMN ReferenceWithoutInitials;
                END

                ALTER TABLE Ledgers ADD ReferenceWithoutInitials AS 
                    CAST(SUBSTRING(InvoiceRef, CHARINDEX('/', InvoiceRef), LEN(InvoiceRef) - CHARINDEX('/', InvoiceRef) + 1) AS nvarchar(100)) PERSISTED;

                CREATE UNIQUE NONCLUSTERED INDEX IX_Ledgers_ReferenceWithoutInitials
                ON Ledgers(ReferenceWithoutInitials);");

            // Update customer data
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1,
                column: "CompanyName",
                value: "Company A");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2,
                column: "CompanyName",
                value: "Company B");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3,
                column: "CompanyName",
                value: "Company C");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4,
                column: "CompanyName",
                value: "Company D");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5,
                column: "CompanyName",
                value: "Company E");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6,
                column: "CompanyName",
                value: "Company F");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7,
                column: "CompanyName",
                value: "Company G");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8,
                column: "CompanyName",
                value: "Company H");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9,
                column: "CompanyName",
                value: "Company I");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10,
                column: "CompanyName",
                value: "Company J");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 11,
                column: "CompanyName",
                value: "Company K");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 12,
                column: "CompanyName",
                value: "Company L");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 13,
                column: "CompanyName",
                value: "Company M");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 14,
                column: "CompanyName",
                value: "Company N");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 15,
                column: "CompanyName",
                value: "Company O");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 16,
                column: "CompanyName",
                value: "Company P");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 17,
                column: "CompanyName",
                value: "Company Q");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 18,
                column: "CompanyName",
                value: "Company R");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 19,
                column: "CompanyName",
                value: "Company S");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 20,
                column: "CompanyName",
                value: "Company T");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 21,
                column: "CompanyName",
                value: "Company U");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 22,
                column: "CompanyName",
                value: "Company V");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 23,
                column: "CompanyName",
                value: "Company W");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 24,
                column: "CompanyName",
                value: "Company X");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 25,
                column: "CompanyName",
                value: "Company Y");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 26,
                column: "CompanyName",
                value: "Company Z");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 27,
                column: "CompanyName",
                value: "Company A2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 28,
                column: "CompanyName",
                value: "Company B2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 29,
                column: "CompanyName",
                value: "Company C2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 30,
                column: "CompanyName",
                value: "Company D2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 31,
                column: "CompanyName",
                value: "Company E2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 32,
                column: "CompanyName",
                value: "Company F2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 33,
                column: "CompanyName",
                value: "Company G2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 34,
                column: "CompanyName",
                value: "Company H2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 35,
                column: "CompanyName",
                value: "Company I2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 36,
                column: "CompanyName",
                value: "Company J2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 37,
                column: "CompanyName",
                value: "Company K2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 38,
                column: "CompanyName",
                value: "Company L2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 39,
                column: "CompanyName",
                value: "Company M2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 40,
                column: "CompanyName",
                value: "Company N2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 41,
                column: "CompanyName",
                value: "Company O2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 42,
                column: "CompanyName",
                value: "Company P2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 43,
                column: "CompanyName",
                value: "Company Q2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 44,
                column: "CompanyName",
                value: "Company R2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 45,
                column: "CompanyName",
                value: "Company S2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 46,
                column: "CompanyName",
                value: "Company T2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 47,
                column: "CompanyName",
                value: "Company U2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 48,
                column: "CompanyName",
                value: "Company V2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 49,
                column: "CompanyName",
                value: "Company W2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 50,
                column: "CompanyName",
                value: "Company X2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 51,
                column: "CompanyName",
                value: "Company Y2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 52,
                column: "CompanyName",
                value: "Company Z2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 53,
                column: "CompanyName",
                value: "Company A3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 54,
                column: "CompanyName",
                value: "Company B3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 55,
                column: "CompanyName",
                value: "Company C3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 56,
                column: "CompanyName",
                value: "Company D3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 57,
                column: "CompanyName",
                value: "Company E3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 58,
                column: "CompanyName",
                value: "Company F3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 59,
                column: "CompanyName",
                value: "Company G3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 60,
                column: "CompanyName",
                value: "Company H3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 61,
                column: "CompanyName",
                value: "Company I3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 62,
                column: "CompanyName",
                value: "Company J3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 63,
                column: "CompanyName",
                value: "Company K3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 64,
                column: "CompanyName",
                value: "Company L3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 65,
                column: "CompanyName",
                value: "Company M3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 66,
                column: "CompanyName",
                value: "Company N3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 67,
                column: "CompanyName",
                value: "Company O3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 68,
                column: "CompanyName",
                value: "Company P3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 69,
                column: "CompanyName",
                value: "Company Q3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 70,
                column: "CompanyName",
                value: "Company R3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 71,
                column: "CompanyName",
                value: "Company S3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 72,
                column: "CompanyName",
                value: "Company T3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 73,
                column: "CompanyName",
                value: "Company U3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 74,
                column: "CompanyName",
                value: "Company V3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 75,
                column: "CompanyName",
                value: "Company W3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 76,
                column: "CompanyName",
                value: "Company X3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 77,
                column: "CompanyName",
                value: "Company Y3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 78,
                column: "CompanyName",
                value: "Company Z3");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 79,
                column: "CompanyName",
                value: "Company A4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 80,
                column: "CompanyName",
                value: "Company B4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 81,
                column: "CompanyName",
                value: "Company C4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 82,
                column: "CompanyName",
                value: "Company D4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 83,
                column: "CompanyName",
                value: "Company E4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 84,
                column: "CompanyName",
                value: "Company F4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 85,
                column: "CompanyName",
                value: "Company G4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 86,
                column: "CompanyName",
                value: "Company H4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 87,
                column: "CompanyName",
                value: "Company I4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 88,
                column: "CompanyName",
                value: "Company J4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 89,
                column: "CompanyName",
                value: "Company K4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 90,
                column: "CompanyName",
                value: "Company L4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 91,
                column: "CompanyName",
                value: "Company M4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 92,
                column: "CompanyName",
                value: "Company N4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 93,
                column: "CompanyName",
                value: "Company O4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 94,
                column: "CompanyName",
                value: "Company P4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 95,
                column: "CompanyName",
                value: "Company Q4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 96,
                column: "CompanyName",
                value: "Company R4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 97,
                column: "CompanyName",
                value: "Company S4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 98,
                column: "CompanyName",
                value: "Company T4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 99,
                column: "CompanyName",
                value: "Company U4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 100,
                column: "CompanyName",
                value: "Company V4");

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1,
                column: "InspectionFee",
                value: 105m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2,
                column: "InspectionFee",
                value: 170m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3,
                column: "InspectionFee",
                value: 110m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4,
                column: "InspectionFee",
                value: 175m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5,
                column: "InspectionFee",
                value: 115m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 6,
                column: "InspectionFee",
                value: 180m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 7,
                column: "InspectionFee",
                value: 120m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 8,
                column: "InspectionFee",
                value: 185m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 9,
                column: "InspectionFee",
                value: 125m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 10,
                column: "InspectionFee",
                value: 190m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 11,
                column: "InspectionFee",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 12,
                column: "InspectionFee",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 13,
                column: "InspectionFee",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 14,
                column: "InspectionFee",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 15,
                column: "InspectionFee",
                value: 145m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 16,
                column: "InspectionFee",
                value: 85m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 17,
                column: "InspectionFee",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 18,
                column: "InspectionFee",
                value: 90m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 19,
                column: "InspectionFee",
                value: 155m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 20,
                column: "InspectionFee",
                value: 95m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 21,
                column: "InspectionFee",
                value: 160m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 22,
                column: "InspectionFee",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 23,
                column: "InspectionFee",
                value: 165m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 24,
                column: "InspectionFee",
                value: 105m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 25,
                column: "InspectionFee",
                value: 170m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 26,
                column: "InspectionFee",
                value: 110m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 27,
                column: "InspectionFee",
                value: 175m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 28,
                column: "InspectionFee",
                value: 115m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 29,
                column: "InspectionFee",
                value: 185m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 30,
                column: "InspectionFee",
                value: 125m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 31,
                column: "InspectionFee",
                value: 190m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 32,
                column: "InspectionFee",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 33,
                column: "InspectionFee",
                value: 195m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 34,
                column: "InspectionFee",
                value: 135m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 35,
                column: "InspectionFee",
                value: 75m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 36,
                column: "InspectionFee",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 37,
                column: "InspectionFee",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 38,
                column: "InspectionFee",
                value: 145m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 39,
                column: "InspectionFee",
                value: 85m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 40,
                column: "InspectionFee",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 41,
                column: "InspectionFee",
                value: 90m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 42,
                column: "InspectionFee",
                value: 155m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 43,
                column: "InspectionFee",
                value: 95m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 44,
                column: "InspectionFee",
                value: 160m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 45,
                column: "InspectionFee",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 46,
                column: "InspectionFee",
                value: 170m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 47,
                column: "InspectionFee",
                value: 110m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 48,
                column: "InspectionFee",
                value: 175m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 49,
                column: "InspectionFee",
                value: 115m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 50,
                column: "InspectionFee",
                value: 180m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 51,
                column: "InspectionFee",
                value: 120m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 52,
                column: "InspectionFee",
                value: 185m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 53,
                column: "InspectionFee",
                value: 125m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 54,
                column: "InspectionFee",
                value: 190m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 55,
                column: "InspectionFee",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 56,
                column: "InspectionFee",
                value: 195m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 57,
                column: "InspectionFee",
                value: 135m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 58,
                column: "InspectionFee",
                value: 75m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 59,
                column: "InspectionFee",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 60,
                column: "InspectionFee",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 61,
                column: "InspectionFee",
                value: 145m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 62,
                column: "InspectionFee",
                value: 85m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 63,
                column: "InspectionFee",
                value: 155m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 64,
                column: "InspectionFee",
                value: 95m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 65,
                column: "InspectionFee",
                value: 160m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 66,
                column: "InspectionFee",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 67,
                column: "InspectionFee",
                value: 165m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 68,
                column: "InspectionFee",
                value: 105m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 69,
                column: "InspectionFee",
                value: 170m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 70,
                column: "InspectionFee",
                value: 110m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 71,
                column: "InspectionFee",
                value: 175m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 72,
                column: "InspectionFee",
                value: 115m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 73,
                column: "InspectionFee",
                value: 180m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 74,
                column: "InspectionFee",
                value: 120m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 75,
                column: "InspectionFee",
                value: 185m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 76,
                column: "InspectionFee",
                value: 125m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 77,
                column: "InspectionFee",
                value: 195m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 78,
                column: "InspectionFee",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 79,
                column: "InspectionFee",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 80,
                column: "InspectionFee",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 81,
                column: "InspectionFee",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 82,
                column: "InspectionFee",
                value: 145m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 83,
                column: "InspectionFee",
                value: 85m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 84,
                column: "InspectionFee",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 85,
                column: "InspectionFee",
                value: 90m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 86,
                column: "InspectionFee",
                value: 155m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 87,
                column: "InspectionFee",
                value: 95m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 88,
                column: "InspectionFee",
                value: 160m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 89,
                column: "InspectionFee",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 90,
                column: "InspectionFee",
                value: 165m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 91,
                column: "InspectionFee",
                value: 105m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 92,
                column: "InspectionFee",
                value: 170m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 93,
                column: "InspectionFee",
                value: 110m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 94,
                column: "InspectionFee",
                value: 180m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 95,
                column: "InspectionFee",
                value: 115m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 96,
                column: "InspectionFee",
                value: 185m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 97,
                column: "InspectionFee",
                value: 125m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 98,
                column: "InspectionFee",
                value: 190m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 99,
                column: "InspectionFee",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 100,
                column: "InspectionFee",
                value: 195m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Ledgers_ReferenceWithoutInitials' AND object_id = OBJECT_ID('Ledgers'))
                BEGIN
                    DROP INDEX IX_Ledgers_ReferenceWithoutInitials ON Ledgers;
                END

                IF COL_LENGTH('Ledgers', 'ReferenceWithoutInitials') IS NOT NULL
                BEGIN
                    ALTER TABLE Ledgers DROP COLUMN ReferenceWithoutInitials;
                END");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: false,
                oldDefaultValue: "");
        }
    }
}
