using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoloPark.Server.Data.Migrations
{
    public partial class Editando_Tabela_Usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoConta",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TipoConta",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AspNetUsers");
        }
    }
}
