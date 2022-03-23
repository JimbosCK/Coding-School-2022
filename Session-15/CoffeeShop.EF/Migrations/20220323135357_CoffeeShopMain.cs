using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.EF.Migrations
{
    public partial class CoffeeShopMain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoffeeShop",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeShop", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CoffeeShop_ID",
                table: "Customers",
                column: "ID",
                principalTable: "CoffeeShop",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CoffeeShop_ID",
                table: "Employees",
                column: "ID",
                principalTable: "CoffeeShop",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_CoffeeShop_ID",
                table: "ProductCategories",
                column: "ID",
                principalTable: "CoffeeShop",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoffeeShop_ID",
                table: "Products",
                column: "ID",
                principalTable: "CoffeeShop",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_CoffeeShop_ID",
                table: "Transactions",
                column: "ID",
                principalTable: "CoffeeShop",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CoffeeShop_ID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CoffeeShop_ID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_CoffeeShop_ID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoffeeShop_ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_CoffeeShop_ID",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "CoffeeShop");
        }
    }
}
