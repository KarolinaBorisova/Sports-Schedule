using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsSchedule.Infrastructure.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Address", "Capacity", "Name" },
                values: new object[,]
                {
                    { 1, "Sofia, bul.Bulgaria 1, 1421 NDK", 10, "NDK" },
                    { 2, "Sofia, ul. prof. Atanas Ishirkov, 1113", 10, "NSA" },
                    { 3, "Sofia, ul. Koloman 1, 1618", 10, "Slavia" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "CoachId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, null, "Ballet is an art form created by the movement of the human body. It is theatrical – performed on a stage to an audience utilizing costumes, scenic design and lighting. It can tell a story or express a thought, concept or emotion. Ballet dance can be magical, exciting, provoking or disturbing.", "https://imgs.classicfm.com/images/408219?width=3569&crop=4_3&signature=H6XmgyqpPpeY4OfHpqysk1ttwU8=", "Ballet" },
                    { 2, null, " 	Karate is a Japanese martial art whose physical aspects seek the development of defensive and counterattacking body movements.  The themes of traditional karate training are fighting and self-defense, though its mental and moral aspects target the overall improvement of the individual.  This is facilitated by the discipline and persistent effort required in training.   If karate had to be described in only one sentence, then the most suitable one may arguably be \"You never attack first in karate.\"", "https://i.imgur.com/9lMKyhU.jpg", "Karate" },
                    { 3, null, "Basketball is a team sport in which two teams, most commonly of five players each, opposing one another on a rectangular court, compete with the primary objective of shooting a basketball through the defender's hoop in diameter mounted 3.048 m high to a backboard at each end of the court, while preventing the opposing team from shooting through their own hoop.", "https://i.guim.co.uk/img/media/9a137bb107eb9df91aa6054a60d4ad8ce7783f60/0_55_4585_2752/master/4585.jpg?width=620&quality=45&dpr=2&s=none", "Basketball" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
