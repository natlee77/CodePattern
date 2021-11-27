using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Service
{
    internal static class AnimalManager
    {
        internal static Animal CreateAnimal()
        {
            // Create a new animal
            Animal _animal = new Animal();


            DataOutput.ToConsole("Please enter your Animal name.");
            _animal.PetsName = DataInput.FromConsole();

            // Verify  
            if (InputVerification.VerifyName(_animal.PetsName) == false)
            {
                DataOutput.ToConsole("That is not a valid name.");
                return null;
            }

            DataOutput.ToConsole("Please enter type of your animal .");
            _animal.TypeOfAnimal = DataInput.FromConsole();

            // Verify  
            if (InputVerification.VerifyName(_animal.TypeOfAnimal) == false)
            {
                DataOutput.ToConsole("That is not a valid type.");
                return null;
            }

            return _animal;
        }
               
    }
}
   