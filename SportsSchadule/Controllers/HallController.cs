using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportSchadule.Core.Contracts;
using SportSchadule.Core.Models.Hall;
using SportSchadule.Core.Models.Sport;

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

        [AllowAnonymous]
        public async Task<IActionResult> Add()
        {
            var model = new HallAddViewModel();
            
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(HallAddViewModel model)
        {
            if (!ModelState.IsValid)
            { 
                return View(model);
            }
       
            int id = await hallService.Create(model);
       
            return RedirectToAction(nameof(Info),new { id});
        }

    }
}
