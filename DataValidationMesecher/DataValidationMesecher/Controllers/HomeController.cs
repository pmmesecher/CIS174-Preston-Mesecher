using FirstResponsiveWebAppMesecher.Models;
using Microsoft.AspNetCore.Mvc;


public class HomeController : Controller
{
    public const int DaysInAYear = 364;
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Name = "";
        ViewBag.Age = "";
        return View();
    }
    [HttpPost]
    public IActionResult Index(FirstResponsiveWebAppModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Name = model.Name;
            ViewBag.Age = "Age: " + model.CalculateAge(DaysInAYear);
        }
        else
        {
            ViewBag.Name = "";
            ViewBag.Age = "";
        }
        return View(model);
    }
}
