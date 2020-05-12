using System;
using System.Collections.Generic;

namespace Locate_closest_business.Models
{
    public class SummaryModel
    {
        public GlobalModel Global {get; set;}
        public List<CountriesModel> Countries { get; set; }
    }

    public class GlobalModel
    {
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
    }

    public class CountriesModel
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public DateTime Date { get; set; }
    }
}
