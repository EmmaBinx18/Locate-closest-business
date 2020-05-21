using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;

namespace Locate_closest_business.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Admin()
        {
            UserManagementModel model = new UserManagementModel();
            model.AdminUsers = new List<UserModel>(); //TODO: added admins to list
            return View(model);
        }

        [HttpPost]
        public IActionResult AddAdmin(UserModel user){
            if(ModelState.IsValid){
                return RedirectToAction("");
            }
            return View(user);
        }

        public IActionResult RegisteredBusiness()
        {
            return View();
        }

        public IActionResult Profile()
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