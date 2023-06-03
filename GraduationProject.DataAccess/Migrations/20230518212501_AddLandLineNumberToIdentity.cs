using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddLandLineNumberToIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LandLineNumber",
                schema: "Security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LandLineNumber",
                schema: "Security",
                table: "Users");
        }
    }
}
