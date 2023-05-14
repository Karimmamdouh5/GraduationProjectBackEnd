using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateCompTableAndCompPurposesWithSomeExtraUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prod_Products");

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
                nullable: true);

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
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comp_CompPurposes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_CompPurposes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Comp_CompComputers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purposeid = table.Column<int>(type: "int", nullable: false),
                    isPc = table.Column<bool>(type: "bit", nullable: false),
                    isLaptop = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_CompComputers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comp_CompComputers_Comp_CompPurposes_Purposeid",
                        column: x => x.Purposeid,
                        principalTable: "Comp_CompPurposes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comp_CompComputers_Purposeid",
                table: "Comp_CompComputers",
                column: "Purposeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comp_CompComputers");

            migrationBuilder.DropTable(
                name: "Comp_CompPurposes");

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

            migrationBuilder.CreateTable(
                name: "Prod_Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prod_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prod_Products_Prod_ProductsCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Prod_ProductsCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prod_Products_CategoryID",
                table: "Prod_Products",
                column: "CategoryID");
        }
    }
}
