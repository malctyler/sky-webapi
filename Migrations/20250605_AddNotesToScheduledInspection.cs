using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_webapi.Migrations
{
    public partial class AddNotesToScheduledInspection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "ScheduledInspections",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "ScheduledInspections");
        }
    }
}
