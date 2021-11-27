using System;
 
using SOLID.Interfaces;

namespace SOLID.Service
{
    public class ExtraService : IExtraService
    {
        
         
        public int esId { get ; set  ; }
        public DateTime Date { get  ; set  ; }
        public bool   Done { get  ; set  ; }
        public string ServiceDescription { get  ; set  ; }
        public double ServicePrice { get  ; set ; }
        public string PetsName { get; set; }
        public int InvoiceId { get; set; }



        
        public virtual Animal Animal { get; set; }
      
        public virtual Invoice Invoice { get; set; }


        public ExtraService()
        { }
        public ExtraService(int extraServiceId, DateTime date, bool done, string serviceDescription, double servicePrice, string petsName, int invoiceId)
        {
            esId = extraServiceId;
            Date = date;
            Done = done;
            ServiceDescription = serviceDescription;
            ServicePrice = servicePrice;
            PetsName = petsName;
            InvoiceId = invoiceId;
        }
    }
}

