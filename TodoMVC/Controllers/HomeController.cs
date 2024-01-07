using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoMVC.Models;

namespace TodoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["learnAbout"] = "Learn about";
            ViewData["homeBodyText"] = "building Web apps with ASP.NET Core.";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["privacyBodyText"] = "Use this page to detail your site's privacy policy.";
            return View();
        }

        public IActionResult About()
        {
            ViewData["aboutBodyText"] = "This is the About page.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
