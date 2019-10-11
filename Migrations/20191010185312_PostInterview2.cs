using Microsoft.EntityFrameworkCore.Migrations;

namespace Claymore.Migrations
{
    public partial class PostInterview2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ScreenEmail",
                table: "Postings",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ScreenEmail",
                table: "Postings",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
