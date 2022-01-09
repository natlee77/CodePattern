using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public interface IUser 
    {
        string Telefon { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }

        string DisplayName => $"{FirstName }  {LastName }";


    }
}