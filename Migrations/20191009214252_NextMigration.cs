using Microsoft.EntityFrameworkCore.Migrations;

namespace Claymore.Migrations
{
    public partial class NextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Postings_ActivityId",
                table: "Guest");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "Guest",
                newName: "PostingID");

            migrationBuilder.RenameIndex(
                name: "IX_Guest_ActivityId",
                table: "Guest",
                newName: "IX_Guest_PostingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Postings_PostingID",
                table: "Guest",
                column: "PostingID",
                principalTable: "Postings",
                principalColumn: "PostingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Postings_PostingID",
                table: "Guest");

            migrationBuilder.RenameColumn(
                name: "PostingID",
                table: "Guest",
                newName: "ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_Guest_PostingID",
                table: "Guest",
                newName: "IX_Guest_ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Postings_ActivityId",
                table: "Guest",
                column: "ActivityId",
                principalTable: "Postings",
                principalColumn: "PostingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
