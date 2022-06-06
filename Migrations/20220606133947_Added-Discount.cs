using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaDevUCDB.Migrations
{
    public partial class AddedDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Desconto",
                table: "Pedido",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desconto",
                table: "Pedido");
        }
    }
}
