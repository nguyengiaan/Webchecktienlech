using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Webchecktienlech.Models;

namespace Webchecktienlech.Controllers
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
            return View();
        }
        [Route("/So-sanh-ho-so")]
        public IActionResult Sosanhhoso()
        {
            return View();
        }
        [Route("/So-sanh-tien")]
        public IActionResult Sosanhtien()
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
