using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace SOLID.Service
{
    internal static class UserManager
    {
        internal static User Create()
        {
            // Create a new user
            User user = new User();

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

             
            return user;
        }


    }
}

   