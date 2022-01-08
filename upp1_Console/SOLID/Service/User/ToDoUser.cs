using SOLID.Interfaces;
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
                DataOutput.ToConsole($"We created new User, Your username is: {user.DisplayName}");
                DataRepository.SaveUser(user);
            }

        }
        public static void ShowUsers( )
        {
            List<IUser> users = MockUpp.MockUsers ();
            foreach (var u in users )
            {
                Console.WriteLine($"UserId:{u.Telefon}, Name: {u.FirstName} {u.LastName}, Email: {u.Email} ");
            }
        }
    }
}
