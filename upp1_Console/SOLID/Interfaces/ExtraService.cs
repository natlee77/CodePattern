using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace SOLID.Interfaces
{
    public class ExtraService : IExtraService
    {
        
         
        public int esId { get ; set  ; }
        public DateTime Date { get  ; set  ; }
        public bool   Done { get  ; set  ; }
        public string ServiceDescription { get  ; set  ; }
        public double ServicePrice { get  ; set ; }
        public string PetsName { get; set; }      

        public ExtraService()
        { }
       
    }
}

