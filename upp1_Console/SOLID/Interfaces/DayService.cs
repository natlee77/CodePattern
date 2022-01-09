using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
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
                
    }
}
