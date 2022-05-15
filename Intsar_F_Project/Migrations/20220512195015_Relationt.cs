using Microsoft.EntityFrameworkCore.Migrations;

namespace Intsar_F_Project.Migrations
{
    public partial class Relationt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_degComps_compRegs_compRegId",
                table: "degComps");

            migrationBuilder.DropIndex(
                name: "IX_degComps_compRegId",
                table: "degComps");

            migrationBuilder.DropColumn(
                name: "compId",
                table: "degComps");

            migrationBuilder.AlterColumn<int>(
                name: "compRegId",
                table: "degComps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_degComps_compRegId",
                table: "degComps",
                column: "compRegId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_degComps_compRegs_compRegId",
                table: "degComps",
                column: "compRegId",
                principalTable: "compRegs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_degComps_compRegs_compRegId",
                table: "degComps");

            migrationBuilder.DropIndex(
                name: "IX_degComps_compRegId",
                table: "degComps");

            migrationBuilder.AlterColumn<int>(
                name: "compRegId",
                table: "degComps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "compId",
                table: "degComps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_degComps_compRegId",
                table: "degComps",
                column: "compRegId");

            migrationBuilder.AddForeignKey(
                name: "FK_degComps_compRegs_compRegId",
                table: "degComps",
                column: "compRegId",
                principalTable: "compRegs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
