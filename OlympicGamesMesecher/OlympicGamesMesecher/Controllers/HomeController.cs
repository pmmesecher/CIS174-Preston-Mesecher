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

        public IActionResult Index(string activeGm = "all", string activeCtgy = "all")
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGm(activeGm);
            session.SetActiveCtgy(activeCtgy);

            var model = new CountryListViewModel
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
            model.Countries = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Game)
                    .Include(t => t.Category)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveGm = session.GetActiveGm(),
                ActiveCtgy = session.GetActiveCtgy()
            };
            return View(model);
        }


        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel data)
        {
            data.Country = context.Countries
                .Include(t => t.Game)
                .Include(t => t.Category)
                .Where(t => t.CountryID == data.Country.CountryID)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(data.Country);
            session.SetMyCountries(countries);

            TempData["message"] = $"{data.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveGm = session.GetActiveGm(),
                    ActiveCtgy = session.GetActiveCtgy()
                });
        }
    }
}