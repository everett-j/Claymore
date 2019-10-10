using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Claymore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Postings",
                columns: table => new
                {
                    PostingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatorId = table.Column<int>(nullable: false),
                    DateApply = table.Column<DateTime>(nullable: false),
                    JobLink = table.Column<string>(nullable: true),
                    JobPosting = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    PositionTitle = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    RecruiterName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    PhoneScreen = table.Column<DateTime>(nullable: false),
                    ScreenNotes = table.Column<string>(nullable: true),
                    PhoneInterview = table.Column<DateTime>(nullable: false),
                    PhoneNotes = table.Column<string>(nullable: true),
                    Interview = table.Column<DateTime>(nullable: false),
                    InterviewNotes = table.Column<string>(nullable: true),
                    Denied = table.Column<DateTime>(nullable: false),
                    DeniedNotes = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postings", x => x.PostingId);
                    table.ForeignKey(
                        name: "FK_Postings_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ActivityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_Guest_Postings_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Postings",
                        principalColumn: "PostingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guest_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guest_ActivityId",
                table: "Guest",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_UserId",
                table: "Guest",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Postings_CreatorId",
                table: "Postings",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Postings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
