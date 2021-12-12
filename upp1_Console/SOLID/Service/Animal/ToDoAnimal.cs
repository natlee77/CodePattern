using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SOLID.Service 
{
   public static class ToDoAnimal
    {
        static List<IUser> users = MockUpp.MockUsers();
        static List<IAnimal> animals = MockUpp.MockAnimals();

        

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
            //List<IAnimal> animals = MockUpp.MockAnimals();
            foreach (var a in animals)
            {
                Console.WriteLine($"PetsId:{a.PetsId}, PetsName: {a.PetsName}, TypeOfAnimal: {a.TypeOfAnimal}, PetsOwner:{a.PetsOwner.FirstName}");
            }
        }
        public static void ShowAnimalsByName()
        {
            Animal _animal = new Animal();
            IUser _petsOwner = new User();
            
            DataOutput.ToConsole("Please enter your Animal name.");
            var inputName = DataInput.FromConsole();
            // Verify                         
            while (InputVerification.VerifyText(inputName) == false)
            {
                Console.WriteLine("That is not a valid type, write again:");
                inputName = DataInput.FromConsole();
            }
             
            _animal = (Animal)animals.FirstOrDefault(a => a.PetsName == inputName);
            if (_animal != null)
            {
                Console.WriteLine($"PetsName: {_animal.PetsName}, TypeOfAnimal: {_animal.TypeOfAnimal}, PetsOwner:{_animal.PetsOwner.DisplayName}");
                 
            }
            else
            {
                Console.WriteLine("This animal is not found in our system, Please registrad new  .");
            } 

        }

        public static void ShowAnimalsByCheckIn()
        {
              
            foreach (var a in animals)
            {
                if (a.CheckIn==true)
                {
                    Console.WriteLine($"PetsId:{a.PetsId}, PetsName: {a.PetsName}, TypeOfAnimal: {a.TypeOfAnimal}, PetsOwner:{a.PetsOwner.FirstName} ");
                }
                else if (a.CheckIn != true && false)
                {
                    Console.WriteLine("Not animals in ");
                }
            }
        }

        }
    }
