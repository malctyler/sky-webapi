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
            // Create a trigger to check for duplicate references ignoring initials
            migrationBuilder.Sql(@"
                CREATE TRIGGER TR_Ledger_PreventDuplicateReferences
                ON Ledgers
                AFTER INSERT, UPDATE
                AS
                BEGIN
                    SET NOCOUNT ON;

                    IF EXISTS (
                        SELECT 1
                        FROM inserted i
                        JOIN Ledgers l ON 
                            SUBSTRING(l.InvoiceRef, CHARINDEX('/', l.InvoiceRef), LEN(l.InvoiceRef)) = 
                            SUBSTRING(i.InvoiceRef, CHARINDEX('/', i.InvoiceRef), LEN(i.InvoiceRef))
                        WHERE l.Id != i.Id
                    )
                    BEGIN
                        THROW 51000, 'Cannot insert duplicate invoice reference pattern. The date/customer portion of this reference already exists.', 1;
                    END
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS TR_Ledger_PreventDuplicateReferences");
        }
    }
}
