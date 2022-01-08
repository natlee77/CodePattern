using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Service
{
    public static class AnimalManager
    {
        public static Animal CreateAnimal(List<IAnimal> animals)
        {
            // Create a new animal
             Animal _animal = new Animal();
             IUser _petsOwner = new User();
            List<IUser> users = MockUpp.MockUserslist;
            List<IAnimal> _animals = MockUpp.MockAnimals ;


            DataOutput.ToConsole("Please enter your Animal name.");
            _animal.PetsName = DataInput.FromConsole();
            // Verify  
            if (InputVerification.VerifyText(_animal.PetsName) == false)
            {
                DataOutput.ToConsole("That is not a valid name.");
                return null;
            }
            DataOutput.ToConsole("Please enter type of your animal .");
            _animal.TypeOfAnimal = DataInput.FromConsole();
            // Verify  
            if (InputVerification.VerifyText(_animal.TypeOfAnimal) == false)
            {
                DataOutput.ToConsole("That is not a valid type.");
                return null;
            }            
            DataOutput.ToConsole("Write Pets owner name: ");
            var inputName = DataInput.FromConsole();
            // Verify                         
            while (InputVerification.VerifyText(inputName) == false)
            {
                Console.WriteLine("That is not a valid type, write again:");
                inputName = DataInput.FromConsole();
            }
            _petsOwner =  users.FirstOrDefault(x => x.FirstName == inputName);

            if (_petsOwner != null)
            {                 
                _animal.PetsOwner= _petsOwner;
                DataRepository.SaveAnimal(_animal ,_animals);
                Console.WriteLine("Animal is created");
            }
            else
            {
                Console.WriteLine("This costumer is not found in our system, Please registrad Your self .");
                return null;
            }
            return _animal;
           
        }
               
    }
}
   