using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System.Data;
using System.Data.SqlClient;

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

            // UserModel user = new UserModel();
            // user.FirstName = "Emma";
            // user.LastName = "Coetzer";
            // user.Email = "emmac@bbd.co.za";
            // user.Phone = "0718831926";
             
            // model.AdminUsers.Add(user);
            // model.AdminUsers.Add(user);
            // model.AdminUsers.Add(user);
            // model.AdminUsers.Add(user);
            // model.AdminUsers.Add(user);
            // model.AdminUsers.Add(user);
            
            ViewBag.Current = "Admin";
            return View(model);
        }

        [HttpPost]
        public IActionResult AddAdmin(UserModel user)
        {
             if(ModelState.IsValid){
                return RedirectToAction("Admin");
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult RemoveAdmin(string email)
        {
            //TODO: remove user
            return RedirectToAction("Admin");
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

                string CS = "data source=localhost\\SQLEXPRESS; database=EssentialBusinesses; integrated security=true;";
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
                    cmd.ExecuteNonQuery();
                }
                return View();
            }
            return View(business);
        }

        public IActionResult RegistrationRequests()
        {
            List<BusinessModel> model = new List<BusinessModel>();
            //TODO: populate list with business registration requests
            
            // BusinessModel business1 = new BusinessModel();
            // business1.MemberIds = "";
            // business1.CompanyName = "New Company";
            // business1.RegistrationNumber = "1234567890";
            // business1.Category = "Food Delivery";
            // business1.NumEmployees = 12;
            // business1.Address = "12 Apple Str, Randpark Ridge, Randburg, 2156";
            // business1.RequestStatus = "Pending";

            // BusinessModel business2 = new BusinessModel();
            // business2.MemberIds = "";
            // business2.CompanyName = "New Company";
            // business2.RegistrationNumber = "1234567890";
            // business2.Category = "Food Delivery";
            // business2.NumEmployees = 24;
            // business2.Address = "12 Apple Str, Randpark Ridge, Randburg, 2156";
            // business2.RequestStatus = "Accepted";

            // model.Add(business1);
            // model.Add(business1);
            // model.Add(business2);
            // model.Add(business2);

            ViewBag.Current = "RegistrationRequests";
            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmRegistration(string registrationNumber)
        {
            //TODO: add business
            //TODO: change business request status to approved
            return RedirectToAction("RegistrationRequests");
        }

        [HttpPost]
        public IActionResult DenyRegistration(string registrationNumber)
        {
            //TODO: remove business registration request
            //TODO: change business request status to denied
            return RedirectToAction("RegistrationRequests");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}