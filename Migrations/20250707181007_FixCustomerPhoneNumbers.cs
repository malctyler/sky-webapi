using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class FixCustomerPhoneNumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFMsm6S3sBGLhcB3Bnr7P/jBFqtYhIbz9pXnrGg+1YmOvhr2eXbO5yGDYJolviK1hg==");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01234 567890", "07123 456789" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01345 678901", "07234 567890" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01456 789012", "07345 678901" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01567 890123", "07456 789012" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01678 901234", "07567 890123" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01789 012345", "07678 901234" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01890 123456", "07789 012345" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01901 234567", "07890 123456" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01012 345678", "07901 234567" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "01123 456789", "07012 345678" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPNhc1xHk7tw2rzVSZxTOnC48JDKTTuYQqioqdDsKmPJUVR4gStVMlP6z4RVVEz3pg==");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7891", "123-456-7890" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7893", "123-456-7892" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7895", "123-456-7894" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7897", "123-456-7896" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7899", "123-456-7898" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7801", "123-456-7800" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7803", "123-456-7802" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7805", "123-456-7804" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7807", "123-456-7806" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10,
                columns: new[] { "Fax", "Telephone" },
                values: new object[] { "123-456-7809", "123-456-7808" });
        }
    }
}
