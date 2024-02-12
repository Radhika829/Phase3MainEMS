using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P3EmployeeMain.Migrations
{
    public partial class emp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DId",
                table: "Employee");
        }
    }
}
