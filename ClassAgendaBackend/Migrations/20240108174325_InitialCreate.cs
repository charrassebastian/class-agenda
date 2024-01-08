using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassAgendaBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluationType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preferred_platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassModel_CourseModel_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassModel_StudentModel_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Teacher = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialModel_CourseModel_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialModel_StudentModel_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnotationModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnotationModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnotationModel_MaterialModel_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "MaterialModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotoModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoModel_MaterialModel_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "MaterialModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnnotationModel_MaterialId",
                table: "AnnotationModel",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassModel_CourseId",
                table: "ClassModel",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassModel_StudentId",
                table: "ClassModel",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialModel_CourseId",
                table: "MaterialModel",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialModel_StudentId",
                table: "MaterialModel",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoModel_MaterialId",
                table: "PhotoModel",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnotationModel");

            migrationBuilder.DropTable(
                name: "ClassModel");

            migrationBuilder.DropTable(
                name: "PhotoModel");

            migrationBuilder.DropTable(
                name: "MaterialModel");

            migrationBuilder.DropTable(
                name: "CourseModel");

            migrationBuilder.DropTable(
                name: "StudentModel");
        }
    }
}
