using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFcoreProject.Migrations
{
    /// <inheritdoc />
    public partial class seedingMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "ManagerId", "Name" },
                values: new object[,]
                {
                    { 3, "Building C", null, "Physics" },
                    { 4, "Building D", null, "Chemistry" },
                    { 5, "Building E", null, "Biology" },
                    { 6, "Building F", null, "English" },
                    { 7, "Building G", null, "History" },
                    { 8, "Building H", null, "Economics" },
                    { 9, "Building I", null, "Art" },
                    { 10, "Building J", null, "Music" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: null);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 3, null, "Ali", "Hassan", "01187654321" },
                    { 4, null, "Mariam", "Saeed", "01010101010" },
                    { 5, null, "Hassan", "Kamal", "01120202020" },
                    { 6, null, "Nora", "Fadel", "01230303030" },
                    { 7, null, "Yara", "Adel", "01040404040" },
                    { 8, null, "Karim", "Ibraheem", "01150505050" },
                    { 9, null, "Dalia", "Mostafa", "01260606060" },
                    { 10, null, "Mostafa", "Nagy", "01070707070" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "DepartmentId", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 3, 3, "Khaled", "Ibrahim", "01212345678" },
                    { 4, 4, "Lina", "Youssef", "01098765432" },
                    { 5, 5, "Youssef", "Saeed", "01155556666" },
                    { 6, 6, "Dina", "Farid", "01233334444" },
                    { 7, 7, "Ola", "Mahmoud", "01022223333" },
                    { 8, 8, "Samir", "Nabil", "01111112222" },
                    { 9, 9, "Rana", "Fahmy", "01244445555" },
                    { 10, 10, "Tamer", "Sami", "01066667777" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "DepartmentId", "Duration", "InstructorId", "Name" },
                values: new object[,]
                {
                    { 3, 3, 35, 3, "Physics 1" },
                    { 4, 4, 45, 4, "Organic Chemistry" },
                    { 5, 5, 32, 5, "Cell Biology" },
                    { 6, 6, 28, 6, "English Literature" },
                    { 7, 7, 30, 7, "Modern History" },
                    { 8, 8, 36, 8, "Microeconomics" },
                    { 9, 9, 20, 9, "Drawing" },
                    { 10, 10, 22, 10, "Music Theory" }
                });

            migrationBuilder.InsertData(
                table: "CourseSessions",
                columns: new[] { "Id", "CourseId", "Date", "InstructorId", "Title" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mechanics" },
                    { 4, 4, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Hydrocarbons" },
                    { 5, 5, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Cell Structure" },
                    { 6, 6, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Shakespeare Overview" },
                    { 7, 7, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "WW2 Events" },
                    { 8, 8, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Supply & Demand" },
                    { 9, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Figure Drawing" },
                    { 10, 10, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Harmony Basics" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "CourseSessionAttendances",
                columns: new[] { "Id", "CourseSessionId", "Grade", "Notes", "StudentId" },
                values: new object[,]
                {
                    { 3, 3, 95, "Excellent", 3 },
                    { 4, 4, 88, "Well Done", 4 },
                    { 5, 5, 76, "Satisfactory", 5 },
                    { 6, 6, 82, "Good", 6 },
                    { 7, 7, 79, "Needs Improvement", 7 },
                    { 8, 8, 91, "Very Good", 8 },
                    { 9, 9, 87, "Good", 9 },
                    { 10, 10, 93, "Excellent", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }
    }
}
