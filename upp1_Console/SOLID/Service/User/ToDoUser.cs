using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service 
{
   public static class ToDoUser
    {
        public static void RegistrateUser()
        {
            Console.WriteLine("Please registrate you.");
            // Create a user
            User user = UserManager.Create();

            // If user is not null print username and save to database
            if (user != null)
            {
                DataOutput.ToConsole($"Your username is: {user.DisplayName}");
                DataRepository.SaveUser(user);
            }

        }
        public static void ShowUsers()
        {

            List<User> Users  = new List<User>
            {
             new User {UserId=1, FirstName="Stefan", LastName="Karlsson", Email="StefanKarlson@gmail.com",},
             new User {UserId=2, FirstName="Johan", LastName="Larsson", Email="JLarsson@gmail.com"},
             new User {UserId=3, FirstName="Niklas", LastName="Svensson",  Email="NSvensson@gmail.com"},

            };
            foreach (var u in Users )
            {
                Console.WriteLine($"UserId:{u.UserId}, Name: {u.FirstName} {u.LastName}, Email: {u.Email} ");
            }
        }
    }
}
