using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classes.Migrations
{
    public partial class removed_course_code : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Student_Course",
            //    table: "Student");

            //migrationBuilder.DropIndex(
            //    name: "IX_Student_Course_Code",
            //    table: "Student");

            //migrationBuilder.DropColumn(
            //    name: "Classroom_ID",
            //    table: "Student");

            //migrationBuilder.DropColumn(
            //    name: "Course_Code",
            //    table: "Student");

            //migrationBuilder.RenameColumn(
            //    name: "Department_ID",
            //    table: "Student",
            //    newName: "Department_Description");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Student_Department_ID",
            //    table: "Student",
            //    newName: "IX_Student_Department_Description");

            //migrationBuilder.RenameColumn(
            //    name: "Department_ID",
            //    table: "Lecturer",
            //    newName: "Department_Description");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Lecturer_Department_ID",
            //    table: "Lecturer",
            //    newName: "IX_Lecturer_Department_Description");

            //migrationBuilder.RenameColumn(
            //    name: "Cours_Code",
            //    table: "Department",
            //    newName: "Course_Code");

            //migrationBuilder.RenameColumn(
            //    name: "Code",
            //    table: "Course",
            //    newName: "CCode");

            //migrationBuilder.RenameColumn(
            //    name: "ID",
            //    table: "Administrator",
            //    newName: "AID");

            migrationBuilder.AddColumn<string>(
                name: "CourseCCode",
                table: "Student",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Post",
                table: "Administrator",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseCCode",
                table: "Student",
                column: "CourseCCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_CourseCCode",
                table: "Student",
                column: "CourseCCode",
                principalTable: "Course",
                principalColumn: "CCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_CourseCCode",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_CourseCCode",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CourseCCode",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Department_Description",
                table: "Student",
                newName: "Department_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Department_Description",
                table: "Student",
                newName: "IX_Student_Department_ID");

            migrationBuilder.RenameColumn(
                name: "Department_Description",
                table: "Lecturer",
                newName: "Department_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Lecturer_Department_Description",
                table: "Lecturer",
                newName: "IX_Lecturer_Department_ID");

            migrationBuilder.RenameColumn(
                name: "Course_Code",
                table: "Department",
                newName: "Cours_Code");

            migrationBuilder.RenameColumn(
                name: "CCode",
                table: "Course",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "AID",
                table: "Administrator",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "Classroom_ID",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Course_Code",
                table: "Student",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Post",
                table: "Administrator",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_Code",
                table: "Student",
                column: "Course_Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course",
                table: "Student",
                column: "Course_Code",
                principalTable: "Course",
                principalColumn: "Code");
        }
    }
}
