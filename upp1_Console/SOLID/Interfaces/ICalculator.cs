using System;
using System.Collections.Generic;
using System.Text;


namespace SOLID.Interfaces
{
    internal interface ICalculator
    {
         int InvoiceId { get; set; }         
         string Description { get; set; }
         int Item  { get; set; }
         double PricePerItem  { get; set; }
         int UserId { get; set; }        
        
         DateTime Date { get; set; }
          double Total { get; set; }
    }
}
