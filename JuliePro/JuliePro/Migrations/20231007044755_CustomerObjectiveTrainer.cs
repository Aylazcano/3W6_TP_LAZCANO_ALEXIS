using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class CustomerObjectiveTrainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 1,
                column: "AchievedDate",
                value: new DateTime(2023, 4, 7, 0, 47, 55, 663, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5,
                column: "AchievedDate",
                value: new DateTime(2023, 7, 7, 0, 47, 55, 663, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6,
                column: "AchievedDate",
                value: new DateTime(2023, 8, 7, 0, 47, 55, 663, DateTimeKind.Local).AddTicks(8366));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 1,
                column: "AchievedDate",
                value: new DateTime(2023, 4, 7, 0, 47, 8, 794, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5,
                column: "AchievedDate",
                value: new DateTime(2023, 7, 7, 0, 47, 8, 794, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6,
                column: "AchievedDate",
                value: new DateTime(2023, 8, 7, 0, 47, 8, 794, DateTimeKind.Local).AddTicks(5006));
        }
    }
}
