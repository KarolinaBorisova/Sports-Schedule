
using SportSchadule.Core.Models.Hall;
using System.ComponentModel.DataAnnotations;

namespace SportSchadule.Core.Models.Sport
{
    public class SportAddViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Display(Name = "Hall")]
        public int HallId { get; set; }

        public IEnumerable<HallInfoViewModel> Halls { get; set; }
    }
}
