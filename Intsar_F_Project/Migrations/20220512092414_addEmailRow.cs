using Microsoft.EntityFrameworkCore.Migrations;

namespace Intsar_F_Project.Migrations
{
    public partial class addEmailRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "projects");
        }
    }
}
