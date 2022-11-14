using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data.Configuration
{
    internal class SportsHallsConfiguration:IEntityTypeConfiguration<SportsHalls>
    {
        public void Configure(EntityTypeBuilder<SportsHalls> builder)
        {
            builder.HasData(CreateSportHall());
        }

        private List<SportsHalls> CreateSportHall()
        {
            var sportshalls= new List<SportsHalls>();

            var sportHall = new SportsHalls()
            {
              HallId =1,
              SportId =1,
            };

            sportshalls.Add(sportHall);

            sportHall = new SportsHalls()
            {
                HallId = 2,
                SportId = 1,
            };

            sportshalls.Add(sportHall);

            sportHall = new SportsHalls()
            {
                HallId = 2,
                SportId = 2,
            };

            sportshalls.Add(sportHall);

            sportHall = new SportsHalls()
            {
                HallId = 3,
                SportId = 2,
            };

            sportshalls.Add(sportHall);

            sportHall = new SportsHalls()
            {
                HallId = 1,
                SportId = 2,
            };

            sportshalls.Add(sportHall);

            sportHall = new SportsHalls()
            {
                HallId = 3,
                SportId = 3,
            };

            sportshalls.Add(sportHall);
            return sportshalls;
        }
    }
}
