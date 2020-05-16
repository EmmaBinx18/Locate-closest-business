using System;

namespace Locate_closest_business.Models
{
    public class BusinessModel
    {
       public string CompanyName { get; set; }
       public string RegistrationNumber { get; set; }
       public string Category { get; set; }
       public int NumEmployees { get; set; }
       public string Address { get; set; }
    }
}