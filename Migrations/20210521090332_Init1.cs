using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBKINOTEATR.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "vozrast",
                table: "SOTRUDNIKI",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "FILMS",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAIMENOVANIE = table.Column<string>(nullable: true),
                    STRANA_PROIZVODITEL = table.Column<string>(nullable: true),
                    FIRMA_PROIZVODITEL = table.Column<int>(nullable: false),
                    ACTERS = table.Column<string>(nullable: true),
                    VOZVRASTNIE_OGRANICHENIYA = table.Column<long>(nullable: false),
                    DLITELNOST = table.Column<long>(nullable: false),
                    OPISANIE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FILMS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JANRI",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAIMENOVANIE = table.Column<string>(nullable: true),
                    OPISANIE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JANRI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MESTA",
                columns: table => new
                {
                    ID = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZANYTOST = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MESTA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "REPERTUAR",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cena_bileta = table.Column<long>(nullable: false),
                    DATE = table.Column<DateTime>(nullable: false),
                    vremya_nachala = table.Column<DateTime>(nullable: false),
                    Vremya_okonchaniya = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REPERTUAR", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FILMS");

            migrationBuilder.DropTable(
                name: "JANRI");

            migrationBuilder.DropTable(
                name: "MESTA");

            migrationBuilder.DropTable(
                name: "REPERTUAR");

            migrationBuilder.AlterColumn<long>(
                name: "vozrast",
                table: "SOTRUDNIKI",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(short));
        }
    }
}
