using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class gutermigrane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituteId",
                table: "SUBPROJECT",
                type: "INT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FACILITY_TYPE",
                table: "FACILITIES",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "FUNDING",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    DEBITOR_ID = table.Column<int>(type: "int", nullable: false),
                    FUNDING_AMOUNT = table.Column<decimal>(type: "DECIMAL(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNDING", x => new { x.PROJECT_ID, x.DEBITOR_ID });
                    table.ForeignKey(
                        name: "FK_FUNDING_DEBITORS_DEBITOR_ID",
                        column: x => x.DEBITOR_ID,
                        principalTable: "DEBITORS",
                        principalColumn: "DEBITOR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FUNDING_PROJECTS_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECTS",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SUBPROJECT_InstituteId",
                table: "SUBPROJECT",
                column: "InstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_FUNDING_DEBITOR_ID",
                table: "FUNDING",
                column: "DEBITOR_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SUBPROJECT_FACILITIES_InstituteId",
                table: "SUBPROJECT",
                column: "InstituteId",
                principalTable: "FACILITIES",
                principalColumn: "FACILITY_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SUBPROJECT_FACILITIES_InstituteId",
                table: "SUBPROJECT");

            migrationBuilder.DropTable(
                name: "FUNDING");

            migrationBuilder.DropIndex(
                name: "IX_SUBPROJECT_InstituteId",
                table: "SUBPROJECT");

            migrationBuilder.DropColumn(
                name: "InstituteId",
                table: "SUBPROJECT");

            migrationBuilder.DropColumn(
                name: "FACILITY_TYPE",
                table: "FACILITIES");
        }
    }
}
