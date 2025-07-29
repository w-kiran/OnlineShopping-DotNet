using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq; // For LINQ methods like OrderByDescending, Take, ToList
using System.Collections.Generic; // For List<Product>
using OnlineShopping.Models; // Assuming your Product model is here

using OnlineShopping.Data; // <--- ADD THIS LINE!

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OnlineShoppingContext _context;

        public HomeController(ILogger<HomeController> logger, OnlineShoppingContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var featuredProducts = _context.Product
                                           .OrderByDescending(p => p.Id)
                                           .Take(3)
                                           .ToList();

            return View(featuredProducts);
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