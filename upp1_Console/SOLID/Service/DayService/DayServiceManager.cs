using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Interfaces;


namespace SOLID.Service
{
    internal class DayServiceManager
    {
        internal static DayService CreateDayService()
        {
            
             DayService _daydate = new DayService();
            
            DataOutput.ToConsole("Please enter When do you want to put  your Animal to Care--- yyyy-mm-dd");
            try
            { 
            _daydate.DateGetIn = Convert.ToDateTime(Console.ReadLine()) ; //DateTime.Today.ToString();
            }
            catch {
                Console.Write("Sorry man ! That is not a valid date, I mean yyyy-mm-dd, try again. ");
            }
             
            
            DataOutput.ToConsole("Please enter When do you want to take back  your Animal .-- yyyy-mm-dd");

            try
            {
                _daydate.DateGetOut = Convert.ToDateTime(Console.ReadLine());

             }
            catch
            {
                Console.Write("Sorry man ! That is not a valid date, I mean yyyy-mm-dd, try again. ");
            }
            return _daydate;
        }
    }
}