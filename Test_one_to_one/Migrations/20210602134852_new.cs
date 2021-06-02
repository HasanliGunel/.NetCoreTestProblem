using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_one_to_one.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Studentss_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studentss",
                table: "Studentss");

            migrationBuilder.RenameTable(
                name: "Studentss",
                newName: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentGradeID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentGrades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    GradeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGrades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentGrades_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentGradeID",
                table: "Students",
                column: "StudentGradeID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_GradeID",
                table: "StudentGrades",
                column: "GradeID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGrades_StudentGradeID",
                table: "Students",
                column: "StudentGradeID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGrades_StudentGradeID",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentGrades");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentGradeID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentGradeID",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Studentss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studentss",
                table: "Studentss",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Studentss_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Studentss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
