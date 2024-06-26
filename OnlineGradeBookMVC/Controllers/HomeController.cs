using Microsoft.AspNetCore.Mvc;
using OnlineGradeBookMVC.Models;
using System.Diagnostics;

namespace OnlineGradeBookMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ClassSplit()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Class1Split()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Class2Split()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Class3Split()
        {
            return View();
        }
        public IActionResult Privacy()
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
