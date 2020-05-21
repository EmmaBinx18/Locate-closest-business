using System.Collections.Generic;  
using Locate_closest_business.Models;

namespace Locate_closest_business.Models
{
    public class BusinessManagementModel
    {
        public BusinessModel NewBusiness { get; set; }
        public List<BusinessModel> Businesses { get; set; }
    }
}