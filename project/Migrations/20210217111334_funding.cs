using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class funding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RESEARCH_FUNDING_PROJECT",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IS_SMALL_PROJECT = table.Column<sbyte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESEARCH_FUNDING_PROJECT", x => x.PROJECT_ID);
                    table.ForeignKey(
                        name: "FK_RESEARCH_FUNDING_PROJECT_PROJECTS_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECTS",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RESEARCH_FUNDING_PROJECT");
        }
    }
}
