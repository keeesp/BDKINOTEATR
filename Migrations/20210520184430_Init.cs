using Microsoft.EntityFrameworkCore.Migrations;

namespace DBKINOTEATR.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOLJNOSTI",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAIMENOVANIE_DOLJNOSTI = table.Column<string>(nullable: true),
                    OKLAD = table.Column<int>(nullable: false),
                    OBYAZANOSTI = table.Column<string>(nullable: true),
                    TREBOVANIYA = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOLJNOSTI", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOLJNOSTI");
        }
    }
}
