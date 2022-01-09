using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service 
{
   public  static class ToDoUser
    {
        public  static List<IUser> MockUserslist = new List<IUser>
        {
                new User {Telefon="11111", FirstName="Stefan", LastName="Karlsson", Email="StefanKarlson@gmail.com",},
                new User {Telefon="233333", FirstName="Johan", LastName="Larsson", Email="JLarsson@gmail.com"},
                new User {Telefon="3446456", FirstName="Niklas", LastName="Svensson",  Email="NSvensson@gmail.com"},
                new User {Telefon="43452345", FirstName="Nataliya", LastName="Lisjö",  Email="natlisjo@gmail.com"},
        };
        public static  void RegistrateUser()
        {
            Console.WriteLine("Please registrate you.");
            // Create a user
            IUser user = UserManager.Create();
             
            // If user is not null print username and save to database
            if (user != null)
            {
                DataOutput.ToConsole($"We created new User, Your username is: {user.DisplayName}");
                DataRepository.SaveUser(user, MockUserslist);
            }

        }
        public  static void ShowUsers( )
        {
            List<IUser> users =  MockUserslist ;
            foreach (var u in users )
            {
                Console.WriteLine($"Tel:{u.Telefon}, Name: {u.FirstName} {u.LastName}, Email: {u.Email} ");
            }
        }
    }
}
