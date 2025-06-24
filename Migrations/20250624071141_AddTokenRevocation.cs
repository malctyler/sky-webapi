using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddTokenRevocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RevokedTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RevokedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevokedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevokedTokens", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1,
                column: "Postcode",
                value: "SW3 9MV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2,
                column: "Postcode",
                value: "N2 3JZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3,
                column: "Postcode",
                value: "SO16 2EU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4,
                column: "Postcode",
                value: "EX4 4MG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5,
                column: "Postcode",
                value: "PL1 4DO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6,
                column: "Postcode",
                value: "E2 6MW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7,
                column: "Postcode",
                value: "N9 1CG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8,
                column: "Postcode",
                value: "TR2 1VC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9,
                column: "Postcode",
                value: "TR4 8OQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10,
                column: "Postcode",
                value: "N7 7PN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 11,
                column: "Postcode",
                value: "PO4 5DU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 12,
                column: "Postcode",
                value: "BS3 5OH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 13,
                column: "Postcode",
                value: "N4 5BN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 14,
                column: "Postcode",
                value: "TN4 1NO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 15,
                column: "Postcode",
                value: "TR3 7UF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 16,
                column: "Postcode",
                value: "N5 2XZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 17,
                column: "Postcode",
                value: "TR4 1CS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 18,
                column: "Postcode",
                value: "ME4 5ND");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 19,
                column: "Postcode",
                value: "ME2 6ZP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 20,
                column: "Postcode",
                value: "E7 3VU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 21,
                column: "Postcode",
                value: "E6 4FF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 22,
                column: "Postcode",
                value: "N9 2PF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 23,
                column: "Postcode",
                value: "N6 4NZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 24,
                column: "Postcode",
                value: "SW3 4OU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 25,
                column: "Postcode",
                value: "CT3 1NK");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 26,
                column: "Postcode",
                value: "N10 2FE");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 27,
                column: "Postcode",
                value: "N4 9TC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 28,
                column: "Postcode",
                value: "CT2 8WP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 29,
                column: "Postcode",
                value: "BN3 5XH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 30,
                column: "Postcode",
                value: "BS4 7AK");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 31,
                column: "Postcode",
                value: "SW5 9UH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 32,
                column: "Postcode",
                value: "E8 8JB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 33,
                column: "Postcode",
                value: "TN1 1WY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 34,
                column: "Postcode",
                value: "SO14 8AN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 35,
                column: "Postcode",
                value: "E7 8AY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 36,
                column: "Postcode",
                value: "TN4 9QF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 37,
                column: "Postcode",
                value: "SW3 4KU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 38,
                column: "Postcode",
                value: "PL2 4PL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 39,
                column: "Postcode",
                value: "PL2 8OF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 40,
                column: "Postcode",
                value: "SW9 1TZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 41,
                column: "Postcode",
                value: "BN3 9OU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 42,
                column: "Postcode",
                value: "E5 4EF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 43,
                column: "Postcode",
                value: "TN2 3JJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 44,
                column: "Postcode",
                value: "CT4 6XK");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 45,
                column: "Postcode",
                value: "CT3 4XU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 46,
                column: "Postcode",
                value: "PL3 4UB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 47,
                column: "Postcode",
                value: "N1 7VW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 48,
                column: "Postcode",
                value: "E10 2FM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 49,
                column: "Postcode",
                value: "E6 1OL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 50,
                column: "Postcode",
                value: "N5 6NS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 51,
                column: "Postcode",
                value: "BN1 7AE");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 52,
                column: "Postcode",
                value: "TN3 3JN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 53,
                column: "Postcode",
                value: "CT2 1FC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 54,
                column: "Postcode",
                value: "TN3 7PL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 55,
                column: "Postcode",
                value: "SO14 5EU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 56,
                column: "Postcode",
                value: "ME1 1CT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 57,
                column: "Postcode",
                value: "TN2 5IF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 58,
                column: "Postcode",
                value: "PL1 9LQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 59,
                column: "Postcode",
                value: "EX3 3VR");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 60,
                column: "Postcode",
                value: "SW4 8NF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 61,
                column: "Postcode",
                value: "CT2 2FB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 62,
                column: "Postcode",
                value: "SO14 6IN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 63,
                column: "Postcode",
                value: "E6 7MS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 64,
                column: "Postcode",
                value: "TR3 6OQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 65,
                column: "Postcode",
                value: "CT3 3XC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 66,
                column: "Postcode",
                value: "BN3 4EF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 67,
                column: "Postcode",
                value: "TN4 9TD");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 68,
                column: "Postcode",
                value: "TN3 1RT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 69,
                column: "Postcode",
                value: "BS1 4FG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 70,
                column: "Postcode",
                value: "SO15 5BS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 71,
                column: "Postcode",
                value: "PL3 7FG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 72,
                column: "Postcode",
                value: "EX4 8DQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 73,
                column: "Postcode",
                value: "E2 3UQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 74,
                column: "Postcode",
                value: "BS1 6UY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 75,
                column: "Postcode",
                value: "SW10 7ZA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 76,
                column: "Postcode",
                value: "E3 7NI");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 77,
                column: "Postcode",
                value: "E5 2OR");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 78,
                column: "Postcode",
                value: "TN2 7LJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 79,
                column: "Postcode",
                value: "SW3 5IJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 80,
                column: "Postcode",
                value: "E6 6OH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 81,
                column: "Postcode",
                value: "TR3 1NG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 82,
                column: "Postcode",
                value: "SW7 2XI");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 83,
                column: "Postcode",
                value: "PL3 4KO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 84,
                column: "Postcode",
                value: "N8 6ZP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 85,
                column: "Postcode",
                value: "BN1 7LU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 86,
                column: "Postcode",
                value: "SO17 9ZN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 87,
                column: "Postcode",
                value: "ME4 6LJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 88,
                column: "Postcode",
                value: "EX3 8AG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 89,
                column: "Postcode",
                value: "SW7 3ZH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 90,
                column: "Postcode",
                value: "N5 3ZP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 91,
                column: "Postcode",
                value: "PO1 8NA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 92,
                column: "Postcode",
                value: "SW5 6VJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 93,
                column: "Postcode",
                value: "N9 8ZN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 94,
                column: "Postcode",
                value: "E1 6RN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 95,
                column: "Postcode",
                value: "SW1 5FG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 96,
                column: "Postcode",
                value: "E9 5JG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 97,
                column: "Postcode",
                value: "SW4 4MU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 98,
                column: "Postcode",
                value: "PL1 5XC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 99,
                column: "Postcode",
                value: "E10 2DM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 100,
                column: "Postcode",
                value: "E8 7ZM");

            migrationBuilder.CreateIndex(
                name: "IX_RevokedTokens_ExpiresAt",
                table: "RevokedTokens",
                column: "ExpiresAt");

            migrationBuilder.CreateIndex(
                name: "IX_RevokedTokens_TokenId",
                table: "RevokedTokens",
                column: "TokenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RevokedTokens_UserId",
                table: "RevokedTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RevokedTokens");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1,
                column: "Postcode",
                value: "EX2 6LA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2,
                column: "Postcode",
                value: "E3 8RZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3,
                column: "Postcode",
                value: "TR1 8RC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4,
                column: "Postcode",
                value: "SO14 4HJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5,
                column: "Postcode",
                value: "SW7 2VV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6,
                column: "Postcode",
                value: "ME4 4JE");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7,
                column: "Postcode",
                value: "SW9 5EI");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8,
                column: "Postcode",
                value: "SW3 5LL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9,
                column: "Postcode",
                value: "BN2 3OB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10,
                column: "Postcode",
                value: "E4 5PP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 11,
                column: "Postcode",
                value: "BN1 9MG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 12,
                column: "Postcode",
                value: "N6 5XB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 13,
                column: "Postcode",
                value: "ME3 1HB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 14,
                column: "Postcode",
                value: "BS3 7LN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 15,
                column: "Postcode",
                value: "N8 8UG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 16,
                column: "Postcode",
                value: "TR4 9IH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 17,
                column: "Postcode",
                value: "SO16 4ZH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 18,
                column: "Postcode",
                value: "N3 7PU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 19,
                column: "Postcode",
                value: "ME2 2ZF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 20,
                column: "Postcode",
                value: "TN4 9GP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 21,
                column: "Postcode",
                value: "N9 5BW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 22,
                column: "Postcode",
                value: "TR2 8NQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 23,
                column: "Postcode",
                value: "E7 2IH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 24,
                column: "Postcode",
                value: "ME3 2DA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 25,
                column: "Postcode",
                value: "ME2 5UU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 26,
                column: "Postcode",
                value: "E9 3KX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 27,
                column: "Postcode",
                value: "E6 2UX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 28,
                column: "Postcode",
                value: "BS3 9MT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 29,
                column: "Postcode",
                value: "SW3 3NF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 30,
                column: "Postcode",
                value: "TR2 7GT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 31,
                column: "Postcode",
                value: "SO16 1CX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 32,
                column: "Postcode",
                value: "E6 3UY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 33,
                column: "Postcode",
                value: "E9 6RX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 34,
                column: "Postcode",
                value: "E9 6AT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 35,
                column: "Postcode",
                value: "SW2 5CR");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 36,
                column: "Postcode",
                value: "TN4 6ER");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 37,
                column: "Postcode",
                value: "PO3 4LN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 38,
                column: "Postcode",
                value: "PL1 1PJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 39,
                column: "Postcode",
                value: "SW4 1ZI");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 40,
                column: "Postcode",
                value: "CT3 1XL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 41,
                column: "Postcode",
                value: "ME1 4HG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 42,
                column: "Postcode",
                value: "E5 7BF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 43,
                column: "Postcode",
                value: "E7 4MC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 44,
                column: "Postcode",
                value: "TR1 8XN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 45,
                column: "Postcode",
                value: "TN4 4AC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 46,
                column: "Postcode",
                value: "ME4 9FS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 47,
                column: "Postcode",
                value: "N3 3LH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 48,
                column: "Postcode",
                value: "BN1 4EB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 49,
                column: "Postcode",
                value: "PO3 8CZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 50,
                column: "Postcode",
                value: "TR1 4ZV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 51,
                column: "Postcode",
                value: "BN1 1ZA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 52,
                column: "Postcode",
                value: "EX1 5ET");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 53,
                column: "Postcode",
                value: "BS2 5JC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 54,
                column: "Postcode",
                value: "EX4 7BF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 55,
                column: "Postcode",
                value: "SW7 2VZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 56,
                column: "Postcode",
                value: "SO16 9GJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 57,
                column: "Postcode",
                value: "PO1 7JS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 58,
                column: "Postcode",
                value: "E9 1BW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 59,
                column: "Postcode",
                value: "ME4 2ZL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 60,
                column: "Postcode",
                value: "PO1 8EE");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 61,
                column: "Postcode",
                value: "PO3 2ND");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 62,
                column: "Postcode",
                value: "PO2 8TT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 63,
                column: "Postcode",
                value: "SO17 3OL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 64,
                column: "Postcode",
                value: "BS4 4FM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 65,
                column: "Postcode",
                value: "SO16 9VG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 66,
                column: "Postcode",
                value: "SO15 2ZN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 67,
                column: "Postcode",
                value: "SO17 1ZH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 68,
                column: "Postcode",
                value: "TN1 1GZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 69,
                column: "Postcode",
                value: "SW5 9IA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 70,
                column: "Postcode",
                value: "E5 7GY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 71,
                column: "Postcode",
                value: "E1 1UR");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 72,
                column: "Postcode",
                value: "ME3 5WL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 73,
                column: "Postcode",
                value: "SW9 8TI");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 74,
                column: "Postcode",
                value: "SW2 2KM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 75,
                column: "Postcode",
                value: "SW8 9FT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 76,
                column: "Postcode",
                value: "N9 7VH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 77,
                column: "Postcode",
                value: "SW5 4RY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 78,
                column: "Postcode",
                value: "SW5 1QP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 79,
                column: "Postcode",
                value: "PL4 8PR");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 80,
                column: "Postcode",
                value: "ME2 7GV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 81,
                column: "Postcode",
                value: "TN2 7HA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 82,
                column: "Postcode",
                value: "N9 3AX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 83,
                column: "Postcode",
                value: "ME1 4LO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 84,
                column: "Postcode",
                value: "PO4 2XA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 85,
                column: "Postcode",
                value: "TR3 1BD");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 86,
                column: "Postcode",
                value: "N4 8CA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 87,
                column: "Postcode",
                value: "TR1 5JX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 88,
                column: "Postcode",
                value: "PO3 4OB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 89,
                column: "Postcode",
                value: "SW10 7VS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 90,
                column: "Postcode",
                value: "E10 9CE");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 91,
                column: "Postcode",
                value: "N7 3DE");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 92,
                column: "Postcode",
                value: "N3 7XC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 93,
                column: "Postcode",
                value: "N2 6OA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 94,
                column: "Postcode",
                value: "PL2 5LA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 95,
                column: "Postcode",
                value: "SO15 3EA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 96,
                column: "Postcode",
                value: "TN1 1FP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 97,
                column: "Postcode",
                value: "TR2 6UU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 98,
                column: "Postcode",
                value: "PL4 5QS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 99,
                column: "Postcode",
                value: "TN1 7CW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 100,
                column: "Postcode",
                value: "E3 1ZO");
        }
    }
}
