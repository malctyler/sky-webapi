using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class UniquePlantDescriptionIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AllPlant_PlantDescription",
                table: "AllPlant",
                column: "PlantDescription",
                unique: true,
                filter: "[PlantDescription] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AllPlant_PlantDescription",
                table: "AllPlant");
        }
    }
}
