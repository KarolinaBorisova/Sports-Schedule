using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data.Configuration
{
    internal class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
      
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasData(CreateHall());
        }

        private List<Hall> CreateHall()
        {
            var halls = new List<Hall>();

            var hall = new Hall()
            {
                Id = 1,
                Name = "NDK",
                Address = "Sofia, bul.Bulgaria 1, 1421 NDK",
                Capacity = 10 
            };

            halls.Add(hall);

             hall = new Hall()
            {
                Id = 2,
                Name = "NSA",
                Address = "Sofia, ul. prof. Atanas Ishirkov, 1113",
                Capacity = 10
            };

            halls.Add(hall);

            hall = new Hall()
            {
                Id = 3,
                Name = "Slavia",
                Address = "Sofia, ul. Koloman 1, 1618",
                Capacity = 10
            };

            halls.Add(hall);

            return halls;
        }
    }
}
