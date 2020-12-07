using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PepeShop.Migrations
{
    public partial class AddBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BasketId",
                table: "Users",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BasketId",
                table: "Product",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Basket_BasketId",
                table: "Product",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Basket_BasketId",
                table: "Users",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Basket_BasketId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Basket_BasketId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropIndex(
                name: "IX_Users_BasketId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Product_BasketId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Product");
        }
    }
}
