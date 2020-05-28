using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locate_closest_business.Models
{
    public class AllCountryStatisticsModel
    {
        public string CountryName { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public List<AllCountryStatisticsModel> allCountries { get; set; }

        public AllCountryStatisticsModel(string countryName, int newConfirmed, int totalConfirmed, int newDeaths, int totalDeaths, int newRecovered, int totalRecovered)
        {
            CountryName = countryName;
            NewConfirmed = newConfirmed;
            TotalConfirmed = totalConfirmed;
            NewDeaths = newDeaths;
            TotalDeaths = totalDeaths;
            NewRecovered = newRecovered;
            TotalRecovered = totalRecovered;
        }

        public AllCountryStatisticsModel()
        {

        }

    }
}
