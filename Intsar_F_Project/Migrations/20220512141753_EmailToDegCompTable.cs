using Microsoft.EntityFrameworkCore.Migrations;

namespace Intsar_F_Project.Migrations
{
    public partial class EmailToDegCompTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "degComps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "degComps");
        }
    }
}
