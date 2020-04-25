using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeatherService.Migrations
{
    public partial class LocationsFieldRequestableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Requestable",
                table: "Locations",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Requestable",
                table: "Locations");
        }
    }
}
