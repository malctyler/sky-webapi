using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCustomerValidationConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Postcode",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line4",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line3",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line2",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line1",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactTitle",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactSurname",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactFirstNames",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1,
                column: "Postcode",
                value: "N7 5SL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2,
                column: "Postcode",
                value: "BS1 9CL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3,
                column: "Postcode",
                value: "SO14 2OF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4,
                column: "Postcode",
                value: "E6 1VD");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5,
                column: "Postcode",
                value: "E6 1NW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6,
                column: "Postcode",
                value: "SW10 4YO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7,
                column: "Postcode",
                value: "N10 7EP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8,
                column: "Postcode",
                value: "SW10 5UT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9,
                column: "Postcode",
                value: "N8 3BA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10,
                column: "Postcode",
                value: "E10 5DZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 11,
                column: "Postcode",
                value: "PL1 4XW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 12,
                column: "Postcode",
                value: "N5 9UW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 13,
                column: "Postcode",
                value: "N6 5AV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 14,
                column: "Postcode",
                value: "SW10 2SX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 15,
                column: "Postcode",
                value: "E3 1TV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 16,
                column: "Postcode",
                value: "TN3 8LA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 17,
                column: "Postcode",
                value: "E6 7TR");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 18,
                column: "Postcode",
                value: "N7 2JX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 19,
                column: "Postcode",
                value: "SO16 4JE");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 20,
                column: "Postcode",
                value: "TN4 4OP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 21,
                column: "Postcode",
                value: "TN4 9AM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 22,
                column: "Postcode",
                value: "E7 1UY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 23,
                column: "Postcode",
                value: "BS1 7OJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 24,
                column: "Postcode",
                value: "EX2 7GS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 25,
                column: "Postcode",
                value: "N5 4HT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 26,
                column: "Postcode",
                value: "SO17 1ZP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 27,
                column: "Postcode",
                value: "N6 1CD");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 28,
                column: "Postcode",
                value: "CT2 2HQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 29,
                column: "Postcode",
                value: "N7 6HJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 30,
                column: "Postcode",
                value: "E3 2MM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 31,
                column: "Postcode",
                value: "E9 9PC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 32,
                column: "Postcode",
                value: "BS4 2JX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 33,
                column: "Postcode",
                value: "PL3 3RA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 34,
                column: "Postcode",
                value: "TN3 5ZW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 35,
                column: "Postcode",
                value: "SW10 1BA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 36,
                column: "Postcode",
                value: "BS4 4VS");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 37,
                column: "Postcode",
                value: "BS3 3WL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 38,
                column: "Postcode",
                value: "TR3 8NP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 39,
                column: "Postcode",
                value: "ME2 5RA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 40,
                column: "Postcode",
                value: "EX2 5BF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 41,
                column: "Postcode",
                value: "TR3 9GL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 42,
                column: "Postcode",
                value: "TN1 8TO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 43,
                column: "Postcode",
                value: "PO2 7AC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 44,
                column: "Postcode",
                value: "N7 4RQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 45,
                column: "Postcode",
                value: "SO17 1HM");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 46,
                column: "Postcode",
                value: "SO16 2IU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 47,
                column: "Postcode",
                value: "N4 6UK");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 48,
                column: "Postcode",
                value: "EX4 7KC");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 49,
                column: "Postcode",
                value: "PL4 6EY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 50,
                column: "Postcode",
                value: "SW8 6MH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 51,
                column: "Postcode",
                value: "PO2 8BY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 52,
                column: "Postcode",
                value: "CT3 5TH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 53,
                column: "Postcode",
                value: "ME2 4WA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 54,
                column: "Postcode",
                value: "E9 6CQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 55,
                column: "Postcode",
                value: "PL2 1LP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 56,
                column: "Postcode",
                value: "E8 3UO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 57,
                column: "Postcode",
                value: "TN2 2HJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 58,
                column: "Postcode",
                value: "SW7 7LY");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 59,
                column: "Postcode",
                value: "TN4 8IR");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 60,
                column: "Postcode",
                value: "PL2 8AT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 61,
                column: "Postcode",
                value: "SW9 4ZF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 62,
                column: "Postcode",
                value: "SO17 7XH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 63,
                column: "Postcode",
                value: "TN1 3TA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 64,
                column: "Postcode",
                value: "N2 3HZ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 65,
                column: "Postcode",
                value: "SO14 5DN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 66,
                column: "Postcode",
                value: "E3 7ZJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 67,
                column: "Postcode",
                value: "N3 1HX");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 68,
                column: "Postcode",
                value: "EX3 8GJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 69,
                column: "Postcode",
                value: "TR4 5CA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 70,
                column: "Postcode",
                value: "PL2 7ZJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 71,
                column: "Postcode",
                value: "BN2 1EN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 72,
                column: "Postcode",
                value: "PL4 7NW");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 73,
                column: "Postcode",
                value: "SO15 8UG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 74,
                column: "Postcode",
                value: "SO16 2RU");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 75,
                column: "Postcode",
                value: "PO3 3OO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 76,
                column: "Postcode",
                value: "BS4 2OD");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 77,
                column: "Postcode",
                value: "E8 2NG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 78,
                column: "Postcode",
                value: "SW7 7ZH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 79,
                column: "Postcode",
                value: "E6 8BJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 80,
                column: "Postcode",
                value: "E5 2DJ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 81,
                column: "Postcode",
                value: "E9 5HQ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 82,
                column: "Postcode",
                value: "E1 9OD");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 83,
                column: "Postcode",
                value: "E10 6WA");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 84,
                column: "Postcode",
                value: "TR3 4HN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 85,
                column: "Postcode",
                value: "E5 8TP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 86,
                column: "Postcode",
                value: "ME1 6PV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 87,
                column: "Postcode",
                value: "SW7 1RI");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 88,
                column: "Postcode",
                value: "E9 6VT");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 89,
                column: "Postcode",
                value: "SO16 4LF");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 90,
                column: "Postcode",
                value: "PL2 5FV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 91,
                column: "Postcode",
                value: "N7 9GH");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 92,
                column: "Postcode",
                value: "N5 1UP");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 93,
                column: "Postcode",
                value: "N3 5UO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 94,
                column: "Postcode",
                value: "N5 7NB");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 95,
                column: "Postcode",
                value: "SO16 5TG");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 96,
                column: "Postcode",
                value: "SW6 8AN");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 97,
                column: "Postcode",
                value: "TR2 3BD");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 98,
                column: "Postcode",
                value: "BS3 5JL");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 99,
                column: "Postcode",
                value: "E10 9PV");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 100,
                column: "Postcode",
                value: "TN2 1QS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Postcode",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Line4",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line3",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line2",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line1",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactTitle",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactSurname",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ContactFirstNames",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
        }
    }
}
