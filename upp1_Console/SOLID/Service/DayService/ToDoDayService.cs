using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service
{
   public static class ToDoDayService
    {

        public static List<IDayService> MockDayServices = new List<IDayService>
        {
            // Create a list of animals to use for testing
             
                      new DayService {dsID=1, PetsId=1,PricePerDag=100,  DateGetOut=Convert.ToDateTime("2/2/2020") , DateGetIn=Convert.ToDateTime("4/2/2020") },
                      new DayService {dsID=2, PetsId=2,PricePerDag=80,   DateGetOut=Convert.ToDateTime("2/2/2020"),DateGetIn=Convert.ToDateTime("13/2/2020")},
                      new DayService {dsID=3, PetsId=3,PricePerDag=110,  DateGetOut=Convert.ToDateTime("3/2/2020"),DateGetIn=Convert.ToDateTime("6/2/2020")},
 
            };
        public static void RegistrateAnimalDayCare()
        {
            Console.WriteLine("Please write date when you want We take care of your Animal .\n");
            // Create a date
            DayService _dayService = DayServiceManager.CreateDayService();
            Animal animal = DayServiceManager.CheckInAnimal( );

            // If user is not null print username and save to database
            if (_dayService != null)
            {
                DataOutput.ToConsole($"Your pets is comming in: {_dayService.DateGetIn}");
                DataRepository.SaveDayService(_dayService);
            }
        }
         

    }
}
