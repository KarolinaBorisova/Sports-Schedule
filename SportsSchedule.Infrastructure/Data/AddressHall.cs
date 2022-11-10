using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data
{
    public class AddressHall
    {
        [Key]
        public int Id { get; set; }

        public string Country { get; set; }

        public string StreetAddress { get; set; }

        public string PostCode { get; set; }

        [ForeignKey(nameof(Hall))]
        public int? HallId { get; set; }

        public Hall? Hall { get; set; }
    }
}
