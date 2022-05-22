using Microsoft.EntityFrameworkCore.Migrations;

namespace Intsar_F_Project.Data.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1adb34e1-9ecf-4ca7-9e9f-d14d3f8b2a82", "6d598fbb-643c-4f84-b495-6309151d4e72" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5c13b15-3343-4d6f-a5d6-f4351560a734", "27433d9f-91f3-4052-a48d-daf2e4106929" });
        }
    }
}
