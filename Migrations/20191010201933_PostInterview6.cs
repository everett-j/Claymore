using Microsoft.EntityFrameworkCore.Migrations;

namespace Claymore.Migrations
{
    public partial class PostInterview6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ConfirmationEmail",
                table: "Postings",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationEmail",
                table: "Postings");
        }
    }
}
