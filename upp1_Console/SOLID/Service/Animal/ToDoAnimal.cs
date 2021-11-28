using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service 
{
   public static class ToDoAnimal
    {
     

        //public static User User  { get { return null; }   }

        public static void RegistrateAnimal()
        {
            Console.WriteLine("Please registrate your Animal .");
            // Create a animal
            Animal _animal = AnimalManager.CreateAnimal();

            // If user is not null print username and save to database
            if (_animal != null)
            {
                DataOutput.ToConsole($"Your petsname is: {_animal.PetsName} ");
                DataRepository.SaveAnimal(_animal);
            }

        }
        public static void ShowAnimals()
        {
            List<Animal> AnimalsList = new List<Animal>
                {
                      new Animal {PetsId=1, PetsName="Good Boy", TypeOfAnimal="Dog", UserId="2"},
                      new Animal {PetsId=2, PetsName="Tindra", TypeOfAnimal="Dog",UserId="3"},
                      new Animal {PetsId=3, PetsName="MMMayuu", TypeOfAnimal="Cat", UserId="1"},
                };

            foreach (var a in AnimalsList)
            {
                Console.WriteLine($"PetsId:{a.PetsId}, PetsName: {a.PetsName}, TypeOfAnimal: {a.TypeOfAnimal}, UserId:{a.UserId}");//User.DisplayName.GetType().Name}
            }
        }
    }
}
