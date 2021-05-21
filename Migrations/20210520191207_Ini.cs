using Microsoft.EntityFrameworkCore.Migrations;

namespace DBKINOTEATR.Migrations
{
    public partial class Ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SOTRUDNIKI",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phone_number = table.Column<long>(nullable: false),
                    adress = table.Column<string>(nullable: true),
                    pol = table.Column<string>(nullable: true),
                    vozrast = table.Column<long>(nullable: false),
                    FIO = table.Column<string>(nullable: true),
                    pasportnie_danie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOTRUDNIKI", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SOTRUDNIKI");
        }
    }
}
