using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class seedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerName", "EmailAddress" },
                values: new object[] { new Guid("0b2d3fd1-3242-4908-a2b8-b687705ffd02"), "William", "Shakespeare" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0b2d3fd1-3242-4908-a2b8-b687705ffd02"));
        }
    }
}
