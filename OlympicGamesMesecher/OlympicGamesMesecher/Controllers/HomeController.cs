using System.Collections.Generic;
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

        public IActionResult Index(CountryListViewModel model)
        {
            model.Games = context.Games.ToList();
            model.Categories = context.Categories.ToList();

            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGm(model.ActiveGm);
            session.SetActiveCtgy(model.ActiveCtgy);

            int? count = session.GetMyCountryCount();
            if (count == null)
            {
                var cookies = new OlympicCookies(HttpContext.Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                    mycountries = context.Countries.Include(t => t.Game)
                        .Include(t => t.Category)
                        .Where(t => ids.Contains(t.CountryID)).ToList();
                session.SetMyCountries(mycountries);
            }

            IQueryable<Country> query = context.Countries;
            if (model.ActiveGm != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == model.ActiveGm.ToLower());
            if (model.ActiveCtgy != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == model.ActiveCtgy.ToLower());
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

            var cookies = new OlympicCookies(HttpContext.Response.Cookies);
            cookies.SetMyCountryIds(countries);


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