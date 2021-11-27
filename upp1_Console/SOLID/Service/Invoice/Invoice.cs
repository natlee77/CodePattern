
using SOLID.Interfaces;
using System; 
using System.Collections.Generic;

namespace SOLID.Service
{
    public class Invoice : ICalculator 
    {
       
         
        public int InvoiceId { get  ;  set; }              
        public string Description { get  ; set  ; }
        public int Item { get  ; set  ; }
        public double PricePerItem  { get  ; set  ; }               
        public DateTime Date { get  ; set  ; }
        public int UserId { get  ; set  ; }

        public double Total { get; set; } //{ get => throw new Count(Item, PricePerItem); set { this.Total = value; } }
                                          //public double Total { get; set; } = (Item * PricePerItem);





         
        public virtual User User { get; set; }

        public virtual List<DayService> ScheduleItems { get; set; }
        public virtual List<ExtraService> ExtraServicesItems { get; set; }
        

        public Invoice()
        {
        }
        public Invoice(int invoiceId, string description, int item, double pricePerItem, DateTime date, int userId,double total)
        {
            InvoiceId = invoiceId;
            Description = description;
            Item = item;
            PricePerItem = pricePerItem;
            Date = date;
            UserId = userId;
            Total = total;
        }
    }
}
 
