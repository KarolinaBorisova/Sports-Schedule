using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string? Address { get; set; } 

        [Required]
        public int Capacity { get; set; }

        [ForeignKey(nameof(AddressHall))]
        public int? AddressHallId { get; set; }
       
        public AddressHall? AddressHall { get; set; }

        public List<SportsHalls> HallsSports { get; set; }

        public List<Training> Trainings { get; set; }
    }
}
