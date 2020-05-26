using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System;
using System.Collections.Generic; 
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
            return View(BusinessModelHelper());
        }
		
		public JsonResult MapsNearbySearch([FromQuery]string lat, [FromQuery]string lng, [FromQuery]string category, int searchRadius = 1500, bool opennow = false)
        {
            var errorJSON = new
            {
                errorMessage = "External_API_Unreachable"
            };
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

        [HttpPost]
        public IActionResult Search(string searchOption)
        {
            //TODO: need to perform actual search on map based on searchOptions
            return RedirectToAction("Index");
        }

        private BusinessManagementModel BusinessModelHelper()
        {
            BusinessManagementModel model = new BusinessManagementModel();
            model.NewBusiness = new BusinessModel();
            model.Businesses = new List<BusinessModel>(); //TODO: populate list with their businesses

            // BusinessModel business = new BusinessModel();
            // business.MemberIds = "";
            // business.CompanyName = "New Company";
            // business.RegistrationNumber = "1234567890";
            // business.Category = "Food Delivery";
            // business.NumEmployees = 24;
            // business.Address = "12 Apple Str, Randpark Ridge, Randburg, 2156";
            // business.RequestStatus = "Pending";

            // model.Businesses.Add(business);
            // model.Businesses.Add(business);
            // model.Businesses.Add(business);
            // model.Businesses.Add(business);

            return model;
        }

        public IActionResult RegisterBusiness()
        {
            return View(BusinessModelHelper());
        }

        [HttpPost]
        public IActionResult RegisterBusiness(BusinessModel business)
        {
            if (ModelState.IsValid)
            {
                business.RequestStatus = "Pending";

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
                ViewBag.SuccessfulSubmit = true;
                return RedirectToAction("Index");
            }

            BusinessManagementModel model = BusinessModelHelper();
            model.NewBusiness = business;
            return View(model);
        } 

        [HttpPost]
        public IActionResult RemoveBusiness(string registrationNumber)
        {
            //TODO: remove business
            return RedirectToAction("Index");
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
