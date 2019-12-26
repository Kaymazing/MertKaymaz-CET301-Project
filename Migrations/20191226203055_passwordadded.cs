using Microsoft.EntityFrameworkCore.Migrations;

namespace MertKaymaz_301Project.Migrations
{
    public partial class passwordadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Owners",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Age", "Mail", "Name", "Password", "PhoneNo", "Surname" },
                values: new object[] { 1, 40, "ozkan.kaymaz@alakurumsal.com", "Ozkan", "f2238d2b7e51aebac6cdcbdebf1fc98bdd9c2091ad4abdfd099a1dfcf5f7a4e9", "532273", "Kaymaz" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Age", "Mail", "Name", "Password", "PhoneNo", "Surname" },
                values: new object[] { 2, 36, "kenan.ilten@alakurumsal.com", "Kenan", "2f7b85e6f1127fb0dfc021d3329da20a40898ead1545e0b930048c6c0af2cc74", "532631", "İlten" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Owners");
        }
    }
}
