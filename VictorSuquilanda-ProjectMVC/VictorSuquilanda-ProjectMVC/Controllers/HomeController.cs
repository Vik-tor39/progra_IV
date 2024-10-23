using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VictorSuquilanda_Project1MVC.Models;

namespace VictorSuquilanda_Project1MVC.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Formulario()
        {
            return View();
        }
        public IActionResult Carrusel()
        {
            return View();
        }
        public IActionResult Suma()
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
