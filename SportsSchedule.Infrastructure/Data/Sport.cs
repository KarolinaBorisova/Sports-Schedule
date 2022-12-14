using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


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

        public string Description { get; set; }

        public string? CoachId { get; set; }

        public IdentityUser Coach { get; set; }

        public List<SportsHalls> SportsHalls { get; set; }

        public List<Training> Trainings { get; set; }

        public List<SportsUsers> SportUsers { get; set; }




    }
}
