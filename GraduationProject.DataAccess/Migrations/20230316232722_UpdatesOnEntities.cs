using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesOnEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Prod_ProductsCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Prod_ProductsCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Prod_ProductsCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Prod_ProductsCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Prod_ProductsCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Prod_ProductsCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Prod_ProductsCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Prod_Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Prod_Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertBy",
                table: "Prod_Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Prod_Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Prod_Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Prod_Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Prod_Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Prod_ProductsCategories");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Prod_ProductsCategories");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Prod_ProductsCategories");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Prod_ProductsCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Prod_ProductsCategories");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Prod_ProductsCategories");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Prod_ProductsCategories");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Prod_Products");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Prod_Products");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "Prod_Products");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Prod_Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Prod_Products");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Prod_Products");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Prod_Products");
        }
    }
}
