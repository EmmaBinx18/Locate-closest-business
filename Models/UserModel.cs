using System.ComponentModel.DataAnnotations;

namespace Locate_closest_business.Models
{
    public class UserModel
    {
       [Required(ErrorMessage = "*")]
       public string FirstName { get; set; }

       [Required(ErrorMessage = "*")]
       public string LastName { get; set; }

       [Required(ErrorMessage = "*")]
       [EmailAddress]
       public string Email { get; set; }

       [Required(ErrorMessage = "*")]
       [Phone]
       public string Phone { get; set; }

       [Required(AllowEmptyStrings = false, ErrorMessage = "*")]
        [MinLength(8)]
       public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*")]
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
           this.UserId = "";
       }

       public UserModel(UserModel model)
       {
           this.FirstName = model.FirstName;
           this.LastName = model.LastName;
           this.Email = model.Email;
           this.Phone = model.Phone;
           this.Password = model.Password;
           this.ConfirmPassword = model.ConfirmPassword;
           this.UserId = "";
       }

    }
}