using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data
{
    public class Hall
    {
        public Hall()
        {
            HallsSports = new List<SportsHalls>();
            Trainings = new List<Training>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        public List<SportsHalls> HallsSports { get; set; }

        public List<Training> Trainings { get; set; }
    }
}
