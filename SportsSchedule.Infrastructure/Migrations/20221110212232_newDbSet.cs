using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsSchedule.Infrastructure.Migrations
{
    public partial class newDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressHall_Halls_HallId",
                table: "AddressHall");

            migrationBuilder.DropForeignKey(
                name: "FK_Halls_AddressHall_AddressHallId",
                table: "Halls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressHall",
                table: "AddressHall");

            migrationBuilder.RenameTable(
                name: "AddressHall",
                newName: "AddressHalls");

            migrationBuilder.RenameIndex(
                name: "IX_AddressHall_HallId",
                table: "AddressHalls",
                newName: "IX_AddressHalls_HallId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressHalls",
                table: "AddressHalls",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressHalls_Halls_HallId",
                table: "AddressHalls",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_AddressHalls_AddressHallId",
                table: "Halls",
                column: "AddressHallId",
                principalTable: "AddressHalls",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressHalls_Halls_HallId",
                table: "AddressHalls");

            migrationBuilder.DropForeignKey(
                name: "FK_Halls_AddressHalls_AddressHallId",
                table: "Halls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressHalls",
                table: "AddressHalls");

            migrationBuilder.RenameTable(
                name: "AddressHalls",
                newName: "AddressHall");

            migrationBuilder.RenameIndex(
                name: "IX_AddressHalls_HallId",
                table: "AddressHall",
                newName: "IX_AddressHall_HallId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressHall",
                table: "AddressHall",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressHall_Halls_HallId",
                table: "AddressHall",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_AddressHall_AddressHallId",
                table: "Halls",
                column: "AddressHallId",
                principalTable: "AddressHall",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
