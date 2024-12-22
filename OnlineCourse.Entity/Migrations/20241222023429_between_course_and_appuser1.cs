using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCourse.Entity.Migrations
{
    /// <inheritdoc />
    public partial class between_course_and_appuser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "CourseRegister");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "CourseRegister",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
