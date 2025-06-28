using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByConvention.Migrations
{
    public partial class ChangeDateTimeDateType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfCreation",
                table: "Departments",
                type: "date",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "getdate()");
        }
    }
}
