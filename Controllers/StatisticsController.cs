using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;


namespace Locate_closest_business.Controllers
{
    public partial class StatisticsController : Controller
    {
        public IActionResult Summary()
        {
            try
            {
                Task<SummaryResponseWrapperModel> task = Task.Run<SummaryResponseWrapperModel>(async () => await GetCovidSummary());
                task.Wait();
                SummaryResponseWrapperModel APIResponse = task.Result;

                SummaryModel requestedSummary = new SummaryModel();
                requestedSummary.Global = APIResponse.Global;
                requestedSummary.Country = APIResponse.Countries.Find(i => i.Country == "South Africa");
                return PartialView("Summary", requestedSummary);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                return RedirectToAction("HttpRequestError");
            }
        }

        public IActionResult ListedCountries()
        {
            try
            {
                Task<List<CountrySummaryModel>> task = Task.Run<List<CountrySummaryModel>>(async () => await GetListedCountries());
                task.Wait();
                List<CountrySummaryModel> APIResponse = task.Result;

                ViewBag.listOfCountries = task.Result.OrderBy(o=>o.Country).ToList();
                return View();
            }
            catch (Exception exp)
            {
                Console.WriteLine("StatisticsController.ListedCountries Exception::" + exp);
                return RedirectToAction("HttpRequestError");
            }
        }

        public JsonResult SpecificCountryStatistics([FromQuery]string pCountrySlug)
        {
            var errorJSON = new
            {
                errorMessage = "External_API_Unreachable"
            };

            try
            {
                Task<SpecificCountryStatisticsModel> task = Task.Run<SpecificCountryStatisticsModel>(async () => await GetSpecificCountryInfo(pCountrySlug));
                task.Wait();
                SpecificCountryStatisticsModel APIResponse = task.Result;

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

        public List<AllCountryStatisticsModel> GetAllCountryStats()
        {
            try
            {
                Task<SummaryResponseWrapperModel> task = Task.Run<SummaryResponseWrapperModel>(async () => await GetCovidSummary());
                task.Wait();
                SummaryResponseWrapperModel APIResponse = task.Result;
                List<AllCountryStatisticsModel> countrySpecificStats = new List<AllCountryStatisticsModel>();
                foreach (var item in APIResponse.Countries)
                {
                    countrySpecificStats.Add(new AllCountryStatisticsModel(item.Country, item.NewConfirmed, item.TotalConfirmed, item.NewDeaths, item.TotalDeaths, item.NewRecovered, item.TotalRecovered));
                }
              
                List<AllCountryStatisticsModel> countrys = new List<AllCountryStatisticsModel>();
                return countrySpecificStats;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Failed to get Statistics (StatisticsController.cs GetAllCountryStats(), retrying once..");
                try
                {
                    System.Threading.Thread.Sleep(100);

                    Task<SummaryResponseWrapperModel> task = Task.Run<SummaryResponseWrapperModel>(async () => await GetCovidSummary());
                    task.Wait();
                    SummaryResponseWrapperModel APIResponse = task.Result;
                    List<AllCountryStatisticsModel> countrySpecificStats = new List<AllCountryStatisticsModel>();
                    foreach (var item in APIResponse.Countries)
                    {
                        countrySpecificStats.Add(new AllCountryStatisticsModel(item.Country, item.NewConfirmed, item.TotalConfirmed, item.NewDeaths, item.TotalDeaths, item.NewRecovered, item.TotalRecovered));
                    }
                
                    List<AllCountryStatisticsModel> countrys = new List<AllCountryStatisticsModel>();
                    return countrySpecificStats;
                }
                catch (Exception exp2)
                {
                    Console.WriteLine("StatisticsController.GetAllCountryStats 2nd Exception, not retrying agian::" + exp);
                    return null;
                }
            }
        }

        public IActionResult HttpRequestError()
        {
            return View();
        }
    }
}
