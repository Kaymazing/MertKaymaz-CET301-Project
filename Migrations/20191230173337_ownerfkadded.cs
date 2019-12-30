using Microsoft.EntityFrameworkCore.Migrations;

namespace MertKaymaz_301Project.Migrations
{
    public partial class ownerfkadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnertId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_OwnertId",
                table: "Vehicles",
                column: "OwnertId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Owners_OwnertId",
                table: "Vehicles",
                column: "OwnertId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Owners_OwnertId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_OwnertId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OwnertId",
                table: "Vehicles");
        }
    }
}
