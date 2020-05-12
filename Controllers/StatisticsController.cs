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
    public class StatisticsController : Controller
    {
        public IActionResult Summary()
        {
            Task<SummaryModel> task = Task.Run<SummaryModel>(async () => await GetCovidSummary());
            SummaryModel summary = task.Result;//async request here

            if (summary == null)
            {
                return NotFound();
            }

            return View(summary);
        }

        public async Task<SummaryModel> GetCovidSummary()
        {
            HttpClient _httpClient = new HttpClient();
            var task =
                await
                    // ReSharper disable once UseStringInterpolation
                    _httpClient.GetAsync(string.Format("https://api.covid19api.com/summary")).ConfigureAwait(false);

            task.EnsureSuccessStatusCode();

            var payload = task.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SummaryModel>(await payload.ConfigureAwait(false),
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }
    }
}
