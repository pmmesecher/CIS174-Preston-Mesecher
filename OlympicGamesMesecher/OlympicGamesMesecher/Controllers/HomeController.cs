using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlympicGamesMesecher.Models;

namespace OlympicGamesMesecher.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string activeGm = "all",
                                   string activeCtgy = "all")
        {
            var data = new CountryListViewModel
            {
                ActiveGm = activeGm,
                ActiveCtgy = activeCtgy,
                Games = context.Games.ToList(),
                Categories = context.Categories.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if (activeGm != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == activeGm.ToLower());
            if (activeCtgy != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCtgy.ToLower());
            data.Countries = query.ToList();

            return View(data);
        }

        [HttpPost]
        public IActionResult Details(CountryViewModel model)
        {
            Utility.LogCountryClick(model.Country.CountryID);

            TempData["ActiveGm"] = model.ActiveGm;
            TempData["ActiveCtgy"] = model.ActiveCtgy;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Game)
                    .Include(t => t.Category)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveCtgy = TempData?["ActiveCtgy"]?.ToString() ?? "all",
                ActiveGm = TempData?["ActiveGm"]?.ToString() ?? "all"
            };
            return View(model);
        }
    }
}