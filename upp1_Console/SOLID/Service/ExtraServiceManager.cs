using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Interfaces;
using System.Linq;

namespace SOLID.Service 
{
   internal class ExtraServiceManager
    {
         
        internal static IExtraService CreateExtraService()
        {

            IExtraService _ExtraService = new ExtraService();
            
            DataOutput.ToConsole("Please enter date When do you want to put your Animal to trim --- yyyy-mm-dd");
            try
            {
                _ExtraService.Date  = Convert.ToDateTime(Console.ReadLine()) ; //DateTime.Today.ToString();
            }
            catch
            {
                Console.Write("Sorry man ! That is not a valid date, I mean yyyy-mm-dd, try again. ");
            }

            DataOutput.ToConsole("Please enter description what do you want We do for your Animal name.");
            _ExtraService.ServiceDescription = DataInput.FromConsole();

            // Verify  
            if (InputVerification.VerifyText(_ExtraService.ServiceDescription) == false)
            {
                DataOutput.ToConsole("That is not a valid text.");
                return null;
            }
            
            _ExtraService.ServicePrice = 600.00;

            DataOutput.ToConsole("Please enter your Animal name.");
            _ExtraService.PetsName = DataInput.FromConsole();

            // Verify  
            if (InputVerification.VerifyText(_ExtraService.PetsName) == false)
            {
                DataOutput.ToConsole("That is not a valid name.");
                return null;
            }

             

            return _ExtraService;
        }
    }
}
 