using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03EntityFrameWork.Migrations
{
    public partial class RunSqlScriptForCreatingView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Emps",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Test",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Emps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Test");
        }
    }
}
