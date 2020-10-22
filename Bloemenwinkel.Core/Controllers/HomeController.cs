using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Architecture_3IMD.Models.Domain;



namespace Architecture_3IMD.Controllers
{
    //[Route("/api/[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Content("Home");
        }

        [HttpGet]
        public IActionResult getAllStores()
        {
            return Content("These are all the stores");
        }

        [HttpGet("{id}")]
        public IActionResult getStore([FromBody] int id)
        {
            return Content("This is store" + id);
        }

        [HttpPost]
        public async Task<IActionResult> postTest([FromBody] Stores model)
        {
            if(model == null){
                return StatusCode(400);
            }
            
            return StatusCode(200);
            
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}

