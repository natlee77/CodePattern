using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Interfaces
{
    internal interface IDayService
    {
       int dsID  { get; set; }
       DateTime   DateGetIn  { get; set; }
       DateTime DateGetOut { get; set; }
        
        double PricePerDag { get; set; }

        
    }
}
