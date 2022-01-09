using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Interfaces;
using System.Linq;

namespace SOLID.Service
{
    internal class DayServiceManager
    {
        //static List<IUser> users = MockUpp.MockUsers;
        static List<IAnimal> animals = ToDoAnimal.MockAnimals ;
      
        public static IAnimal CheckInAnimal( )
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

            _animal = (Animal) animals.FirstOrDefault(a => a.PetsName == inputName);
            if (_animal != null)
            {
                _animal.CheckIn = true;
                Console.WriteLine($" {_animal.PetsOwner.DisplayName}! You booked day care for  {_animal.PetsName}");
                 
            }
            else
            {
                Console.WriteLine("This animal is not found in our system, Please registrad new  .");
            }
            return _animal;
        }
        internal static IDayService CreateDayService()
        {

            IDayService _daydate = new DayService();

            DataOutput.ToConsole("Please enter When do you want to put  your Animal to Care: yyyy-mm-dd");
            try { _daydate.DateGetIn = Convert.ToDateTime(Console.ReadLine()); } //DateTime.Today.ToString(); 
            catch { Console.Write("Sorry man ! That is not a valid date, I mean yyyy-mm-dd, try again. "); }


            DataOutput.ToConsole("Please enter When do you want to take back  your Animal : yyyy-mm-dd");

            try { _daydate.DateGetOut = Convert.ToDateTime(Console.ReadLine()); }
            catch { Console.Write("Sorry man ! That is not a valid date, I mean yyyy-mm-dd, try again. "); }
             

            return _daydate;


        }
    }
}