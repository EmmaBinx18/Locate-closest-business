using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System;
using System.Collections.Generic; 
using System.Configuration; 
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;

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
                TempData.Keep("UserID");
                ViewBag.userId = TempData["UserId"]; 
            } 
            List<AllCountryStatisticsModel> listOfCountrySummaries = new StatisticsController().GetAllCountryStats();
            ViewBag.listOfCountries = listOfCountrySummaries;
            return View(BusinessModelHelper());
        }
		
        public JsonResult MapsNearbySearch([FromQuery]string lat, [FromQuery]string lng, [FromQuery]string category, int searchRadius = 1500, bool opennow = false)
        {
            var errorJSON = new{errorMessage = "External_API_Unreachable"};
            bool mapsSearchSuccess = false;
            bool dbSearchSuccess = false;

            List<string> businessTypeList = new List<string>();
            List<string> keywordSearchList = new List<string>();

            MapsResponseWrapperModel compoundResponse = new MapsResponseWrapperModel();
            compoundResponse.results = new List<MapsNearbySearchResultModel>();

            foreach(string item in searchModel.serviceDictionary[category]["businessList"]){
                businessTypeList.Add(item);
            }

            foreach(string item in searchModel.serviceDictionary[category]["keywordList"]){
                keywordSearchList.Add(item);
            }
            
            try
            {
                //Perform search using Google Maps API
                string business_status_criteria = "OPERATIONAL";

                foreach (string vBusinessType in businessTypeList)
                {
                    Task<MapsResponseWrapperModel> task = Task.Run<MapsResponseWrapperModel>(async () => await PerformNearbySearch(lat,lng,vBusinessType,"",searchRadius,opennow));
                    task.Wait();
                    MapsResponseWrapperModel APIResponse = task.Result;
                    compoundResponse.results.AddRange(APIResponse.results.Where(p => String.Equals(p.business_status, business_status_criteria, StringComparison.CurrentCulture)));
                }

                foreach (string vKeyword in keywordSearchList)
                {
                    Task<MapsResponseWrapperModel> task = Task.Run<MapsResponseWrapperModel>(async () => await PerformNearbySearch(lat,lng,"",vKeyword,searchRadius,opennow));
                    task.Wait();
                    MapsResponseWrapperModel APIResponse = task.Result;
                    compoundResponse.results.AddRange(APIResponse.results.Where(p => String.Equals(p.business_status, business_status_criteria, StringComparison.CurrentCulture)));
                }
                mapsSearchSuccess = true;
            }
            catch (Exception MapsAPIException)
            {
                Console.WriteLine("Exception in HomeController.cs -> MapsNearbySearch Google Maps API search:\n" + MapsAPIException);
            }

            //Perform Database search on Custom Added Businesses
            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spSearchOpenBusinesses", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@lat", SqlDbType.Float).Value = float.Parse(lat, CultureInfo.InvariantCulture);
                    cmd.Parameters.Add("@lng", SqlDbType.Float).Value = float.Parse(lng, CultureInfo.InvariantCulture);
                    cmd.Parameters.Add("@radius", SqlDbType.Int).Value = searchRadius;
                    cmd.Parameters.Add("@businessCategory", SqlDbType.VarChar).Value = category;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        MapsNearbySearchResultModel business = new MapsNearbySearchResultModel();
                        business.business_status = "OPERATIONAL";
                        business.geometry = new GeometryWrapper{
                            location = new Coordinate{
                                lat = double.Parse(sdr["AddressLatitude"].ToString(), CultureInfo.InvariantCulture),
                                lng = double.Parse(sdr["AddressLongitude"].ToString(), CultureInfo.InvariantCulture)
                            }
                        };
                        business.icon = "";
                        business.id = "";
                        business.name = sdr["CompanyName"].ToString();
                        business.opening_hours = new OpeningHours{
                            open_now = true
                        };
                        business.place_id = "";
                        business.price_level = "";
                        string[] categoryArray = new string[1];
                        categoryArray[0] = category;
                        business.types = categoryArray;
                        compoundResponse.results.Add(business);
                    }
                }
                dbSearchSuccess = true;
            }
            catch(Exception DBException)
            {
                Console.WriteLine("Exception in HomeController.cs -> MapsNearbySearch Database read::\n" + DBException);
            }

            if ((dbSearchSuccess && mapsSearchSuccess) == true)
            {
                compoundResponse.status = "OK";
            }
            else if ((dbSearchSuccess && mapsSearchSuccess) == false)
            {
                compoundResponse.status = "FAILED";
            }
            else if (mapsSearchSuccess == false)
            {
                compoundResponse.status = "MAPS_UNAVAILABLE";
            }
            else
            {
                compoundResponse.status = "DB_UNAVAILABLE";
            }
            
            return Json(compoundResponse);
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
                try{
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
                    TempData["SuccessMessage"] = "Successfully sent business registration request";
                }
                catch(Exception){
                    TempData["ErrorMessage"] = "Something went wrong. Please try again later.";
                }
                return RedirectToAction("Index");
            }
            BusinessManagementModel model = BusinessModelHelper();
            model.NewBusiness = businessManagementModel.NewBusiness;
            return View(model);
        } 

        [HttpPost]
        public IActionResult RemoveBusiness(string removeBusiness)
        {
            try{
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spRemoveBusiness", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@RegistrationNumber", removeBusiness);
                    cmd.ExecuteNonQuery();
                }
                TempData["SuccessMessage"] = "Successfully removed business";
            }
            catch(Exception){
                TempData["ErrorMessage"] = "Something went wrong. Please try again later.";
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
