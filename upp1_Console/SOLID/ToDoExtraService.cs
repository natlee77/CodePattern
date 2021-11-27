using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service 
{
   public static  class ToDoExtraService
    {
        
        public static void Create()
        {
            Console.WriteLine("Please registrate Date when you want to Trim your animal.");

            ExtraService extraService = ExtraServiceManager.CreateExtraService();

            // If user is not null print username and save to database
            if (extraService != null)
            {
                DataOutput.ToConsole($"Your date is: {extraService.Date}");
                DataRepository.SaveExtraService(extraService);
            }

        }

        
    }
}
