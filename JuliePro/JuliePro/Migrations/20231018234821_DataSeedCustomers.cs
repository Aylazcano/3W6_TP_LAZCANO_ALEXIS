using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class DataSeedCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "valtur@goodmail.com", "Valérie", "Turgeon", 0.0, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alelaz@goodmail.com", "Alexis", "Lazcano", 0.0, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EmiSil@goodmail.com", "Emilia", "Silva", 0.0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
