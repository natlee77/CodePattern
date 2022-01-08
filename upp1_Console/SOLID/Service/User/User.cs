using SOLID.Interfaces;
using System;
using System.Collections.Generic;

namespace SOLID.Service
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

        public User(string telefon, string firstName, string lastName, string email)
        {
            Telefon  = telefon;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
