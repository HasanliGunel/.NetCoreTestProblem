using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_one_to_one.Migrations
{
    public partial class ra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
