using System;

namespace Locate_closest_business.Models
{
    public class MemberModel
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Email { get; set; }
       public string Phone { get; set; }
       public string[] MemberIds { get; set; }
    }
}