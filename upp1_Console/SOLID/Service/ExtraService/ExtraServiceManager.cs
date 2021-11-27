using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service 
{
   internal class ExtraServiceManager
    {
       
        internal static ExtraService CreateExtraService()
        {

            ExtraService _ExtraService = new ExtraService();
            
            DataOutput.ToConsole("Please enter When do you want to put  your Animal to trim--- yyyy-mm-dd");
            try
            {
                _ExtraService.Date  = Convert.ToDateTime(Console.ReadLine()); //DateTime.Today.ToString();
            }
            catch
            {
                Console.Write("Sorry man ! That is not a valid date, I mean yyyy-mm-dd, try again. ");
            }


             
            _ExtraService.ServicePrice = 600.00;

            DataOutput.ToConsole("Please enter your Animal name.");
            _ExtraService.PetsName = DataInput.FromConsole();

            // Verify  
            if (InputVerification.VerifyName(_ExtraService.PetsName) == false)
            {
                DataOutput.ToConsole("That is not a valid name.");
                return null;
            }

             

            return _ExtraService;
        }
    }
}
