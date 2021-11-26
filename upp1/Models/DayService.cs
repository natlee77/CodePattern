using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SOLID.Interfaces;

namespace SOLID.Models
{
    public class DayService : IDayService
    {
        [Key]
        [Required]
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
        
        [ForeignKey("PetsId")]
        public virtual Animal Animal { get; set; }

        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }
    }
}
