using Microsoft.EntityFrameworkCore.Migrations;

namespace Claymore.Migrations
{
    public partial class PostInterview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ScreenEmail",
                table: "Postings",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScreenEmail",
                table: "Postings");
        }
    }
}
