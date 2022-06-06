using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaDevUCDB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome_produto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    data_vencimento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido");
        }
    }
}
