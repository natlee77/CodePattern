using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SOLID.Interfaces;

namespace SOLID.Models
{
    public class ExtraService : IExtraService
    {
        
        [Key]
        [Required]
        public int ExtraServiceId { get ; set  ; }
        public DateTime Date { get  ; set  ; }
        public bool   Done { get  ; set  ; }
        public string ServiceDescription { get  ; set  ; }
        public double ServicePrice { get  ; set ; }
        public int PetsId { get; set; }
        public int InvoiceId { get; set; }



        [ForeignKey("PetsId")]
        public virtual Animal Animal { get; set; }
        [ForeignKey("InvoiceId")]
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

