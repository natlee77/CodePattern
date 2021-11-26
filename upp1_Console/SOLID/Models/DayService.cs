using System;
using System.Collections.Generic;
using SOLID.Interfaces;

namespace SOLID.Models
{
    public class DayService : IDayService
    {
        
        public int ScheduleID { get; set; }
        public DateTime DateGetIn { get; set; }
        public DateTime DateGetOut { get; set; }
        public double PricePerDag { get; set; }
        public int PetsId { get; set; }
        public int InvoiceId { get; set; }
        

        public DayService()
        { }
        public DayService(int scheduleID, DateTime dateGetIn, DateTime dateGetOut, double pricePerDag, int petsId, int invoiceId)
        {
            ScheduleID = scheduleID;
            DateGetIn = dateGetIn;
            DateGetOut = dateGetOut;
            PricePerDag = pricePerDag;
            PetsId = petsId;
            InvoiceId = invoiceId;
        }
        
      
        public virtual Animal Animal { get; set; }        
        public virtual Invoice Invoice { get; set; }
    }
}
