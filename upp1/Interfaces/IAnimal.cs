using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Interfaces
{
     internal  interface IAnimal
    {
        int PetsId { get; set; }
        int UserId { get; set; }
        string PetsName { get; set; }
        string TypeOfAnimal { get; set; }
        

    }
}