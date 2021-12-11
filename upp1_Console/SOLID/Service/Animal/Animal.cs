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
        public bool Check { get; set; }
        public IUser PetsOwner { get; set; }
        public IDayService DayService { get; set; }
        public IExtraService extraService { get; set; }
        public Animal()
        {
            
        }

        public Animal(int petsId, string petsName, string typeOfAnimal, bool check, IUser petsOwner, IDayService dayService, IExtraService extraService)
        {
            PetsId = petsId;
            PetsName = petsName;
            TypeOfAnimal = typeOfAnimal;
            Check = check;
            PetsOwner = petsOwner;
            DayService = dayService;
            this.extraService = extraService;
        }

         


    }

}
