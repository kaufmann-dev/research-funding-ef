using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class lol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LEGAL_FOUNDATION",
                table: "PROJECTS",
                type: "VARCHAR(4)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FACILITIES",
                columns: table => new
                {
                    FACILITY_ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FACILITY_CODE = table.Column<string>(type: "VARCHAR(7)", nullable: false),
                    FACILITY_TITLE = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACILITIES", x => x.FACILITY_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FACILITIES");

            migrationBuilder.DropColumn(
                name: "LEGAL_FOUNDATION",
                table: "PROJECTS");
        }
    }
}
