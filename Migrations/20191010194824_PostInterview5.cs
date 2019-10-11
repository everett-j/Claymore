using Microsoft.EntityFrameworkCore.Migrations;

namespace Claymore.Migrations
{
    public partial class PostInterview5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DeniedCall",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DeniedEmail",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DeniedLetter",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InterviewCall",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InterviewEmail",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InterviewLetter",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneCall",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneEmail",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneLetter",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ScreenCall",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ScreenLetter",
                table: "Postings",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeniedCall",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "DeniedEmail",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "DeniedLetter",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "InterviewCall",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "InterviewEmail",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "InterviewLetter",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "PhoneCall",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "PhoneEmail",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "PhoneLetter",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "ScreenCall",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "ScreenLetter",
                table: "Postings");
        }
    }
}
