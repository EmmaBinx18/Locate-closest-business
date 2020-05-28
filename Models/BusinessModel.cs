using System.ComponentModel.DataAnnotations;

namespace Locate_closest_business.Models
{
    public class BusinessModel
    {
       [Required (ErrorMessage = "*")]
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

       public BusinessModel()
       {
           this.CompanyName = "";
           this.RegistrationNumber = "";
           this.Category = "";
           this.NumEmployees = 0;
           this.Address = "";
           this.AddressLatitude = "";
           this.AddressLongitude = "";
           this.AddressTown = "";
           this.RequestStatus = "";
           this.UserId = "";
       }

       public BusinessModel(BusinessModel model)
       {
           this.CompanyName = model.CompanyName;
           this.RegistrationNumber = model.RegistrationNumber;
           this.Category = model.Category;
           this.NumEmployees = model.NumEmployees;
           this.Address = model.Address;
           this.AddressLatitude = model.AddressLatitude;
           this.AddressLongitude = model.AddressLongitude;
           this.AddressTown = model.AddressTown;
           this.RequestStatus = "";
           this.UserId = "";
       }
    }
}