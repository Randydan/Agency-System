using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_First.Migrations
{
    public partial class RemovedAdministratorAndLectureSalaryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Administrators");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Students",
                newName: "DoB");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "Lecturers",
                newName: "DoB");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "Administrators",
                newName: "DoB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoB",
                table: "Students",
                newName: "DOB");

            migrationBuilder.RenameColumn(
                name: "DoB",
                table: "Lecturers",
                newName: "Dob");

            migrationBuilder.RenameColumn(
                name: "DoB",
                table: "Administrators",
                newName: "Dob");

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Lecturers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Administrators",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
