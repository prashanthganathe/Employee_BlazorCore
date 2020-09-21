using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagmentAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartemntID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartemntName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartemntID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartemntID", "DepartemntName" },
                values: new object[,]
                {
                    { 1, "Dep1" },
                    { 2, "IT" },
                    { 3, "Security" },
                    { 4, "Sales" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "first@gmail.com", "firstname1", 0, "lastname1", "images/john.jpg" },
                    { 2, new DateTime(1980, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "first@gmail.com", "two", 0, "lastname1", "images/two.jpg" },
                    { 3, new DateTime(1980, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "first@gmail.com", "third", 0, "lastname1", "images/third.jpg" },
                    { 4, new DateTime(1980, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "first@gmail.com", "fourth", 0, "lastname1", "images/fourth.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
