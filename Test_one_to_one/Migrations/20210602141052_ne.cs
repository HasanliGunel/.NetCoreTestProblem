using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_one_to_one.Migrations
{
    public partial class ne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGrades_StudentGradeID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentGradeID",
                table: "Students",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentGradeID",
                table: "Students",
                newName: "IX_Students_StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_StudentID",
                table: "StudentGrades",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_Students_StudentID",
                table: "StudentGrades",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentID",
                table: "Students",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_Students_StudentID",
                table: "StudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentGrades_StudentID",
                table: "StudentGrades");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Students",
                newName: "StudentGradeID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentID",
                table: "Students",
                newName: "IX_Students_StudentGradeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGrades_StudentGradeID",
                table: "Students",
                column: "StudentGradeID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
