using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Locate_closest_business.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.MapsAPISource = "https://maps.googleapis.com/maps/api/js?key=" + API_Keys.MapsAPI_Key;
            return View();
        }

        public JsonResult MapsNearbySearch([FromQuery]string lat, [FromQuery]string lng, [FromQuery]string category, int searchRadius = 1500, bool opennow = false)
        {
            var errorJSON = new
            {
                errorMessage = "External_API_Unreachable"
            };
            List<String> businessTypeList = new List<string>();
            List<String> keywordSearchList = new List<string>();

            switch (category)
            {
                case ("Agriculture, hunting, forestry, fishing"):
                    businessTypeList.Add("hardware_store");
                    businessTypeList.Add("campground");

                    keywordSearchList.Add("Gun shop");
                    break;
                case ("Electricity, Gas, Water supply"):
                    businessTypeList.Add("gas_station");
                    businessTypeList.Add("electrician");
                    
                    keywordSearchList.Add("Water");
                    break;
                case ("Manufacturing"):
                    keywordSearchList.Add("Manufacturing");
                    break;
                case ("Construction and related services"):
                    businessTypeList.Add("roofing_contractor");
                    businessTypeList.Add("painter");
                    
                    keywordSearchList.Add("Construction");
                    break;
                case ("Wholesale, Retail trade, Spaza shops"):
                    businessTypeList.Add("clothing_store");
                    businessTypeList.Add("convenience_store");
                    businessTypeList.Add("department_store");
                    businessTypeList.Add("electronics_store");
                    businessTypeList.Add("furniture_store");
                    businessTypeList.Add("hardware_store");
                    businessTypeList.Add("home_goods_store");
                    businessTypeList.Add("jewelry_store");
                    businessTypeList.Add("shoe_store");
                    businessTypeList.Add("shopping_mall");
                    businessTypeList.Add("supermarket");
                    break;
                case ("Information and Communication services"):
                    keywordSearchList.Add("Service Provider");
                    keywordSearchList.Add("Information and Communication services");
                    break;
                case ("Media and Entertainment"):
                    keywordSearchList.Add("broadcast");
                    keywordSearchList.Add("tv production");
                    break;
                case ("Financial and Business services"):
                    businessTypeList.Add("accounting");

                    keywordSearchList.Add("Private security");
                    keywordSearchList.Add("financial");
                    keywordSearchList.Add("machine rental");
                    break;
                case ("Accommodation for quarantine, essential services"):
                    keywordSearchList.Add("quarantine accommodation");
                    break;
                case ("Food services (Deliveries)"):
                    businessTypeList.Add("meal_delivery");
                    businessTypeList.Add("meal_takeaway");
                    break;
                case ("Transport, Storage, Communication services"):
                    businessTypeList.Add("airport");
                    businessTypeList.Add("bus_station");
                    businessTypeList.Add("transit_station");
                    businessTypeList.Add("train_station");
                    businessTypeList.Add("taxi_stand");
                    keywordSearchList.Add("Communication Service");
                    break;
                case ("Mining and Quarrying"):
                    keywordSearchList.Add("mining and quarrying");
                    break;
                case ("Repair and Related Emergency services"):
                    businessTypeList.Add("electrician");
                    businessTypeList.Add("plumber");
                    businessTypeList.Add("locksmith");
                    businessTypeList.Add("car_repair");
                    businessTypeList.Add("roofing_contractor");
                    businessTypeList.Add("police");

                    keywordSearchList.Add("towing");
                    keywordSearchList.Add("Private security");
                    break;
                case ("Supply Chain"):
                    keywordSearchList.Add("logistic");
                    keywordSearchList.Add("industrial production");
                    break;
                case ("Health, Social and Personal services"):
                    businessTypeList.Add("dentist");
                    businessTypeList.Add("doctor");
                    businessTypeList.Add("drugstore");
                    businessTypeList.Add("pharmacy");
                    businessTypeList.Add("pet_store");
                    businessTypeList.Add("hospital");
                    businessTypeList.Add("hospital");
                    businessTypeList.Add("hospital");

                    keywordSearchList.Add("pest control");
                    keywordSearchList.Add("counselling");
                    keywordSearchList.Add("old age home");
                    break;
                default:
                    businessTypeList.Clear();
                    keywordSearchList.Clear();
                    break;
            }

            try
            {
                MapsResponseWrapperModel compoundResponse = new MapsResponseWrapperModel();
                compoundResponse.results = new List<MapsResponseWrapperModel.MapsNearbySearchResultModel>();

                foreach (String vBusinessType in businessTypeList)
                {
                    Task<MapsResponseWrapperModel> task = Task.Run<MapsResponseWrapperModel>(async () => await PerformNearbySearch(lat,lng,vBusinessType,"",searchRadius,opennow));
                    task.Wait();
                    MapsResponseWrapperModel APIResponse = task.Result;
                    compoundResponse.results.AddRange(APIResponse.results);
                }

                foreach (String vKeyword in keywordSearchList)
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

        public IActionResult RegisterBusiness()
        {
            ViewBag.SuccessfulSubmit = "none";
            return View(new BusinessModel());
        }

        [HttpPost]
        public IActionResult RegisterBusiness(BusinessModel business)
        {
            if(ModelState.IsValid){
                ViewBag.SuccessfulSubmit = "block";
                return RedirectToAction("");
            }
            
            return View(business);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
