using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class DataSeedTrainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Photo", "SpecialityId" },
                values: new object[,]
                {
                    { 1, "Frank.StJohn@juliepro.ca", "François", "Saint-John", "Francois.png", 1 },
                    { 2, "JC.Bastien@juliepro.ca", "Jean-Claude", "Bastien", "JeanClaude.png", 4 },
                    { 3, "Karine.Lachance@juliepro.ca", "Karine", "Lachance", "Karine.png", 2 },
                    { 4, "Ramone.Esteban@juliepro.ca", "Ramone", "Esteban", "Ramone.png", 3 }
                });
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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
