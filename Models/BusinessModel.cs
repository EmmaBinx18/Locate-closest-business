using System.ComponentModel.DataAnnotations;

namespace Locate_closest_business.Models
{
    public class BusinessModel
    {
       [Required(ErrorMessage="Please enter your first name")]
       public string FirstName { get; set; }

       [Required(ErrorMessage="Please enter you last name")]
       public string LastName { get; set; }

       [Required(ErrorMessage="Please enter you email")]
       [EmailAddress(ErrorMessage="Please enter a valid email")]
       public string Email { get; set; }

       [Required(ErrorMessage="Please enter you phone number")]
       [Phone(ErrorMessage="Please enter a valid phone number")]
       public string Phone { get; set; }

       [Required(ErrorMessage="Please provide all the member's ID numbers")]
       public string MemberIds { get; set; }

       [Required(ErrorMessage="Please enter the company name")]
       public string CompanyName { get; set; }

       [Required(ErrorMessage="Please enter the registration number")]
       public string RegistrationNumber { get; set; }

       public string Category { get; set; }

       [Required(ErrorMessage="Please enter the number of employees")]
       public string NumEmployees { get; set; }

       [Required(ErrorMessage="Please enter the address of the company")]
       public string Address { get; set; }
    }
}