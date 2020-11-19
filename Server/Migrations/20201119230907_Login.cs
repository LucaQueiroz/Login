using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blazormysql2.Server.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1002);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AcceptTerms", "ConfirmPassword", "DateOfBirth", "Email", "FirstName", "LastName", "MiddleName", "Password", "Title" },
                values: new object[] { 1, true, "123456", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "sobrazinhoOchave@gmail.com", "Luis", "Sobral", "Guilherme", "123456", "Sr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AcceptTerms", "ConfirmPassword", "DateOfBirth", "Email", "FirstName", "LastName", "MiddleName", "Password", "Title" },
                values: new object[] { 1002, true, "123456", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "sobrazinhoOchave@gmail.com", "Luis", "Sobral", "Guilherme", "123456", "Sr" });
        }
    }
}
