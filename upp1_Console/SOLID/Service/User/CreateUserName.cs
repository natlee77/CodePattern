using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Service
{
    class CreateUserName
    {
         
        public static string CreateShortName(User user)
        {
            //variant att utveckla coden
            //if (user.TypeOfUser == "admin")
            //{
            //    return "admin" + user.LastName;
            //}
            return user.FirstName + " " + user.LastName;
        }
    }
}
