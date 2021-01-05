using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeatherService.Migrations
{
    public partial class AddedDonstraintsToEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Postcode",
                table: "Components",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_What3Words_Id",
                table: "What3Words",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeatherSummaries_Id",
                table: "WeatherSummaries",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_Id",
                table: "Weathers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDescriptions_Id",
                table: "WeatherDescriptions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Timezones_Id",
                table: "Timezones",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Temps_Id",
                table: "Temps",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suns_Id",
                table: "Suns",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rises_Id",
                table: "Rises",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Osms_Id",
                table: "Osms",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mercators_Id",
                table: "Mercators",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Id",
                table: "Locations",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Geometries_Id",
                table: "Geometries",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FeelsLikes_Id",
                table: "FeelsLikes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dms_Id",
                table: "Dms",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_Id",
                table: "Currencies",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Components_Id",
                table: "Components",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_Id",
                table: "Annotations",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_What3Words_Id",
                table: "What3Words");

            migrationBuilder.DropIndex(
                name: "IX_WeatherSummaries_Id",
                table: "WeatherSummaries");

            migrationBuilder.DropIndex(
                name: "IX_Weathers_Id",
                table: "Weathers");

            migrationBuilder.DropIndex(
                name: "IX_WeatherDescriptions_Id",
                table: "WeatherDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Timezones_Id",
                table: "Timezones");

            migrationBuilder.DropIndex(
                name: "IX_Temps_Id",
                table: "Temps");

            migrationBuilder.DropIndex(
                name: "IX_Suns_Id",
                table: "Suns");

            migrationBuilder.DropIndex(
                name: "IX_Rises_Id",
                table: "Rises");

            migrationBuilder.DropIndex(
                name: "IX_Osms_Id",
                table: "Osms");

            migrationBuilder.DropIndex(
                name: "IX_Mercators_Id",
                table: "Mercators");

            migrationBuilder.DropIndex(
                name: "IX_Locations_Id",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Geometries_Id",
                table: "Geometries");

            migrationBuilder.DropIndex(
                name: "IX_FeelsLikes_Id",
                table: "FeelsLikes");

            migrationBuilder.DropIndex(
                name: "IX_Dms_Id",
                table: "Dms");

            migrationBuilder.DropIndex(
                name: "IX_Currencies_Id",
                table: "Currencies");

            migrationBuilder.DropIndex(
                name: "IX_Components_Id",
                table: "Components");

            migrationBuilder.DropIndex(
                name: "IX_Annotations_Id",
                table: "Annotations");

            migrationBuilder.AlterColumn<long>(
                name: "Postcode",
                table: "Components",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
