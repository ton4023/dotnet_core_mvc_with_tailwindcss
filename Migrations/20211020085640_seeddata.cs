using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webmvc.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CustomerEntity",
                columns: new[] { "ID", "Code", "CreateDate", "Email", "LastUpdateDate", "NameEN", "NameTH", "Phone" },
                values: new object[] { 1, "C1", new DateTime(2021, 10, 20, 15, 56, 40, 111, DateTimeKind.Local).AddTicks(5860), "test1@gmail.com", new DateTime(2021, 10, 20, 15, 56, 40, 115, DateTimeKind.Local).AddTicks(7839), "Test1", "ทดสอบ1", "9999999999" });

            migrationBuilder.InsertData(
                table: "CustomerEntity",
                columns: new[] { "ID", "Code", "CreateDate", "Email", "LastUpdateDate", "NameEN", "NameTH", "Phone" },
                values: new object[] { 2, "C2", new DateTime(2021, 10, 20, 15, 56, 40, 115, DateTimeKind.Local).AddTicks(8338), "test2@gmail.com", new DateTime(2021, 10, 20, 15, 56, 40, 115, DateTimeKind.Local).AddTicks(8344), "Test2", "ทดสอบ2", "9999999999" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerEntity",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerEntity",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
