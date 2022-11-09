

using SportSchadule.Core.Models.Hall;

namespace SportSchadule.Core.Models.Sport
{
    public class AllSportsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public List<HallInfoViewModel> Halls { get; set; }

    }
}
