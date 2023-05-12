using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPcComponentFlagToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isPcComponent",
                table: "Prod_ProductsCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isPcComponent",
                table: "Prod_ProductsCategories");
        }
    }
}
