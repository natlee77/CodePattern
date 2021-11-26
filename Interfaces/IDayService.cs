using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Interfaces
{
    internal interface IDayService
    {
       int ScheduleID  { get; set; }
       DateTime   DateGetIn  { get; set; }
       DateTime  DateGetOut { get; set; }
        double PricePerDag { get; set; }

        
    }
}
