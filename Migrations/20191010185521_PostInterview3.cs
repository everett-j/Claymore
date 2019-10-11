using Microsoft.EntityFrameworkCore.Migrations;

namespace Claymore.Migrations
{
    public partial class PostInterview3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ScreenEmail",
                table: "Postings",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ScreenEmail",
                table: "Postings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
