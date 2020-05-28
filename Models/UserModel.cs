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

       [Required(AllowEmptyStrings = false)]
       [MinLength(8)]
       public string Password { get; set; }

       [Required(AllowEmptyStrings = false)]
       [Compare("Password")]
       public string ConfirmPassword { get; set; }

       public string UserId { get; set; }

       public UserModel()
       {
           this.FirstName = "";
           this.LastName = "";
           this.Email = "";
           this.Phone = "";
           this.Password = "";
           this.ConfirmPassword = "";
       }

       public UserModel(UserModel model)
       {
           this.FirstName = model.FirstName;
           this.LastName = model.LastName;
           this.Email = model.Email;
           this.Phone = model.Phone;
           this.Password = model.Password;
           this.ConfirmPassword = model.ConfirmPassword;
       }

    }
}