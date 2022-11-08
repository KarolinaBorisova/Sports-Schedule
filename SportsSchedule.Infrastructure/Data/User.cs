using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public int Phone { get; set; }

        public List<SportsUsers> UserSports { get; set; }

        public List<TrainingsUsers> UserTrainings { get; set; }
    }
}
