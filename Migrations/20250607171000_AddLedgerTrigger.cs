using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    public partial class AddLedgerTrigger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.triggers WHERE name = 'TR_Ledger_PreventDuplicateReferences')
                BEGIN
                    EXEC('CREATE TRIGGER TR_Ledger_PreventDuplicateReferences
                    ON Ledgers
                    AFTER INSERT, UPDATE
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                        IF EXISTS (
                            SELECT 1
                            FROM inserted i
                            JOIN Ledgers l ON 
                                RIGHT(l.InvoiceRef, LEN(l.InvoiceRef) - CHARINDEX(''/'', l.InvoiceRef)) = 
                                RIGHT(i.InvoiceRef, LEN(i.InvoiceRef) - CHARINDEX(''/'', i.InvoiceRef))
                            WHERE l.Id != i.Id
                        )
                        BEGIN
                            RAISERROR(''Cannot insert duplicate invoice reference pattern. The date/customer portion of this reference already exists.'', 16, 1);
                            ROLLBACK TRANSACTION;
                            RETURN;
                        END
                    END')
                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS TR_Ledger_PreventDuplicateReferences");
        }
    }
}
