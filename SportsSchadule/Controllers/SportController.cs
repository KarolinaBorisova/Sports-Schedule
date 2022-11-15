using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportSchadule.Core.Contracts;
using SportSchadule.Core.Models.Sport;
using SportSchadule.Core.Services;

namespace SportsSchadule.Controllers
{

    [Authorize]
    public class SportController : Controller
    {
        private readonly ISportService sportService;
        private readonly IHallService hallService;

        public SportController(ISportService _sportService,
            IHallService _hallService)
        {
            this.sportService = _sportService;
            this.hallService = _hallService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await sportService.AllSportsInfo();
            return View(model);
        }


        public async Task<IActionResult> Mine()
        {
            var model = new SportViewModel();

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Info(int id)
        {
            var model = new SportInfoViewModel();
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Add()
        {
            var model = new SportAddViewModel()
            { 
                Halls = await hallService.AllHalls()
            };
            return View(model);
        }

      //  [HttpPost]
      //  public async Task<IActionResult> Add(AllSportsViewModel model)
      //  {
      //      if (!ModelState.IsValid)
      //      { 
      //          return View(model);
      //      }
      //
      //      int id = await sportService.Create(model);
      //
      //      return RedirectToAction(nameof(Info),new { id});
      //  }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new SportAddViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, SportAddViewModel model)
        {
            
            return RedirectToAction(nameof(Info), new { id });
        }

   
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            return RedirectToAction(nameof(All), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(int id)
        {
            return RedirectToAction(nameof(Mine), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> SignOut(int id)
        {
            return RedirectToAction(nameof(Mine), new { id });
        }


    }
}
