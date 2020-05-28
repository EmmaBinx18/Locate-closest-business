using System.ComponentModel.DataAnnotations;

namespace Locate_closest_business.Models
{
    public class BusinessModel
    {
       [Required (ErrorMessage = "*")]
       public string MemberIds { get; set; }

       [Required(ErrorMessage = "*")] 
       public string CompanyName { get; set; }

       [Required(ErrorMessage = "*")]
       public string RegistrationNumber { get; set; }

       public string Category { get; set; }

       [Required(ErrorMessage = "*")]
       public int NumEmployees { get; set; }

       [Required(ErrorMessage = "*")]
       public string Address { get; set; }

       public string AddressLatitude { get; set; }
       
       public string AddressLongitude { get; set; }

       public string AddressTown { get; set; }

       public string RequestStatus { get; set; }

       public string UserId { get; set; }
    }
}