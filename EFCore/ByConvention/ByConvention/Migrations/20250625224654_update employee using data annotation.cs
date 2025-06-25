using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByConvention.Migrations
{
    public partial class updateemployeeusingdataannotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Employees",
                newName: "Id");
        }
    }
}
