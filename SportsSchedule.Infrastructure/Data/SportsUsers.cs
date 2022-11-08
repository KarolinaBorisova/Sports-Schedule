using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data
{
    public class SportsUsers
    {
        public int SportId { get; set; }

        public Sport Sport { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
