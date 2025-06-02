using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddScheduledInspections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduledInspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoldingID = table.Column<int>(type: "int", nullable: false),
                    ScheduledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectorID = table.Column<int>(type: "int", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledInspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledInspections_Inspectors_InspectorID",
                        column: x => x.InspectorID,
                        principalTable: "Inspectors",
                        principalColumn: "InspectorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScheduledInspections_PlantHoldings_HoldingID",
                        column: x => x.HoldingID,
                        principalTable: "PlantHoldings",
                        principalColumn: "HoldingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledInspections_HoldingID",
                table: "ScheduledInspections",
                column: "HoldingID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledInspections_InspectorID",
                table: "ScheduledInspections",
                column: "InspectorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduledInspections");
        }
    }
}
