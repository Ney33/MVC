using Banco_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Banco_MVC.Controllers
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

        public IActionResult Menu1()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult MenuCorriente()
        {
            return View();
        }

        public IActionResult MenuAhorros()
        {
            return View();
        }

        public IActionResult Movimientos()
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
