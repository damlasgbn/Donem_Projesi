using Microsoft.AspNetCore.Mvc;
using PatlamısMısır.com.Models;
using System.Diagnostics;

namespace PatlamısMısır.com.Controllers
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

        public IActionResult Katagoriler()
        {
            return View();
        }
        
       

        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult UyeOlma()
        {
            return View();
        }

        public IActionResult KorkuFilmi()
        {
            return View();
        }

        public IActionResult AksiyonFilmi()
        {
            return View();
        }

        public IActionResult AskFilmi()
        {
            return View();
        }

        public IActionResult BilimFilmi()
        {
            return View();
        }

        public IActionResult KomediFilmi()
        {
            return View();
        }

        public IActionResult CocukFilmi()
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
