using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystem.Migrations
{
    public partial class One : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classses",
                columns: table => new
                {
                    ClasssId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClasssName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classses", x => x.ClasssId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Markks",
                columns: table => new
                {
                    MarkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HumanId = table.Column<int>(type: "int", nullable: false),
                    Emaill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markks", x => x.MarkID);
                });

            migrationBuilder.CreateTable(
                name: "Rolees",
                columns: table => new
                {
                    RoleeID = table.Column<byte>(type: "tinyint", nullable: false),
                    RoleeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rolees", x => x.RoleeID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    HumanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstandSecondName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Marks = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    ClasssId = table.Column<int>(type: "int", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.HumanId);
                    table.ForeignKey(
                        name: "FK_Students_Classses_ClasssId",
                        column: x => x.ClasssId,
                        principalTable: "Classses",
                        principalColumn: "ClasssId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    HumanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstandSecondName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    ClasssId = table.Column<int>(type: "int", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.HumanId);
                    table.ForeignKey(
                        name: "FK_Teachers_Classses_ClasssId",
                        column: x => x.ClasssId,
                        principalTable: "Classses",
                        principalColumn: "ClasssId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Userrs",
                columns: table => new
                {
                    UserrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emaill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Passwordd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleeID = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userrs", x => x.UserrID);
                    table.ForeignKey(
                        name: "FK_Userrs_Rolees_RoleeID",
                        column: x => x.RoleeID,
                        principalTable: "Rolees",
                        principalColumn: "RoleeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parentt",
                columns: table => new
                {
                    HumanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstandSecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentt", x => x.HumanId);
                    table.ForeignKey(
                        name: "FK_Parentt_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "HumanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classses",
                columns: new[] { "ClasssId", "ClasssName" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" },
                    { 5, "E" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Couldn't find" },
                    { 4, "Transsexual" },
                    { 5, "Intersex" },
                    { 6, "Non-Conforming" },
                    { 7, "Bigender" },
                    { 8, "Butch" },
                    { 9, "Cisgender" },
                    { 10, "Gender expansive" },
                    { 11, "Genderfluid" },
                    { 12, "Gender Outlaw" },
                    { 13, "Genderqueer" },
                    { 14, "Masculine of center" },
                    { 15, "Nonbinary" },
                    { 16, "Omnigender" },
                    { 17, "Polygender" },
                    { 18, "Two Spirit" },
                    { 19, "Agender" }
                });

            migrationBuilder.InsertData(
                table: "Rolees",
                columns: new[] { "RoleeID", "RoleeName" },
                values: new object[,]
                {
                    { (byte)1, "Candidate" },
                    { (byte)2, "Student" },
                    { (byte)3, "Teacher" },
                    { (byte)4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "HumanId", "Address", "ClasssId", "DOB", "Email", "FirstandSecondName", "GenderId", "JoinDate", "Lastname", "Marks", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 2, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 2, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 1, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 3, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 4, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 4, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 3, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 5, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 2, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 6, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 5, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 7, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 5, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 8, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 6, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 9, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 9, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 10, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 7, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 11, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 10, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 12, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 8, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" },
                    { 13, "Deneme sokağı 14", 1, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marysedenna@gmail.com", "Maryse Deanna", 5, new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoedemaeker", 0, "0543-432-12-45" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "HumanId", "Address", "ClasssId", "DOB", "Email", "FirstandSecondName", "GenderId", "JoinDate", "Lastname", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Some random stree 16", 1, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 1, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" },
                    { 2, "Some random stree 16", 2, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 2, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" },
                    { 3, "Some random stree 16", 3, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 1, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" },
                    { 4, "Some random stree 16", 4, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 2, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" },
                    { 5, "Some random stree 16", 2, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 1, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" },
                    { 6, "Some random stree 16", 2, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 2, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" },
                    { 7, "Some random stree 16", 5, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 1, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" },
                    { 8, "Some random stree 16", 5, new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilahunclock@gmail.com", "Leila Hun", 1, new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clock", "0543-234-12-45" }
                });

            migrationBuilder.InsertData(
                table: "Userrs",
                columns: new[] { "UserrID", "Emaill", "Passwordd", "RoleeID" },
                values: new object[,]
                {
                    { 1, "candidate@hotmail.com", "123456", (byte)1 },
                    { 2, "student@hotmail.com", "123456", (byte)2 },
                    { 3, "teacher@hotmail.com", "123456", (byte)3 },
                    { 4, "admin@hotmail.com", "123456", (byte)4 },
                    { 5, "user2@hotmail.com", "123456", (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "Parentt",
                columns: new[] { "HumanId", "Address", "DOB", "Email", "FirstandSecondName", "GenderId", "Lastname", "PhoneNumber", "StudentId" },
                values: new object[,]
                {
                    { 1, "Deneme sokağı 14", new DateTime(1964, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Luna", 1, "Deanna1", null, 1 },
                    { 2, "Deneme sokağı 14", new DateTime(1960, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Huna", 2, "Deanna2", null, 2 },
                    { 3, "Deneme sokağı 14", new DateTime(1964, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Beina", 2, "Deanna3", null, 3 },
                    { 4, "Deneme sokağı 14", new DateTime(1966, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Layna", 2, "Deanna4", null, 4 },
                    { 5, "Deneme sokağı 14", new DateTime(1968, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Abuen", 1, "Deanna5", null, 5 },
                    { 6, "Deneme sokağı 14", new DateTime(1970, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Linu", 1, "Deanna6", null, 6 },
                    { 7, "Deneme sokağı 14", new DateTime(1971, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Ohan", 2, "Deanna7", null, 7 },
                    { 8, "Deneme sokağı 14", new DateTime(1959, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Michele", 2, "Deanna8", null, 8 },
                    { 9, "Deneme sokağı 14", new DateTime(1957, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Larn", 1, "Deanna9", null, 9 },
                    { 10, "Deneme sokağı 14", new DateTime(1980, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Cubert", 1, "Deanna10", null, 10 },
                    { 11, "Deneme sokağı 14", new DateTime(1978, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Augna Ignis", 1, "Deanna11", null, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parentt_StudentId",
                table: "Parentt",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClasssId",
                table: "Students",
                column: "ClasssId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId",
                table: "Students",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClasssId",
                table: "Teachers",
                column: "ClasssId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_GenderId",
                table: "Teachers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Userrs_RoleeID",
                table: "Userrs",
                column: "RoleeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Markks");

            migrationBuilder.DropTable(
                name: "Parentt");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Userrs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Rolees");

            migrationBuilder.DropTable(
                name: "Classses");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
