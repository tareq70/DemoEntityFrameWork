using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo03EntityFrameWork.Migrations
{
    public partial class RunSqlScriptForCreatingView4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" create View EmployeeSalaryDepartmentView
                with Encryption
                As
                Select E.EmpId EmployeeId ,E.Name EmployeeName , D.DeptId DepartmentId ,D.DepartmentName
                From Departments D ,Emps E
                Where D.DeptId = E.Id"
           );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" drop View EmployeeSalaryDepartmentView");
        }
    }
}
