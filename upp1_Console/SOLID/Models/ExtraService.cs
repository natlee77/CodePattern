using System;
 
using SOLID.Interfaces;

namespace SOLID.Models
{
    public class ExtraService : IExtraService
    {
        
         
        public int ExtraServiceId { get ; set  ; }
        public DateTime Date { get  ; set  ; }
        public bool   Done { get  ; set  ; }
        public string ServiceDescription { get  ; set  ; }
        public double ServicePrice { get  ; set ; }
        public int PetsId { get; set; }
        public int InvoiceId { get; set; }



        
        public virtual Animal Animal { get; set; }
      
        public virtual Invoice Invoice { get; set; }


        public ExtraService()
        { }
        public ExtraService(int extraServiceId, DateTime date, bool done, string serviceDescription, double servicePrice, int petsId, int invoiceId)
        {
            ExtraServiceId = extraServiceId;
            Date = date;
            Done = done;
            ServiceDescription = serviceDescription;
            ServicePrice = servicePrice;
            PetsId = petsId;
            InvoiceId = invoiceId;
        }
    }
}

