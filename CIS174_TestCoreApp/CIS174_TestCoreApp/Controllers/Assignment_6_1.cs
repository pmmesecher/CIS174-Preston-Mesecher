using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment_6_1 : Controller
    {
        private readonly ILogger<Assignment_6_1> _logger;

        public Assignment_6_1(ILogger<Assignment_6_1> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}