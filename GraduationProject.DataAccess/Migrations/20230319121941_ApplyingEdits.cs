using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ApplyingEdits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_CategoryIDID",
                table: "Prod_ShopProducts");

            migrationBuilder.RenameColumn(
                name: "CategoryIDID",
                table: "Prod_ShopProducts",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Prod_ShopProducts_CategoryIDID",
                table: "Prod_ShopProducts",
                newName: "IX_Prod_ShopProducts_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_CategoryID",
                table: "Prod_ShopProducts",
                column: "CategoryID",
                principalTable: "Prod_ProductsCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_CategoryID",
                table: "Prod_ShopProducts");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Prod_ShopProducts",
                newName: "CategoryIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Prod_ShopProducts_CategoryID",
                table: "Prod_ShopProducts",
                newName: "IX_Prod_ShopProducts_CategoryIDID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_CategoryIDID",
                table: "Prod_ShopProducts",
                column: "CategoryIDID",
                principalTable: "Prod_ProductsCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
