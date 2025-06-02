using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC_DinhTienManh_22103100308.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrithDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ResultID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ResultID);
                    table.ForeignKey(
                        name: "FK_Results_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BrithDate", "FullName" },
                values: new object[] { 1, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BrithDate", "FullName" },
                values: new object[] { 2, new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BrithDate", "FullName" },
                values: new object[] { 3, new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "C" });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ResultID", "Score", "StudentID", "Subject" },
                values: new object[,]
                {
                    { 1, 9f, 1, "Toán" },
                    { 2, 8f, 1, "Van" },
                    { 3, 8f, 2, "Ly" },
                    { 4, 7f, 2, "Hoa" },
                    { 5, 8f, 3, "Anh" },
                    { 6, 7f, 3, "Su" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_StudentID",
                table: "Results",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
