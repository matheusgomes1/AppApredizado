using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApredizadoApp.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edital",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Vigencia = table.Column<int>(nullable: false),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    DataValidade = table.Column<DateTime>(nullable: false),
                    Objeto = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    NumeroEdital = table.Column<string>(nullable: true),
                    EntidadeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edital", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edital");
        }
    }
}
