using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Locate_closest_business.Models;

namespace Locate_closest_business.Controllers
{
    public class HomeController : Controller
    {
        UserModel loggedInUser = null;

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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (ModelState.GetValidationState("Email") == ModelValidationState.Valid
                && ModelState.GetFieldValidationState("Password") == ModelValidationState.Valid){
                //On succesful validation:
                //loggedInUser = user;
                return RedirectToAction("");
            }
            return View(user);
        }

        public bool LoggedIn()
        {
            // return Json(loggedInUser == null, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            return loggedInUser == null;
        }

        public IActionResult Signup(){
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UserModel user)
        {
            if(ModelState.IsValid){
                // Need to hash password
                // loggedInUser = user found
                return RedirectToAction("");
            }
            return View(user);
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
