using Microsoft.EntityFrameworkCore.Migrations;

namespace Jppapi.Migrations
{
    public partial class dodaniepolalogindotabelirozliczaniednii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "RozliczeniaDnii",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "RozliczeniaDnii");
        }
    }
}
