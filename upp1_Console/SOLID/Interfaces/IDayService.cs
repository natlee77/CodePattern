using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public interface IDayService
    {
       int dsID  { get; set; }
       DateTime   DateGetIn  { get; set; }
       DateTime DateGetOut { get; set; }        
       double PricePerDag { get; set; }    
       int PetsId { get; set; }
       

    }
}
