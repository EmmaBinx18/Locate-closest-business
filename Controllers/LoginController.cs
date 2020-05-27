using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Locate_closest_business.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace Locate_closest_business.Controllers
{
    public class LoginController : Controller
    {
        static HttpClient client = new HttpClient();
        UserModel loggedInUser = null;
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {  
            return View(new UserModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserModel user)
        {
            if (ModelState.GetValidationState("Email") == ModelValidationState.Valid
                && ModelState.GetFieldValidationState("Password") == ModelValidationState.Valid){
                UserLoginDetails details = new UserLoginDetails(user);    
                HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=AIzaSyBH0hd7PJ8tFZ1aK18OypZV_Ki6kWDpqGQ",
                 details);
                 try {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsAsync<SuccessResponse>();
                    // Console.WriteLine(responseBody.localId);
                    user.UserId = responseBody.localId;
                    TempData["userId"] = user.UserId;
                    loggedInUser = user;
                    //  return RedirectToAction("Admin", "Admin"); to go to Admin console
                     return RedirectToAction("Index", "Home");
                }
                catch(HttpRequestException e)
                {
                    // Console.WriteLine("\nException Caught!");	
                    // Console.WriteLine("Message :{0} ",e.Message);
                    return RedirectToAction("Index", "Home");
                }
                //On succesful validation:
                //loggedInUser = found user;
                //If user is an admin -> redirect to admin return RedirectToAction("Admin/Admin");
                
            } else {
               return RedirectToAction("Index", "Home");
            }
            
        }

        public bool LoggedIn()
        {
           return loggedInUser == null;
        }

        public void Logout(){
            loggedInUser = null;
        }

        public IActionResult Signup()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public async Task<IActionResult> Signup(UserModel user)
        {
            if(ModelState.IsValid){
                user.Password = EncryptionModel.HashPassword(user.Password);
                user.ConfirmPassword = user.Password;
    UserLoginDetails details = new UserLoginDetails(user);    
                HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=AIzaSyBH0hd7PJ8tFZ1aK18OypZV_Ki6kWDpqGQ",
                 details);
                 try {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsAsync<SuccessResponse>();
                    // Console.WriteLine(responseBody.localId);
                    user.UserId = responseBody.localId;
                    TempData["userId"] = user.UserId;
                    loggedInUser = user;
                    //  return RedirectToAction("Admin", "Admin"); to go to Admin console
                     return RedirectToAction("Index", "Home");
                }
                catch(HttpRequestException e)
                {
                    // Console.WriteLine("\nException Caught!");	
                    // Console.WriteLine("Message :{0} ",e.Message);
                    return RedirectToAction("Index", "Home");
                }
            } else {
               return RedirectToAction("Index", "Home");
            }
        }  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }      

    }

    public class UserLoginDetails{
        public string email { get; set; }

        public string password { get; set; }

        public bool returnSecureToken { get; set; }

        public UserLoginDetails(UserModel user) {
            this.email = user.Email;
            this.password = user.Password;
            this.returnSecureToken = true;
        }
    }

    public class SuccessResponse {
        public string localId { get; set; }
    }

}