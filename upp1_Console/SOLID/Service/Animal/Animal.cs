using SOLID.Interfaces;
using System;
using System.Collections.Generic;

namespace SOLID.Service
{
    public class Animal : IAnimal 
    {
       
        public int PetsId { get; set; }
        public string UserId { get; set; }
        public string PetsName { get; set; }
        public string TypeOfAnimal { get; set; }
         
        public Animal()
        {
            
        }

        public Animal(int petsId, string userId, string petsName, string typeOfAnimal)
        {
            PetsId = petsId;
            UserId = userId;
            PetsName = petsName;
            TypeOfAnimal = typeOfAnimal;
        }
      
        public virtual User User{ get   ; set ; }
        
        public virtual List<ExtraService> ExtraServices { get; set; }
        public virtual List<DayService> Schedules { get; set; }
         
    }

}
