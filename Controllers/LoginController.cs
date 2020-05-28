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
using System.Data;
using System.Data.SqlClient;


namespace Locate_closest_business.Controllers
{
    public class LoginController : Controller
    {
        private string CS = "data source=localhost\\SQLEXPRESS; database=EssentialBusinesses; integrated security=true;";
        private string FB_SignIn = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=AIzaSyBH0hd7PJ8tFZ1aK18OypZV_Ki6kWDpqGQ";
        private string FB_SignUp = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=AIzaSyBH0hd7PJ8tFZ1aK18OypZV_Ki6kWDpqGQ";
        
        static HttpClient client = new HttpClient();
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
                // boolean valid = Encryption.Verify(user.Password, )
                UserLoginDetails details = new UserLoginDetails(user);   
                HttpResponseMessage response = await client.PostAsJsonAsync(FB_SignIn, details);
                
                try {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsAsync<SuccessResponse>();
                    user.UserId = responseBody.localId;
                    TempData["userId"] = user.UserId;

                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spUserTypeById", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", user.UserId);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while(sdr.Read())
                        {
                            string type = sdr["CompanyName"].ToString();
                            if(type == "Admin"){
                                return RedirectToAction("Admin", "Admin");
                            }
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    return RedirectToAction("Index", "Home");
                }
                catch(HttpRequestException e)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Signup()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public async Task<IActionResult> Signup(UserModel user)
        {
            if(ModelState.IsValid){
                // user.Password = EncryptionModel.HashPassword(user.Password);
                user.ConfirmPassword = user.Password;
                UserLoginDetails details = new UserLoginDetails(user);    
                HttpResponseMessage response = await client.PostAsJsonAsync(FB_SignUp, details);
                
                try {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsAsync<SuccessResponse>();
                    user.UserId = responseBody.localId;
                    TempData["userId"] = user.UserId;

                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spAddNewUser", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        cmd.Parameters.AddWithValue("@UserId", user.UserId);
                        cmd.Parameters.AddWithValue("@Type", "Standard");
                        cmd.ExecuteNonQuery();
                    }
                    
                    return RedirectToAction("Index", "Home");
                }
                catch(HttpRequestException)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(user);
        }  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }      
    }

    public class SuccessResponse {
        public string localId { get; set; }
    }

}