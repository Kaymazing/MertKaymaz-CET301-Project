using Microsoft.EntityFrameworkCore.Migrations;

namespace MertKaymaz_301Project.Migrations
{
    public partial class vehicleowneradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Vehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Vehicles");
        }
    }
}
