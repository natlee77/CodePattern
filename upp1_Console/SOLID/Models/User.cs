using SOLID.Interfaces;
using System;
using System.Collections.Generic;

namespace SOLID.Models
{
   public  class User   : IUser  
    {
        
        public int UserId { get; set; }      
        public string FirstName { get; set; }   
        public string Email { get; set; }         
        public string LastName { get; set; }
        public string DisplayName => $"{FirstName }  {LastName }";
        public User() //tomt -altid
        {
        }
        public User(int userId, string firstName, string lastName, string email)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            
        }

        public virtual ICollection<Animal> Animals { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }


    }
}
