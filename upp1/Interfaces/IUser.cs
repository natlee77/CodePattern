﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Interfaces
{
    internal interface IUser 
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }


        

    }
}