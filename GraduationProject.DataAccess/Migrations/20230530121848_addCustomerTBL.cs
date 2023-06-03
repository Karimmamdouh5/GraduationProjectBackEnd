using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    public partial class addCustomerTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LandLineNumber",
                schema: "Security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "Security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "Security",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                schema: "Security",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Persons_Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LandLineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Persons_Customers", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerID",
                schema: "Security",
                table: "Users",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_Customers_CustomerID",
                schema: "Security",
                table: "Users",
                column: "CustomerID",
                principalTable: "Persons_Customers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_Customers_CustomerID",
                schema: "Security",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Persons_Customers");

            migrationBuilder.DropIndex(
                name: "IX_Users_CustomerID",
                schema: "Security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                schema: "Security",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Security",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LandLineNumber",
                schema: "Security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Security",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "Security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "Security",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
