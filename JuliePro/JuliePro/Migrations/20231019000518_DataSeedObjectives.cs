using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class DataSeedObjectives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 18, 20, 5, 18, 709, DateTimeKind.Local).AddTicks(3398), 1, 30.0, 5.0, "Cardio" },
                    { 2, null, 1, 35.0, 3.0, "Force" },
                    { 3, null, 2, 40.0, 4.0, "Natation" },
                    { 4, null, 2, 45.0, 6.0, "Performance" },
                    { 5, new DateTime(2023, 7, 18, 20, 5, 18, 709, DateTimeKind.Local).AddTicks(3432), 3, 45.0, 8.0, "Maigrir" },
                    { 6, new DateTime(2023, 8, 18, 20, 5, 18, 709, DateTimeKind.Local).AddTicks(3434), 3, 20.0, 7.0, "Tonus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
