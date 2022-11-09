using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchadule.Core.Models.Hall
{
    public class HallInfoViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Capacity { get; set; }

        public int PlacesLeft { get; set; }
    }
}
