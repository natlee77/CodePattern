
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
   public  class User   : IUser  
    {
        
        public string Telefon { get; set; }      
        public string FirstName { get; set; }   
        public string Email { get; set; }         
        public string LastName { get; set; }
        public string DisplayName => $"{FirstName }  {LastName }";

     

        public User()  
        {
        }

    }
}
