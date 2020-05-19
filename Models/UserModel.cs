using System.ComponentModel.DataAnnotations;

namespace Locate_closest_business.Models
{
    public class UserModel
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
       public string Password { get; set; }

       [Required]
       public string ConfirmPassword { get; set; }
    }
}