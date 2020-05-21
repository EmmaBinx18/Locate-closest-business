using System.Collections.Generic;  
using Locate_closest_business.Models;

namespace Locate_closest_business.Models
{
    public class UserManagementModel
    {
        public UserModel NewAdmin { get; set; }
        public List<UserModel> AdminUsers { get; set; }
    }
}