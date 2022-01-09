using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID.Interfaces
{
    public class Animal : IAnimal  
    {
       
        public int PetsId { get; set; }         
        public string PetsName { get; set; }
        public string TypeOfAnimal { get; set; }
        public bool CheckIn { get; set; }
        public IUser PetsOwner { get; set; }
        public IDayService DayService { get; set; }
        public IExtraService extraService { get; set; }      
            
    }
}

