using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TacocatMVC.Models;

namespace TacocatMVC.Controllers
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

        public IActionResult Solve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solve(string tacocat)
        {
            if (string.IsNullOrWhiteSpace(tacocat))
            {
                return View();
            }
            var tacocatArray = tacocat.ToCharArray();
            var output = new StringBuilder();
            for(int i = tacocat.Length; i > 0; i--)
            {
                output.Append(tacocatArray[i - 1]);
            }
            ViewData["Output"] = output;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
