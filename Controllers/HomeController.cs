using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Architecture_3IMD.Models;
using Architecture_3IMD.Models.Stores;
using Architecture_3IMD.Models.Bouquets;

namespace Architecture_3IMD.Controllers
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

        [HttpGet]
        public IActionResult getAllStores()
        {
            _logger.LogInformation("Getting all Stores");
            // This is a linq extension method: https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=netcore-3.1
            var stores = Stores.Select(x => new StoreWebOutput(x.Name, x.Adress, x.Region)).ToArray();
            return Ok(stores);
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
