using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System.Threading.Tasks;

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
            string businessType = "";

            if (category == "Agriculture, hunting, forestry, fishing")
            {
                businessType = "hardware_store";
            }

            try
            {
                Task<MapsResponseWrapperModel> task = Task.Run<MapsResponseWrapperModel>(async () => await PerformNearbySearch(lat,lng,businessType,searchRadius,opennow));
                task.Wait();
                MapsResponseWrapperModel APIResponse = task.Result;

                if (APIResponse == null)
                {
                    return Json(errorJSON);
                }
                return Json(APIResponse);
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
