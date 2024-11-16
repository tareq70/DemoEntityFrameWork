using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03EntityFrameWork.Migrations
{
    public partial class Migration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Emps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emps",
                table: "Emps",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emps",
                table: "Emps");

            migrationBuilder.RenameTable(
                name: "Emps",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
