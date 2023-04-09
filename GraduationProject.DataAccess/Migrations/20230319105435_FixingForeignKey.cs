using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixingForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prod_Products_Prod_ProductsCategories_CategoryID",
                table: "Prod_Products");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Prod_Products",
                newName: "Category_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Prod_Products_CategoryID",
                table: "Prod_Products",
                newName: "IX_Prod_Products_Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prod_Products_Prod_ProductsCategories_Category_Id",
                table: "Prod_Products",
                column: "Category_Id",
                principalTable: "Prod_ProductsCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prod_Products_Prod_ProductsCategories_Category_Id",
                table: "Prod_Products");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "Prod_Products",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Prod_Products_Category_Id",
                table: "Prod_Products",
                newName: "IX_Prod_Products_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prod_Products_Prod_ProductsCategories_CategoryID",
                table: "Prod_Products",
                column: "CategoryID",
                principalTable: "Prod_ProductsCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
