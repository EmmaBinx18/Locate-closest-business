using System;
using System.Collections.Generic;

namespace Locate_closest_business.Models
{
    public class SummaryModel
    {
        public GlobalModel Global {get; set;}
        public CountrySummaryModel Country { get; set; }
    }
}
