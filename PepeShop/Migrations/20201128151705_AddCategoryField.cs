﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PepeShop.Migrations
{
    public partial class AddCategoryField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Product",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Product");
        }
    }
}
