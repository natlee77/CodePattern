using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace SOLID.Service
{
    public  static class UserManager 
    {     

        public static  IUser Create()
        {
            // Create a new user
            IUser user = new User();

            // Capture tel
            DataOutput.ToConsole("Please enter your tel.");
            user.Telefon = DataInput.FromConsole();
            // Capture first name
            DataOutput.ToConsole("Please enter your first name.");
            user.FirstName = DataInput.FromConsole();

            // Verify first name and if false return null
            if (InputVerification.VerifyText(user.FirstName) == false)
            {
                DataOutput.ToConsole("That is not a valid first name.");
                return null;
            }

            // Capture last name
            DataOutput.ToConsole("Please enter your last name.");
            user.LastName = DataInput.FromConsole();

            // Verify last name and if false return null
            if (InputVerification.VerifyText(user.LastName) == false)
            {
                DataOutput.ToConsole("That is not a valid last name.");
                return null;
            }
            // Capture email
            DataOutput.ToConsole("Please enter your email.");
            user.Email = DataInput.FromConsole();

            return user;
        }


    }
}

   