using SOLID.Interfaces;
using System;
using System.Collections.Generic;

namespace SOLID.Service
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
