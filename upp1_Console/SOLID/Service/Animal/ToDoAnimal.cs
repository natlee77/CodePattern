using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service 
{
   public static class ToDoAnimal
    {
        static List<IAnimal> animals = new List<IAnimal>();
        static List<IUser> users = new List<IUser>();

        //public static User User  { get { return null; }   }

        public static void RegistrateAnimal()
        {
            Console.WriteLine("Please registrate your Animal .");
            // Create a animal
            Animal _animal = AnimalManager.CreateAnimal( animals );

            // If user is not null print username and save to database
            if (_animal != null)
            {
                DataOutput.ToConsole($"Your petsname is: {_animal.PetsName} ");
                DataRepository.SaveAnimal(_animal);
            }

        }
        public static void ShowAnimals( )
        {
            List<IAnimal> animals = MockUpp.MockAnimals();
            foreach (var a in animals)
            {
                Console.WriteLine($"PetsId:{a.PetsId}, PetsName: {a.PetsName}, TypeOfAnimal: {a.TypeOfAnimal}, PetsOwner:{a.PetsOwner.FirstName}");//User.DisplayName.GetType().Name}
            }
            
        }
        
    }
}
