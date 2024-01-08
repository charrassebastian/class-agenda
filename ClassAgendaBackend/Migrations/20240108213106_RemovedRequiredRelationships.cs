using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassAgendaBackend.Migrations
{
    /// <inheritdoc />
    public partial class RemovedRequiredRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnotationModel_MaterialModel_MaterialId",
                table: "AnnotationModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassModel_CourseModel_CourseId",
                table: "ClassModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassModel_StudentModel_StudentId",
                table: "ClassModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialModel_CourseModel_CourseId",
                table: "MaterialModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialModel_StudentModel_StudentId",
                table: "MaterialModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotoModel_MaterialModel_MaterialId",
                table: "PhotoModel");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaterialId",
                table: "PhotoModel",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "MaterialModel",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "MaterialModel",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "ClassModel",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "ClassModel",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaterialId",
                table: "AnnotationModel",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnotationModel_MaterialModel_MaterialId",
                table: "AnnotationModel",
                column: "MaterialId",
                principalTable: "MaterialModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassModel_CourseModel_CourseId",
                table: "ClassModel",
                column: "CourseId",
                principalTable: "CourseModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassModel_StudentModel_StudentId",
                table: "ClassModel",
                column: "StudentId",
                principalTable: "StudentModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialModel_CourseModel_CourseId",
                table: "MaterialModel",
                column: "CourseId",
                principalTable: "CourseModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialModel_StudentModel_StudentId",
                table: "MaterialModel",
                column: "StudentId",
                principalTable: "StudentModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoModel_MaterialModel_MaterialId",
                table: "PhotoModel",
                column: "MaterialId",
                principalTable: "MaterialModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnotationModel_MaterialModel_MaterialId",
                table: "AnnotationModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassModel_CourseModel_CourseId",
                table: "ClassModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassModel_StudentModel_StudentId",
                table: "ClassModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialModel_CourseModel_CourseId",
                table: "MaterialModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialModel_StudentModel_StudentId",
                table: "MaterialModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotoModel_MaterialModel_MaterialId",
                table: "PhotoModel");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaterialId",
                table: "PhotoModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "MaterialModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "MaterialModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "ClassModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "ClassModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MaterialId",
                table: "AnnotationModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AnnotationModel_MaterialModel_MaterialId",
                table: "AnnotationModel",
                column: "MaterialId",
                principalTable: "MaterialModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassModel_CourseModel_CourseId",
                table: "ClassModel",
                column: "CourseId",
                principalTable: "CourseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassModel_StudentModel_StudentId",
                table: "ClassModel",
                column: "StudentId",
                principalTable: "StudentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialModel_CourseModel_CourseId",
                table: "MaterialModel",
                column: "CourseId",
                principalTable: "CourseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialModel_StudentModel_StudentId",
                table: "MaterialModel",
                column: "StudentId",
                principalTable: "StudentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoModel_MaterialModel_MaterialId",
                table: "PhotoModel",
                column: "MaterialId",
                principalTable: "MaterialModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
