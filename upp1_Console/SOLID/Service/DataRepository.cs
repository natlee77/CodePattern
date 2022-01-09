using SOLID.Interfaces; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Service 
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
         
        public static  void SaveDayService(IDayService dayService, List<IDayService> services)
        {
            services.Add(dayService);
        }
        public static void SaveExtraService(IExtraService extraService, List<IExtraService> services)
        {
            services.Add(extraService);
        }

    }
}