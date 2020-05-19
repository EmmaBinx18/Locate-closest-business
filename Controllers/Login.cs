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
    }
}