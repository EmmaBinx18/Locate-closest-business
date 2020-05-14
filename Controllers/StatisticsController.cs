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



namespace Locate_closest_business.Controllers
{
    public partial class StatisticsController : Controller
    {
        public IActionResult Summary()
        {
            try
            {
                Task<SummaryResponseWrapperModel> task = Task.Run<SummaryResponseWrapperModel>(async () => await GetCovidSummary());
                SummaryResponseWrapperModel APIResponse = task.Result;
                if (APIResponse == null)
                {
                    return RedirectToAction("HttpRequestError");
                }

                SummaryModel requestedSummary = new SummaryModel();
                requestedSummary.Global = APIResponse.Global;
                requestedSummary.Country = APIResponse.Countries.Find(i => i.Country == "South Africa");
                return View(requestedSummary);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return NotFound();
            }
        }

        public IActionResult ListedCountries()
        {
             try
            {
                Task<List<CountryModel>> task = Task.Run<List<CountryModel>>(async () => await GetListedCountries());
                List<CountryModel> APIResponse = task.Result;
                if (APIResponse == null)
                {
                    return NotFound();
                }

                ViewBag.listOfCountries = task.Result.OrderBy(o=>o.Country).ToList();
                return View();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return NotFound();
            }
        }

        public IActionResult HttpRequestError()
        {
            return View();
        }
    }
}
