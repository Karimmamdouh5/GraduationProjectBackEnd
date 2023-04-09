﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixingTrial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_CategoryID",
                table: "Prod_ShopProducts");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Prod_ShopProducts",
                newName: "Category_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Prod_ShopProducts_CategoryID",
                table: "Prod_ShopProducts",
                newName: "IX_Prod_ShopProducts_Category_Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Prod_ProductsCategories",
                newName: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_Category_Id",
                table: "Prod_ShopProducts",
                column: "Category_Id",
                principalTable: "Prod_ProductsCategories",
                principalColumn: "Category_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_Category_Id",
                table: "Prod_ShopProducts");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "Prod_ShopProducts",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Prod_ShopProducts_Category_Id",
                table: "Prod_ShopProducts",
                newName: "IX_Prod_ShopProducts_CategoryID");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "Prod_ProductsCategories",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prod_ShopProducts_Prod_ProductsCategories_CategoryID",
                table: "Prod_ShopProducts",
                column: "CategoryID",
                principalTable: "Prod_ProductsCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
