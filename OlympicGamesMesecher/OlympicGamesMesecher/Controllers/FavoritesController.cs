using Microsoft.AspNetCore.Mvc;
using OlympicGamesMesecher.Models;

namespace OlympicGamesMesecher.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveGm = session.GetActiveGm(),
                ActiveCtgy = session.GetActiveCtgy(),
                Countries = session.GetMyCountries()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            session.RemoveMyCountries();

            TempData["message"] = "Favorite countries cleared";

            return RedirectToAction("Index", "Home",
                new {
                    ActiveGm = session.GetActiveGm(),
                    ActiveCtgy = session.GetActiveCtgy()
                });
        }
    }
}