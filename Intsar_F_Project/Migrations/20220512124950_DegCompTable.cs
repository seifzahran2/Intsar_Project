using Microsoft.EntityFrameworkCore.Migrations;

namespace Intsar_F_Project.Migrations
{
    public partial class DegCompTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "degComps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectIdea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExecutionQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gui = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complexity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectBbenefit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    language_Tools = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasteringTheTools = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfrastructureUsed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverallRating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_degComps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "degComps");
        }
    }
}
