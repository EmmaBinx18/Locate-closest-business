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
    public partial class MapsController : Controller
    {
        private async Task<MapsResponseWrapperModel> PerformNearbySearch(string pLat, string pLng, string pCategory, int pSearchRadius, bool pOpenNow)
        {
            HttpClient _httpClient = new HttpClient();
            string API_Request = string.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + pLat + "," + 
                pLng + "&radius=" + pSearchRadius + "&type=" + pCategory + "&key=" + API_Keys.MapsAPI_Key);
            if (pOpenNow == true)
            {
                API_Request += "&opennow=true";
            }

            var task = await _httpClient.GetAsync(API_Request).ConfigureAwait(false);
            task.EnsureSuccessStatusCode();
            var payload = task.Content.ReadAsStringAsync();
            MapsResponseWrapperModel APIResponse = JsonConvert.DeserializeObject<MapsResponseWrapperModel>(payload.Result);
            
            return APIResponse;
        }
    }
}
