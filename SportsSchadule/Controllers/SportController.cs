using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportSchadule.Core.Models.Sport;

namespace SportsSchadule.Controllers
{

    [Authorize]
    public class SportController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = new SportViewModel();

            return  View(model);
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

       
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(SportAddViewModel model)
        {
            int id = 1;
            if (!ModelState.IsValid)
            { 
            }
            return RedirectToAction(nameof(Info),new { id});
        }

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
