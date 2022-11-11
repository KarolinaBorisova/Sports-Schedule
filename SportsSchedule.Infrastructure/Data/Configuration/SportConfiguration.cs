using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data.Configuration
{
    public class SportConfiguration : IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> builder)
        {
            builder.HasData(CreateSports());
        }

        private List<Sport> CreateSports()
        {
            var sports = new List<Sport>();

            var sport = new Sport()
            {
                Id = 1,
                Name = "Ballet",
                Description = "Ballet is an art form created by the movement of the human body." +
                " It is theatrical – performed on a stage to an audience utilizing costumes, scenic design and lighting. It can tell a story or express a thought, concept or emotion. Ballet dance can be magical, exciting, provoking or disturbing.",
                ImageUrl = "https://imgs.classicfm.com/images/408219?width=3569&crop=4_3&signature=H6XmgyqpPpeY4OfHpqysk1ttwU8=",
              
            };
            sports.Add(sport);

            sport = new Sport()
            {
                Id = 2,
                Name = "Karate",
                Description = " \tKarate is a Japanese martial art whose physical aspects seek" +
                " the development of defensive and counterattacking body movements. " +
                " The themes of traditional karate training are fighting and self-defense, " +
                "though its mental and moral aspects target the overall improvement of the individual. " +
                " This is facilitated by the discipline and persistent effort required in training.  " +
                " If karate had to be described in only one sentence, then the most suitable one may arguably be " +
                "\"You never attack first in karate.\"",
                ImageUrl = "https://i.imgur.com/9lMKyhU.jpg"
            };

            sports.Add(sport);

            sport = new Sport()
            {
                Id = 3,
                Name = "Basketball",
                Description = "Basketball is a team sport in which two teams, most commonly of five players each, " +
                "opposing one another on a rectangular court, compete with the primary objective of shooting a basketball" +
                " through the defender's hoop in diameter mounted 3.048 m high to a backboard at each end of the court," +
                " while preventing the opposing team from shooting through their own hoop.",    
                ImageUrl = "https://i.guim.co.uk/img/media/9a137bb107eb9df91aa6054a60d4ad8ce7783f60/0_55_4585_2752/master/4585.jpg?width=620&quality=45&dpr=2&s=none",

            };

            sports.Add(sport);

            return sports;
        }
    }
}
