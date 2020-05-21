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
            model.NewAdmin = new UserModel();
            model.AdminUsers = new List<UserModel>(); //TODO: populate list with admin users

            UserModel user = new UserModel();
            user.FirstName = "Emma";
            user.LastName = "Coetzer";
            user.Email = "emmac@bbd.co.za";
            user.Phone = "0718831926";
             
            model.AdminUsers.Add(user);
            model.AdminUsers.Add(user);
            model.AdminUsers.Add(user);
            model.AdminUsers.Add(user);
            model.AdminUsers.Add(user);
            model.AdminUsers.Add(user);
            
            return View(model);
        }

        [HttpPost]
        public IActionResult RemoveAdmin(string email)
        {
            //TODO: remove user
            return RedirectToAction("Admin");
        }

        public IActionResult RegisterBusiness()
        {
            return View(new BusinessModel());
        }

        [HttpPost]
        public IActionResult RegisterBusiness(UserModel user){
            if(ModelState.IsValid){
                return RedirectToAction("");
            }
            return View(user);
        }

        public IActionResult RegistrationRequests()
        {
            List<BusinessModel> model = new List<BusinessModel>();
            //TODO: populate list with business registration requests
            // BusinessModel business = new BusinessModel();
            // business.MemberIds = "";
            // business.CompanyName = "New Company";
            // business.RegistrationNumber = "1234567890";
            // business.Category = "Food Delivery";
            // business.NumEmployees = "24";
            // business.Address = "12 Apple Str, Randpark Ridge, Randburg, 2156";

            // model.Add(business);
            // model.Add(business);
            // model.Add(business);
            // model.Add(business);
            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmRegistration(string registrationNumber)
        {
            //TODO: add business
            return RedirectToAction("RegistrationRequests");
        }

        [HttpPost]
        public IActionResult DenyRegistration(string registrationNumber)
        {
            //TODO: remove business registration request
            return RedirectToAction("RegistrationRequests");
        }

        public IActionResult Profile()
        {
            return View(); //TODO: return logged in user details
        }

        [HttpPost]
        public IActionResult Profile(UserModel user)
        {
            if(ModelState.IsValid){
                return RedirectToAction("");
            }
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}