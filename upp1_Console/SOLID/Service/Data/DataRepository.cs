using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;

namespace SOLID 
{
    public static class DataRepository
    {
        public static void SaveUser(IUser user, List<IUser> users)
        {
            users.Add(user);
        }
        
        public static void SaveAnimal(IAnimal animal, List<IAnimal> animals)
        {
            animals.Add(animal);
        }
         
        public static  void SaveDayService(IDayService dayService)
        {
            // Save user to database
        }
        public static void SaveExtraService(IExtraService extraService)
        {
            // Save user to database
        }

    }
}