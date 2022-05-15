using Microsoft.EntityFrameworkCore.Migrations;

namespace Intsar_F_Project.Migrations
{
    public partial class IsprojecSent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Result",
                table: "compRegs");

            migrationBuilder.AddColumn<bool>(
                name: "IsprojecSent",
                table: "compRegs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsprojecSent",
                table: "compRegs");

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "compRegs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
