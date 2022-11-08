using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data
{
    public class Sport
    {
        public Sport()
        {
            SportsHalls = new List<SportsHalls>();
            Trainings = new List<Training>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; }

        public IdentityUser Coach { get; set; }

        public List<SportsHalls> SportsHalls { get; set; }

        public List<Training> Trainings { get; set; }

        public List<SportsUsers> SportUsers { get; set; }




    }
}
