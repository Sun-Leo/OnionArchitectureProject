using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Menus_MenusMenuID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OurDishes_OurDishesID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MenusMenuID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OurDishesID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MenusMenuID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OurDishesID",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OurDishes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ProductPrice",
                table: "OurDishes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ProductPrice",
                table: "Menus",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "OurDishes");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "OurDishes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Menus");

            migrationBuilder.AddColumn<int>(
                name: "MenusMenuID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OurDishesID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_MenusMenuID",
                table: "Products",
                column: "MenusMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OurDishesID",
                table: "Products",
                column: "OurDishesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Menus_MenusMenuID",
                table: "Products",
                column: "MenusMenuID",
                principalTable: "Menus",
                principalColumn: "MenuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OurDishes_OurDishesID",
                table: "Products",
                column: "OurDishesID",
                principalTable: "OurDishes",
                principalColumn: "OurDishesID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
