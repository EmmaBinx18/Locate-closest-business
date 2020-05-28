using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System.Configuration; 
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Locate_closest_business.Controllers
{
    public class AdminController : Controller
    {
        private string CS = "data source=localhost\\SQLEXPRESS; database=EssentialBusinesses; integrated security=true;";
        private string FB_SignUp = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=AIzaSyBH0hd7PJ8tFZ1aK18OypZV_Ki6kWDpqGQ";

        static HttpClient client = new HttpClient();

        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        private UserManagementModel AdminModelHelper()
        {
            UserManagementModel model = new UserManagementModel();
            model.NewAdmin = new UserModel();
            model.AdminUsers = new List<UserModel>();

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spGetAllAdminUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    if(sdr["UserId"].ToString() != (string)TempData["UserId"]){
                        UserModel user = new UserModel();
                        user.UserId = sdr["UserId"].ToString();
                        user.FirstName = sdr["FirstName"].ToString();
                        user.LastName = sdr["LastName"].ToString();
                        user.Email = sdr["Email"].ToString();
                        user.Phone = sdr["Phone"].ToString();
                        user.Password = "";
                        user.ConfirmPassword = "";
                        model.AdminUsers.Add(user);
                    }
                }
            }

            return model;
        }

        public IActionResult Admin()
        {            
            ViewBag.Current = "Admin";
            return View(AdminModelHelper());
        }

        [HttpPost]
        public async Task<IActionResult> Admin(UserManagementModel managementModel)
        {
            if(ModelState.IsValid){
                UserModel user = new UserModel(managementModel.NewAdmin);
                UserLoginDetails details = new UserLoginDetails(user);    
                HttpResponseMessage response = await client.PostAsJsonAsync(FB_SignUp, details);
                
                try {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsAsync<SuccessResponse>();
                    user.UserId = responseBody.localId;
                    
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spAddNewUser", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        cmd.Parameters.AddWithValue("@UserId", user.UserId);
                        cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", user.LastName);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Phone", user.Phone);
                        cmd.Parameters.AddWithValue("@Type", "Admin");
                        cmd.ExecuteNonQuery();
                    }
                    TempData["SuccessMessage"] = "Successfully created Admin user";
                    return RedirectToAction("Admin");
                }
                catch(HttpRequestException)
                {
                    TempData["ErrorMessage"] = "Something went wrong. Please try again later";
                    return RedirectToAction("Admin");
                }
            }
            return View(managementModel);
        }

        [HttpPost]
        public IActionResult RemoveAdmin(string userId)
        {
            try{
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spRemoveAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
                TempData["SuccessMessage"] = "Successfully removed Admin user";
                return RedirectToAction("Admin");
            }
            catch(Exception)
            {
                TempData["ErrorMessage"] = "Something went wrong. Please try again later";
                return RedirectToAction("Admin");
            }
        }

        public IActionResult RegisterBusiness()
        {
            ViewBag.Current = "RegisterBusiness";
            return View(new BusinessModel());
        }

        [HttpPost]
        public IActionResult RegisterBusiness(BusinessModel business){
            if(ModelState.IsValid){
                business.RequestStatus = "Pending";
                business.UserId = TempData["UserId"].ToString();

                try{
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spAddNewBusiness", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        cmd.Parameters.AddWithValue("@CompanyName", business.CompanyName);
                        cmd.Parameters.AddWithValue("@RegistrationNumber", business.RegistrationNumber);
                        cmd.Parameters.AddWithValue("@Category", business.Category);
                        cmd.Parameters.AddWithValue("@NumEmployees", business.NumEmployees);
                        cmd.Parameters.AddWithValue("@Address", business.Address);
                        cmd.Parameters.AddWithValue("@AddressTown", business.AddressTown);
                        cmd.Parameters.AddWithValue("@AddressLongitude", business.AddressLongitude);
                        cmd.Parameters.AddWithValue("@AddressLatitude", business.AddressLatitude);
                        cmd.Parameters.AddWithValue("@RequestStatus", business.RequestStatus);
                        cmd.Parameters.AddWithValue("@UserId", business.UserId);
                        cmd.ExecuteNonQuery();
                    }
                    TempData["SuccessMessage"] = "Successfully submitted business registration request";
                    return RedirectToAction("RegisterBusiness");
                }
                catch(Exception){
                    TempData["ErrorMessage"] = "Something went wrong. Please try again later.";
                    return View(business);
                }
            }
            return View(business);
        }

        public IActionResult RegistrationRequests()
        {
            List<BusinessModel> model = new List<BusinessModel>();
            
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spGetAllBusinessesPending", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    BusinessModel business = new BusinessModel();
                    business.CompanyName = sdr["CompanyName"].ToString();
                    business.RegistrationNumber = sdr["RegistrationNumber"].ToString();
                    business.Category = sdr["Category"].ToString();
                    business.NumEmployees = (int)sdr["NumEmployees"];
                    business.Address = sdr["Address"].ToString();
                    business.RequestStatus = sdr["RequestStatus"].ToString();
                    business.UserId = sdr["UserId"].ToString();
                    model.Add(business);
                }
            }
            
            ViewBag.Current = "RegistrationRequests";
            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmRegistration(string confirmNumber)
        {
            try{
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spChangeBusinessRequestStatus", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@RegistrationNumber", confirmNumber);
                    cmd.Parameters.AddWithValue("@RequestStatus", "Approved");
                    cmd.ExecuteNonQuery();
                }
                TempData["SuccessMessage"] = "Successfully approved business registration request";
            }
            catch(Exception){
                TempData["ErrorMessage"] = "Something went wrong. Please try again later.";
            }
            return RedirectToAction("RegistrationRequests");
        }

        [HttpPost]
        public IActionResult DenyRegistration(string denyNumber)
        {
            try{
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spChangeBusinessRequestStatus", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@RegistrationNumber", denyNumber);
                    cmd.Parameters.AddWithValue("@RequestStatus", "Denied");
                    cmd.ExecuteNonQuery();
                }
                TempData["SuccessMessage"] = "Successfully denied business registration request";
            }
            catch(Exception){
                TempData["ErrorMessage"] = "Something went wrong. Please try again later.";
            }

            return RedirectToAction("RegistrationRequests");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}