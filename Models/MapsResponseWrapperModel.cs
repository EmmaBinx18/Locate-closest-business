using System;
using System.Collections.Generic;

namespace Locate_closest_business.Models
{
    public class MapsResponseWrapperModel
    {
        public List<MapsNearbySearchResultModel> results { get; set; }
        public string status {get; set;} 
    }

    public class MapsNearbySearchResultModel
    {
        public string business_status { get; set; }
        public GeometryWrapper geometry {get; set;}
        public string icon {get; set;}
        public string id {get; set;}
        public string name {get; set;}
        public OpeningHours opening_hours {get; set;}
        public string place_id {get; set;}
        public string price_level {get; set;}
        public string[] types {get; set;}

    }

    public class GeometryWrapper
    {
        public Coordinate location {get; set;}
        
    }
    public struct Coordinate
    {
        public double lat {get; set;}
        public double lng {get; set;}
    }

    public struct OpeningHours
    {
        public bool open_now {get; set;}
    }
}
