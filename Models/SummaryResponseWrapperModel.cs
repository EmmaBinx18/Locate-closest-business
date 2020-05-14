using System;
using System.Collections.Generic;

namespace Locate_closest_business.Models
{
    public class SummaryResponseWrapperModel
    {
        public GlobalModel Global {get; set;}
        public List<CountrySummaryModel> Countries { get; set; }
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
}
