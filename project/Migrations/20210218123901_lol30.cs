using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class lol30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PROJECT_ID",
                table: "SUBPROJECT",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SUBPROJECT_PROJECT_ID",
                table: "SUBPROJECT",
                column: "PROJECT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SUBPROJECT_PROJECTS_PROJECT_ID",
                table: "SUBPROJECT",
                column: "PROJECT_ID",
                principalTable: "PROJECTS",
                principalColumn: "PROJECT_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SUBPROJECT_PROJECTS_PROJECT_ID",
                table: "SUBPROJECT");

            migrationBuilder.DropIndex(
                name: "IX_SUBPROJECT_PROJECT_ID",
                table: "SUBPROJECT");

            migrationBuilder.DropColumn(
                name: "PROJECT_ID",
                table: "SUBPROJECT");
        }
    }
}
