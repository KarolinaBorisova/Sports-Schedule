using Microsoft.AspNetCore.Mvc;
using SportSchadule.Core.Contracts;
using SportSchadule.Core.Models.Hall;

namespace SportsSchadule.Controllers
{
    public class HallController : Controller
    {

        private readonly IHallService hallService;

        public HallController(IHallService _hallService)
        {
            this.hallService = _hallService;
        }


        public async Task< IActionResult> Info(int id)
        {
            var model = await this.hallService.GetHallById(id);
            
            return View(model);
        }
    }
}
