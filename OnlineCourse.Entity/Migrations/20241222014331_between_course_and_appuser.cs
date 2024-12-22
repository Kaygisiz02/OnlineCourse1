﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCourse.Entity.Migrations
{
    /// <inheritdoc />
    public partial class between_course_and_appuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Courses",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                newName: "IX_Courses_AppUserId");

            migrationBuilder.CreateTable(
                name: "CourseRegister",
                columns: table => new
                {
                    CourseRegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRegister", x => x.CourseRegisterId);
                    table.ForeignKey(
                        name: "FK_CourseRegister_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRegister_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegister_AppUserId",
                table: "CourseRegister",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegister_CourseId",
                table: "CourseRegister",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_AppUserId",
                table: "Courses",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_AppUserId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CourseRegister");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Courses",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_AppUserId",
                table: "Courses",
                newName: "IX_Courses_CategoryId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsShown = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }
    }
}
