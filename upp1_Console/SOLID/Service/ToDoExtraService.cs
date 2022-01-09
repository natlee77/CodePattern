using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Interfaces;
using System.Linq;

namespace SOLID.Service 
{
   public static  class ToDoExtraService
    {
        
        public static void Create()
        {
            Console.WriteLine("Please registrate Date when do you want Extra Service for your animal.");

            IExtraService extraService = ExtraServiceManager.CreateExtraService();

            // If user is not null print username and save to database
            if (extraService != null)
            {
                DataOutput.ToConsole($"You booked date is: {extraService.Date} to Do: {extraService.ServiceDescription} for Your pets {extraService.PetsName} ");
                DataRepository.SaveExtraService(extraService);
            }
        }                
    }
}
