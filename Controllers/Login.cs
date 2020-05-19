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
    public class LoginController : Controller
    {
        UserModel loggedInUser = null;
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
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
                //loggedInUser = found user;
                return RedirectToAction("");
            }
            return View(user);
        }

        public bool LoggedIn()
        {
            return loggedInUser == null;
        }

        public IActionResult Signup(){
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UserModel user)
        {
            if(ModelState.IsValid){
                user.Password = Encryption.HashPassword(user.Password);
                user.ConfirmPassword = user.Password;
                loggedInUser = user;
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