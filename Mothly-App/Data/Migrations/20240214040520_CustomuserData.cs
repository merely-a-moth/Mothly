using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mothly_App.Migrations
{
    /// <inheritdoc />
    public partial class CustomuserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "AspNetUsers");
        }
    }
}
