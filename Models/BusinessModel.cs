using System.ComponentModel.DataAnnotations;

namespace Locate_closest_business.Models
{
    public class BusinessModel
    {
       [Required]
       public string FirstName { get; set; }

       [Required]
       public string LastName { get; set; }

       [Required]
       [EmailAddress]
       public string Email { get; set; }

       [Required]
       [Phone]
       public string Phone { get; set; }

       [Required]
       public string MemberIds { get; set; }

       [Required]
       public string CompanyName { get; set; }

       [Required]
       public string RegistrationNumber { get; set; }

       public string Category { get; set; }

       [Required]
       public string NumEmployees { get; set; }

       [Required]
       public string Address { get; set; }

       [Required]
       public string RecoveryPassword { get; set; }
    }
}