using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SOLID.Models
{
   public  class User   : IUser  
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
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
