using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_First.Migrations
{
    public partial class removeddepartmentdescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentDescription",
                table: "Lecturers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDescription",
                table: "Lecturers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
