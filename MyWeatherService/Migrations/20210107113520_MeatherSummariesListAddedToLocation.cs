using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeatherService.Migrations
{
    public partial class MeatherSummariesListAddedToLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WeatherSummaries_LocationId",
                table: "WeatherSummaries");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherSummaries_LocationId",
                table: "WeatherSummaries",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WeatherSummaries_LocationId",
                table: "WeatherSummaries");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherSummaries_LocationId",
                table: "WeatherSummaries",
                column: "LocationId",
                unique: true);
        }
    }
}
