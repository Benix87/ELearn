using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearn.DataLayer.Migrations
{
    public partial class UpdateCourseGroupAddIsDeletedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_CoursesGroup_CourseGroupId",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoursesGroup",
                table: "CoursesGroup");

            migrationBuilder.RenameTable(
                name: "CoursesGroup",
                newName: "CourseGroups");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CourseGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseGroups",
                table: "CourseGroups",
                column: "CourseGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CourseGroups_CourseGroupId",
                table: "Course",
                column: "CourseGroupId",
                principalTable: "CourseGroups",
                principalColumn: "CourseGroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseGroups_CourseGroupId",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseGroups",
                table: "CourseGroups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CourseGroups");

            migrationBuilder.RenameTable(
                name: "CourseGroups",
                newName: "CoursesGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoursesGroup",
                table: "CoursesGroup",
                column: "CourseGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CoursesGroup_CourseGroupId",
                table: "Course",
                column: "CourseGroupId",
                principalTable: "CoursesGroup",
                principalColumn: "CourseGroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
