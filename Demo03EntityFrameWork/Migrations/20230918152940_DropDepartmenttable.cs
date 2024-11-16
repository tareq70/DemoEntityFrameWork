using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03EntityFrameWork.Migrations
{
    public partial class DropDepartmenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departmeents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmeents",
                columns: table => new
                {
                    DepartmeentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmeents", x => x.DepartmeentId);
                });
        }
    }
}
