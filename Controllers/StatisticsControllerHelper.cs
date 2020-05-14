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

        public async Task<SummaryResponseWrapperModel> GetCovidSummary()
        {
            try
            {
                HttpClient _httpClient = new HttpClient();
                var task =
                    await
                        // ReSharper disable once UseStringInterpolation
                        _httpClient.GetAsync(string.Format("https://api.covid19api.com/summary")).ConfigureAwait(false);

                task.EnsureSuccessStatusCode();

                var payload = task.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<SummaryResponseWrapperModel>(await payload.ConfigureAwait(false),
                    new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task<List<CountryModel>> GetListedCountries()
        {
            try
            {
                HttpClient _httpClient = new HttpClient();
                var task = await _httpClient.GetAsync(string.Format("https://api.covid19api.com/countries")).ConfigureAwait(false);
                task.EnsureSuccessStatusCode();
                var payload = task.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CountryModel>>(payload.Result);
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine("HttpRequestException caught:: " + ex.Message);
                return null;
            }
        }
    }
}
