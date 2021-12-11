using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;

namespace SOLID 
{
    public class DataRepository
    {
        internal static void SaveUser(User user)
        {
            // Save user to database
        }
        public static void SaveAnimal(Animal animal)
        {
            // Save user to database
        }
        public void SaveAnimals(IAnimal animal, List<IAnimal> animals)
        {
            animals.Add(animal);
        }
        //internal static void SaveDate(Animal animal)
        //{
        //    // Save user to database
        //}
        internal static void SaveDayService(DayService dayService)
        {
            // Save user to database
        }
        internal static void SaveExtraService(ExtraService extraService)
        {
            // Save user to database
        }
    }
}