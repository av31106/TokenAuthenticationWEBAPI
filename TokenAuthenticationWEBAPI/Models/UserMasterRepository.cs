using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuthenticationWEBAPI.Models
{
    public class UserMasterRepository
    {
        public UserMater ValidateUser(string loginId, string password)
        {
            if (loginId == "anil" && password == "anil")
            {
                return new UserMater() { LoginId = "anil", UserRoles = "Admin", UserName = "Anil Kumar",  UserEmailID="AK@gmail.com" };
            }
            else
            {
                return null;
            }
        }
    }

    public class UserMater
    {
        public string LoginId { get; set; }
        public string UserRoles { get; set; }
        public string UserName { get; set; }
        public string UserEmailID { get; set; }

    }
}