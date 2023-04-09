using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditOnShopProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Prod_ShopProducts");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Prod_ShopProducts");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Prod_ShopProducts");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Prod_ShopProducts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Prod_ShopProducts");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Prod_ShopProducts");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Prod_ShopProducts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Prod_ShopProducts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Prod_ShopProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Prod_ShopProducts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Prod_ShopProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Prod_ShopProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Prod_ShopProducts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Prod_ShopProducts",
                type: "datetime2",
                nullable: true);
        }
    }
}
