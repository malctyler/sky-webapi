using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_webapi.Migrations
{
    public partial class AddUniqueCompanyNameConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // First, ensure any null company names are updated to a placeholder
            migrationBuilder.Sql(@"
                UPDATE Customers 
                SET CompanyName = 'Unnamed Company ' + CAST(CustID as varchar(10))
                WHERE CompanyName IS NULL OR CompanyName = ''");

            // Update company names to ensure uniqueness by appending CustID where duplicates exist
            migrationBuilder.Sql(@"
                ;WITH DuplicateCheck AS (
                    SELECT 
                        CustID,
                        CompanyName,
                        ROW_NUMBER() OVER(PARTITION BY CompanyName ORDER BY CustID) as RowNum
                    FROM Customers
                    WHERE CompanyName IS NOT NULL
                )
                UPDATE c
                SET CompanyName = c.CompanyName + ' ' + CAST(c.CustID as varchar(10))
                FROM Customers c
                INNER JOIN DuplicateCheck d ON c.CustID = d.CustID
                WHERE d.RowNum > 1");

            // Make CompanyName required
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

            // Add unique constraint
            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyName",
                table: "Customers",
                column: "CompanyName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove unique constraint
            migrationBuilder.DropIndex(
                name: "IX_Customers_CompanyName",
                table: "Customers");

            // Make CompanyName nullable again
            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
