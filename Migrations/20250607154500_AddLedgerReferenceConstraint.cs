using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddLedgerReferenceConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add computed column that extracts everything after the initials
            migrationBuilder.Sql(
                @"ALTER TABLE Ledgers ADD ReferenceWithoutInitials AS 
                  SUBSTRING(InvoiceRef, CHARINDEX('/', InvoiceRef), LEN(InvoiceRef)) PERSISTED"
            );

            // Add unique constraint on the computed column
            migrationBuilder.Sql(
                "CREATE UNIQUE NONCLUSTERED INDEX IX_Ledgers_ReferenceWithoutInitials ON Ledgers(ReferenceWithoutInitials)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove the unique index
            migrationBuilder.Sql(
                "DROP INDEX IX_Ledgers_ReferenceWithoutInitials ON Ledgers"
            );

            // Remove the computed column
            migrationBuilder.Sql(
                "ALTER TABLE Ledgers DROP COLUMN ReferenceWithoutInitials"
            );
        }
    }
}
