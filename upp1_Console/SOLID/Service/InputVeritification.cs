using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Service
{
    class InputVerification
    {
        public static bool VerifyText(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool VerifyInt(int v)
        {
            if (v==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool VerifyDate(string date)
        {

            
                try
                {
                    DateTime dt = DateTime.Parse(date);
                    return true;
                }
                catch
                {
                    return false;
                }
             
        }
    }
}
