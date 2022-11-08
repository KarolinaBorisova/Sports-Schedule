using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsSchadule.Infrastucture.Migrations
{
    public partial class addedDbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingsUsers",
                table: "TrainingsUsers");

            migrationBuilder.DropIndex(
                name: "IX_TrainingsUsers_TrainingId",
                table: "TrainingsUsers");

            migrationBuilder.DropColumn(
                name: "TrainigId",
                table: "TrainingsUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingsUsers",
                table: "TrainingsUsers",
                columns: new[] { "TrainingId", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingsUsers",
                table: "TrainingsUsers");

            migrationBuilder.AddColumn<int>(
                name: "TrainigId",
                table: "TrainingsUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingsUsers",
                table: "TrainingsUsers",
                columns: new[] { "TrainigId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingsUsers_TrainingId",
                table: "TrainingsUsers",
                column: "TrainingId");
        }
    }
}
