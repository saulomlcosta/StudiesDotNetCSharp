using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAngularApp.Data.Migrations
{
    public partial class Insertingdefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("8687ed78-4518-433b-8d96-1af3348fba5a"), "default.user@app.com", "Default User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8687ed78-4518-433b-8d96-1af3348fba5a"));
        }
    }
}
