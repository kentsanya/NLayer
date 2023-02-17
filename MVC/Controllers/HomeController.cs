using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;
using BL.IoC;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUOW _context;

        public HomeController(ILogger<HomeController> logger, IUOW context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var context = _context.GetContextBL();
            
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