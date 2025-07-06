using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddMultiInspectColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MultiInspect",
                table: "PlantCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPNhc1xHk7tw2rzVSZxTOnC48JDKTTuYQqioqdDsKmPJUVR4gStVMlP6z4RVVEz3pg==");

            migrationBuilder.UpdateData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "MultiInspect",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "MultiInspect",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "MultiInspect",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "MultiInspect",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "MultiInspect",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MultiInspect",
                table: "PlantCategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELGL2lkp7s2nk8eQVUDtZFjZ5b+cL+Z2klExMBPkzOtqTiNn2Fr2tg++R5BVtS5rsQ==");
        }
    }
}
