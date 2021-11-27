using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Interfaces
{
    internal interface IExtraService
    {
        int  esId { get; set; }
        DateTime Date { get; set; }
        //bool  Done { get; set; }
        string ServiceDescription { get; set; }
        double ServicePrice { get; set; }
         


    }
}
