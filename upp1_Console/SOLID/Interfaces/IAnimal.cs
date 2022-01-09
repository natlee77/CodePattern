using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
     public  interface IAnimal
    {
        int PetsId { get; set; }       
        string PetsName { get; set; }
        string TypeOfAnimal { get; set; }
        bool  CheckIn{ get; set; }
         IUser PetsOwner { get; set; }
         IDayService DayService { get; set; }
         IExtraService extraService { get; set; }
    }
}