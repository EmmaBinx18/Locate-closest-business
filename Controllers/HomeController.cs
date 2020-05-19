using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;

namespace Locate_closest_business.Controllers
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

        [HttpPost]
        public IActionResult Search(string searchOption)
        {
            return RedirectToAction("");
        }

        public IActionResult RegisterBusiness()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterBusiness(BusinessModel business)
        {
            if(ModelState.IsValid){
                ViewBag.SuccessfulSubmit = true;
                return RedirectToAction("");
            }
            
            return View(business);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return RedirectToAction("");
        }
    }
}
