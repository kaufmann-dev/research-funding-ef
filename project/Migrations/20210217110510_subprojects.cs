using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class subprojects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SUBPROJECT",
                columns: table => new
                {
                    SUBPROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    FOCUS_RESEARCH = table.Column<int>(type: "int", nullable: false),
                    APPLIED_RESEARCH = table.Column<int>(type: "int", nullable: false),
                    THEORETICAL_RESEARCH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUBPROJECT", x => x.SUBPROJECT_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SUBPROJECT");
        }
    }
}
