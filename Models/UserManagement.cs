using System.Collections.Generic;  

namespace Locate_closest_business.Models
{
    public class UserManagementModel
    {
        public UserModel NewAdmin { get; set; }
        public List<UserModel> AdminUsers { get; set; }
    }
}