using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jppapi.Migrations
{
    public partial class dodanietabelirozliczeniednia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RozliczeniaDnii",
                columns: table => new
                {
                    Rozliczenie_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NrPracownika = table.Column<int>(type: "int", nullable: false),
                    Gdzie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StawkaDzienna = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Procent = table.Column<int>(type: "int", nullable: false),
                    Dniowka = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoWorkDay = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RozliczeniaDnii", x => x.Rozliczenie_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RozliczeniaDnii");
        }
    }
}
