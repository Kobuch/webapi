using Microsoft.EntityFrameworkCore.Migrations;

namespace Jppapi.Migrations
{
    public partial class Startowamigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stawki",
                columns: table => new
                {
                    Stawki_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stawka_podstawowa = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Dniowka_zagraniczna = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stawki", x => x.Stawki_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stawki");
        }
    }
}
