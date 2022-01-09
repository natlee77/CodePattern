using System;
using System.Collections.Generic;
using SOLID.Interfaces;

namespace SOLID.Service
{
    public class DayService : IDayService
    {
        
        public int dsID { get; set; }
        public DateTime DateGetIn { get; set; }
        public DateTime DateGetOut { get; set; }
        public double PricePerDag { get; set; }
        public int PetsId { get; set; }
        public int InvoiceId { get; set; }
        

        public DayService()
        { }
        public DayService(int _dsID, DateTime dateGetIn,   DateTime dateGetOut, double pricePerDag, int petsId, int invoiceId)
        {
            dsID = _dsID;
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
