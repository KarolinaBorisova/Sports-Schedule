using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data
{
    public class SportsHalls
    {
        [Key]
        [Required]
        public int SportId { get; set; }

        [ForeignKey(nameof(SportId))]
        public Sport Sport { get; set; } = null!;

        [Key]
        [Required]
        public int HallId { get; set; }

        [ForeignKey(nameof(HallId))]
        public Hall Hall { get; set; } = null!;

    }
}
