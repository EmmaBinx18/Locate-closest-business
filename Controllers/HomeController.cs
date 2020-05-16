using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;

namespace Locate_closest_business.Controllers
{
    public class HomeController : Controller
    {
        string[] essentialServiceOptions = {
            "Agriculture, hunting, forestry, fishing",
            "Electricity, Gas, Water supply",
            "Manufacturing",
            "Construction and related services",
            "Wholesale, Retail trade, Spaza shops",
            "Information and Communication services",
            "Media and Entertainment",
            "Financial and Business services",
            "Accommodation for quarantine, essential services",
            "Food services (Deliveries)",
            "Transport, Storage, Communication services",
            "Mining and Quarrying",
            "Repair and Related Emergency services",
            "Supply Chain",
            "Health, Social and Personal services"
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            return View(essentialServiceOptions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
