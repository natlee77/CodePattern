using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service
{
   public static class ToDoDayService
    {
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
    }
}
