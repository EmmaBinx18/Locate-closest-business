using System.ComponentModel.DataAnnotations;

namespace Locate_closest_business.Models
{
    public class BusinessModel
    {
       [Required]
       public string MemberIds { get; set; }

       [Required]
       public string CompanyName { get; set; }

       [Required]
       public string RegistrationNumber { get; set; }

       public string Category { get; set; }

       [Required(ErrorMessage="Please enter the number of employees")]
       public int NumEmployees { get; set; }

       [Required]
       public string Address { get; set; }

       public string AddressLatitude { get; set; }
       
       public string AddressLongitude { get; set; }

       public string AddressTown { get; set; }
    }
}