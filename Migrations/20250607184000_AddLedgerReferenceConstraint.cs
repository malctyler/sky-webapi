using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    public partial class AddLedgerReferenceConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add computed column
            migrationBuilder.Sql(
                "ALTER TABLE Ledgers ADD ReferenceWithoutInitials AS " +
                "SUBSTRING(InvoiceRef, CHARINDEX('/', InvoiceRef), LEN(InvoiceRef)) PERSISTED"
            );

            // Create unique index on computed column
            migrationBuilder.Sql(
                "CREATE UNIQUE NONCLUSTERED INDEX IX_Ledgers_ReferenceWithoutInitials " +
                "ON Ledgers(ReferenceWithoutInitials)"
            );

            // Update InvoiceRef column length
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceRef",
                table: "Ledgers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the index first
            migrationBuilder.Sql(
                "DROP INDEX IX_Ledgers_ReferenceWithoutInitials ON Ledgers"
            );

            // Drop the computed column
            migrationBuilder.Sql(
                "ALTER TABLE Ledgers DROP COLUMN ReferenceWithoutInitials"
            );

            // Revert InvoiceRef column
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceRef",
                table: "Ledgers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
