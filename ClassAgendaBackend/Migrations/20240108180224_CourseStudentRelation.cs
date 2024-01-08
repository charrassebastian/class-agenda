using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassAgendaBackend.Migrations
{
    /// <inheritdoc />
    public partial class CourseStudentRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseModelStudentModel",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModelStudentModel", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseModelStudentModel_CourseModel_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "CourseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseModelStudentModel_StudentModel_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "StudentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseModelStudentModel_StudentsId",
                table: "CourseModelStudentModel",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseModelStudentModel");
        }
    }
}
