using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_First.Migrations
{
    public partial class student_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classroom_ID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Course_Code",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Department_ID",
                table: "Students",
                newName: "Department");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Students",
                newName: "Department_ID");

            migrationBuilder.AddColumn<int>(
                name: "Classroom_ID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Course_Code",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
