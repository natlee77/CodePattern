using SOLID.Service;
using System;
using System.Collections.Generic;

namespace SOLID
{
    public static class ThingsToDo
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
        public static void RegistrateAnimal()
        {
            Console.WriteLine("Please registrate your Animal .");
            // Create a animal
            Animal _animal = AnimalManager.CreateAnimal();

            // If user is not null print username and save to database
            if (_animal != null)
            {
                DataOutput.ToConsole($"Your petsname is: {_animal.PetsName}");
                DataRepository.SaveAnimal(_animal);
            }

        }
        public static void RegistrateAnimalDayCare()
        {
            Console.WriteLine("Please write date when you want We take care of your Animal .\n");
            // Create a date
            DayService _dayService = DayServiceManager.CreateDayService();

            // If user is not null print username and save to database
            if (_dayService != null)
            {
                DataOutput.ToConsole($"Your pets came in: {_dayService.DateGetIn}");
                DataRepository.SaveDayService(_dayService);
            }
        }
        public static void ShowUsers()
        {

            List<User> UsersList = new List<User>
            {
             new User{UserId=1, FirstName="Stefan", LastName="Karlsson", Email="StefanKarlson@gmail.com",},
             new User {UserId=2, FirstName="Johan", LastName="Larsson", Email="JLarsson@gmail.com"},
             new User {UserId=3, FirstName="Niklas", LastName="Svensson",  Email="NSvensson@gmail.com"},

            };
            foreach (var u in UsersList)
            {
                Console.WriteLine($"UserId:{u.UserId}, Name: {u.FirstName} {u.LastName}, Email: {u.Email} ");
            }
        }
        public static void ShowAnimals()
        {
               List<Animal> AnimalsList = new List<Animal>
                {
                      new Animal {PetsId=1, PetsName="Good Boy", TypeOfAnimal="Dog", UserId=2},
                      new Animal {PetsId=2, PetsName="Tindra", TypeOfAnimal="Dog",UserId=3},
                      new Animal {PetsId=3, PetsName="MMMayuu", TypeOfAnimal="Cat", UserId=1},
                };

            foreach (var a in AnimalsList)
            {
                Console.WriteLine($"PetsId:{a.PetsId}, PetsName: {a.PetsName}, TypeOfAnimal: {a.TypeOfAnimal}, UserId:{a.UserId}");
            }
        }
    }
}
  
 