using Microsoft.AspNetCore.Mvc;
using SportSchadule.Core.Contracts;
using SportsSchadule.Models;
using System.Diagnostics;

namespace SportsSchadule.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISportService sportService;

        public HomeController(ISportService _sportService)
        {
            this.sportService = _sportService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await sportService.AllSports();
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}