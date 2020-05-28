﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System;
using System.Collections.Generic; 
using System.Configuration; 
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Locate_closest_business.Controllers
{
    public partial class HomeController : Controller
    {
        private string CS = "data source=localhost\\SQLEXPRESS; database=EssentialBusinesses; integrated security=true;";
        public SearchModel searchModel = new SearchModel();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(TempData["UserId"] != null) {
                ViewBag.userId = TempData["UserId"]; 
            } 
            return View(BusinessModelHelper());
        }
		
		public JsonResult MapsNearbySearch([FromQuery]string lat, [FromQuery]string lng, [FromQuery]string category, int searchRadius = 1500, bool opennow = false)
        {
            var errorJSON = new{errorMessage = "External_API_Unreachable"};

            List<string> businessTypeList = new List<string>();
            List<string> keywordSearchList = new List<string>();

            foreach(string item in searchModel.serviceDictionary[category]["businessList"]){
                businessTypeList.Add(item);
            }

            foreach(string item in searchModel.serviceDictionary[category]["keywordList"]){
                keywordSearchList.Add(item);
            }

            try
            {
                MapsResponseWrapperModel compoundResponse = new MapsResponseWrapperModel();
                compoundResponse.results = new List<MapsResponseWrapperModel.MapsNearbySearchResultModel>();

                foreach (string vBusinessType in businessTypeList)
                {
                    Task<MapsResponseWrapperModel> task = Task.Run<MapsResponseWrapperModel>(async () => await PerformNearbySearch(lat,lng,vBusinessType,"",searchRadius,opennow));
                    task.Wait();
                    MapsResponseWrapperModel APIResponse = task.Result;
                    compoundResponse.results.AddRange(APIResponse.results);
                }

                foreach (string vKeyword in keywordSearchList)
                {
                    Task<MapsResponseWrapperModel> task = Task.Run<MapsResponseWrapperModel>(async () => await PerformNearbySearch(lat,lng,"",vKeyword,searchRadius,opennow));
                    task.Wait();
                    MapsResponseWrapperModel APIResponse = task.Result;
                    compoundResponse.results.AddRange(APIResponse.results);
                }
                compoundResponse.status = "OK";

                return Json(compoundResponse);
            }
            catch (Exception exp)
            {
                if (exp.Message.Contains("No such host is known."))
                {
                    Console.WriteLine(exp);
                    return Json(errorJSON);
                }
                else if (exp.Message.Contains("Response status code does not indicate success: 404 (Not Found)"))
                {
                    Console.WriteLine(exp);
                    var incorrectParamsContent = new
                    {
                        errorMessage = "Specified_Country_Slug_Not_Found"
                    };
                    return Json(incorrectParamsContent);
                }
                else
                {
                    Console.WriteLine(exp);
                    var unexpectedErrorContent = new
                    {
                        errorMessage = exp.Message
                    };
                    return Json(unexpectedErrorContent);
                }
            }
        }

        private BusinessManagementModel BusinessModelHelper()
        {
            BusinessManagementModel model = new BusinessManagementModel();
            model.NewBusiness = new BusinessModel();
            model.Businesses = new List<BusinessModel>();

            if(TempData["UserId"] != null){
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spGetBusinessesByUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", TempData["UserId"].ToString());
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
                        model.Businesses.Add(business);
                    }
                }
            }

            return model;
        }

        public IActionResult RegisterBusiness()
        {
            return View(BusinessModelHelper());
        }

        [HttpPost]
        public IActionResult RegisterBusiness(BusinessManagementModel businessManagementModel)
        {
            if (ModelState.IsValid)
            {
                BusinessModel business = new BusinessModel(businessManagementModel.NewBusiness);
                business.RequestStatus = "Pending";
                business.UserId = TempData["UserId"].ToString();

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
                ViewBag.SuccessfulSubmit = true;
                return RedirectToAction("Index");
            }
            BusinessManagementModel model = BusinessModelHelper();
            model.NewBusiness = businessManagementModel.NewBusiness;
            return View(model);
        } 

        [HttpPost]
        public IActionResult RemoveBusiness(string registrationNumber)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spRemoveBusiness", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
