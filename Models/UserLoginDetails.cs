namespace Locate_closest_business.Models
{
    public class UserLoginDetails
    {
        public string email { get; set; }

        public string password { get; set; }

        public bool returnSecureToken { get; set; }

        public UserLoginDetails(UserModel user) {
            this.email = user.Email;
            this.password = user.Password;
            this.returnSecureToken = true;
        }
    }
}