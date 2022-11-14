using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsSchedule.Infrastructure.Migrations
{
    public partial class addSportHallConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SportsHalls",
                columns: new[] { "HallId", "SportId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SportsHalls",
                keyColumns: new[] { "HallId", "SportId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SportsHalls",
                keyColumns: new[] { "HallId", "SportId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SportsHalls",
                keyColumns: new[] { "HallId", "SportId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SportsHalls",
                keyColumns: new[] { "HallId", "SportId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SportsHalls",
                keyColumns: new[] { "HallId", "SportId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "SportsHalls",
                keyColumns: new[] { "HallId", "SportId" },
                keyValues: new object[] { 3, 3 });
        }
    }
}
