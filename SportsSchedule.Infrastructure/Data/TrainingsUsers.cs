using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedule.Infrastructure.Data
{
    public class TrainingsUsers
    {
        public int TrainingId { get; set; }

        public Training Training { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
