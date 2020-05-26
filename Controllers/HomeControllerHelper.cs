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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Locate_closest_business.Controllers
{
    public partial class HomeController : Controller
    {
        private async Task<MapsResponseWrapperModel> PerformNearbySearch(string pLat, string pLng, string pCategory, string pSearchKeyword, int pSearchRadius, bool pOpenNow)
        {
            MapsResponseWrapperModel APIResponse;

            HttpClient _httpClient = new HttpClient();
            string API_Request = string.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + pLat + "," + 
                pLng + "&radius=" + pSearchRadius + "&key=" + API_Keys.MapsAPI_Key);
            if (pOpenNow == true)
            {
                API_Request += "&opennow=true";
            }

            if (pCategory != "")
            {
                API_Request += ("&type=" + pCategory);
                Console.WriteLine("Searching for Business type: " + pCategory);
            }
            else if (pSearchKeyword != "")
            {
                API_Request += ("&keyword=" + pSearchKeyword);
                Console.WriteLine("Searching for Keyword: " + pSearchKeyword);
            }
            else
            {
                APIResponse = new MapsResponseWrapperModel();
                APIResponse.results = new List<MapsResponseWrapperModel.MapsNearbySearchResultModel>();
                return APIResponse;
            }

            var task = await _httpClient.GetAsync(API_Request).ConfigureAwait(false);
            task.EnsureSuccessStatusCode();
            var payload = task.Content.ReadAsStringAsync();
            APIResponse = JsonConvert.DeserializeObject<MapsResponseWrapperModel>(payload.Result);
            
            return APIResponse;
        }
    }
}
