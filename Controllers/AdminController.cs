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

namespace Locate_closest_business.Controllers
{
    public class AdminController : Controller
    {
        private string CS = "data source=localhost\\SQLEXPRESS; database=EssentialBusinesses; integrated security=true;";

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
                //TODO: add admin users
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

                try{
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spAddNewBusiness", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        cmd.Parameters.AddWithValue("@MemberIds", business.MemberIds);
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
                    ViewBag.Message = "Successfully submitted business registration request";
                    return View(new BusinessModel());
                }
                catch(Exception exp){
                    ViewBag.Message = "Something went wrong. Please try again later.";
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
                SqlCommand cmd = new SqlCommand("spGetAllBusinesses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    BusinessModel business = new BusinessModel();
                    business.MemberIds = sdr["MemberIds"].ToString();
                    business.CompanyName = sdr["CompanyName"].ToString();
                    business.RegistrationNumber = sdr["RegistrationNumber"].ToString();
                    business.Category = sdr["Category"].ToString();
                    business.NumEmployees = (int)sdr["NumEmployees"];
                    business.Address = sdr["Address"].ToString();
                    business.RequestStatus = sdr["RequestStatus"].ToString();
                    model.Add(business);
                }
            }
            
            ViewBag.Current = "RegistrationRequests";
            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmRegistration(string registrationNumber)
        {
            try{
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spChangeBusinessRequestStatus", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);
                    cmd.Parameters.AddWithValue("@RequestStatus", "Approved");
                    cmd.ExecuteNonQuery();
                }
                ViewBag.Message = "Successfully approved business registration request";
            }
            catch(Exception exp){
                ViewBag.Message = "Something went wrong. Please try again later.";
            }
            return RedirectToAction("RegistrationRequests");
        }

        [HttpPost]
        public IActionResult DenyRegistration(string registrationNumber)
        {
            try{
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spChangeBusinessRequestStatus", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);
                    cmd.Parameters.AddWithValue("@RequestStatus", "Denied");
                    cmd.ExecuteNonQuery();
                }
                ViewBag.Message = "Successfully denied business registration request";
            }
            catch(Exception exp){
                ViewBag.Message = "Something went wrong. Please try again later.";
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