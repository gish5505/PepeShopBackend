using Microsoft.EntityFrameworkCore.Migrations;

namespace PepeShop.Migrations
{
    public partial class BasketToProducts1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Basket_BasketId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Product_ItemId",
                table: "BasketItem");

            migrationBuilder.DropIndex(
                name: "IX_BasketItem_ItemId",
                table: "BasketItem");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "BasketItem");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "BasketItem",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "BasketItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_ProductId",
                table: "BasketItem",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Basket_BasketId",
                table: "BasketItem",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Product_ProductId",
                table: "BasketItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Basket_BasketId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Product_ProductId",
                table: "BasketItem");

            migrationBuilder.DropIndex(
                name: "IX_BasketItem_ProductId",
                table: "BasketItem");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "BasketItem");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "BasketItem",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "BasketItem",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_ItemId",
                table: "BasketItem",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Basket_BasketId",
                table: "BasketItem",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Product_ItemId",
                table: "BasketItem",
                column: "ItemId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
