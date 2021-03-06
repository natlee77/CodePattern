using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace SOLID.Service 
{
   public static  class ToDoAnimal
    {
        static List<IUser> users = ToDoUser.MockUserslist;
        public static List<IAnimal> MockAnimals = new List<IAnimal>
        {
            // Create a list of animals to use for testing
            
            
                      new Animal {PetsId=1, PetsName="Good Boy", TypeOfAnimal="Dog", PetsOwner = new User(){ FirstName = "Johan" },CheckIn = false},
                      new Animal {PetsId=2, PetsName="Tindra", TypeOfAnimal="Dog", PetsOwner=new User(){ FirstName = "Nataliya" },CheckIn = true },
                      new Animal {PetsId=3, PetsName="MMMayuu", TypeOfAnimal="Cat", PetsOwner=new User() { FirstName = "Stefan" },CheckIn = false},

            };

        public static  void RegistrateAnimal()
        {
            Console.WriteLine("Please registrate your Animal .");
            // Create a animal
            IAnimal _animal = AnimalManager.CreateAnimal(MockAnimals);

            // If user is not null print username and save to database
            if (_animal != null)
            {
                DataOutput.ToConsole($"Your petsname is: {_animal.PetsName} ");
                //DataRepository.SaveAnimal(_animal, MockAnimals);
            }

        }
        public static void ShowAnimals( )
        {
             
            foreach (var a in MockAnimals)
            {
                Console.WriteLine($"Telef: {a.PetsOwner.Telefon}, PetsName: {a.PetsName}, TypeOfAnimal: {a.TypeOfAnimal}, PetsOwner:{a.PetsOwner.FirstName}");
            }
        }
        public static void ShowAnimalsByName()
        {
            IAnimal _animal = new Animal();
            IUser _petsOwner = new User();
            
            DataOutput.ToConsole("Please enter your Animal name.");
            var inputName = DataInput.FromConsole();
            // Verify                         
            while (InputVerification.VerifyText(inputName) == false)
            {
                Console.WriteLine("That is not a valid type, write again:");
                inputName = DataInput.FromConsole();
            }
             
            _animal = (Animal)MockAnimals.FirstOrDefault(a => a.PetsName == inputName);
            if (_animal != null)
            {
                Console.WriteLine($"PetsName: {_animal.PetsName}, TypeOfAnimal: {_animal.TypeOfAnimal}, PetsOwner: {_animal.PetsOwner.DisplayName},  Telef: 3{_animal.PetsOwner.Telefon}");
                 
            }
            else
            {
                Console.WriteLine("This animal is not found in our system, Please registrad new  .");
            } 

        }

        public static void ShowAnimalsByCheckIn()
        {
              
            foreach (var a in MockAnimals)
            {
                if (a.CheckIn==true)
                {
                    Console.WriteLine($"tel:{a.PetsOwner.Telefon}, PetsName: {a.PetsName}, TypeOfAnimal: {a.TypeOfAnimal}, PetsOwner:{a.PetsOwner.FirstName} ");
                }
                else if (a.CheckIn != true && false)
                {
                    Console.WriteLine("Not animals in ");
                }
            }
        }

        }
    }
