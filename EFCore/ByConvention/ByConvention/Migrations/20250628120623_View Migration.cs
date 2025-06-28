using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByConvention.Migrations
{
    public partial class ViewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view EmployeeDepartmentView
                                   with Encryption
                                   as
                                     select E.EmpId , E.Name , D.Id , D.DepartmentName
                                     from Employees E , Departments D
                                     where E.EmpId = D.Id
                                   ");
            }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view EmployeeDepartmentView");
        }
    }
}
