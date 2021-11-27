using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID 
{
   public class MockData
    {
       public List<User> UsersList = new List<User>
        {
         new User{UserId=1, FirstName="Stefan", LastName="Karlsson", Email="StefanKarlson@gamil.com",},
         new User {UserId=2, FirstName="Johan", LastName="Larsson", Email=""},
         new User {UserId=3, FirstName="Niklas", LastName="Svensson",  Email=""},
       
        };
       public List<Animal> AnimalsList = new List<Animal>
        {
              new Animal {PetsId=1, PetsName="Good Boy", TypeOfAnimal="Dog", UserId=2},
              new Animal {PetsId=2, PetsName="Tindra", TypeOfAnimal="Dog",UserId=3},
              new Animal {PetsId=3, PetsName="MMMayuu", TypeOfAnimal="Cat", UserId=1},
        };
        public List<DayService> DayServicesList = new List<DayService>
        {
              new DayService {dsID=1,    PricePerDag=100.00, PetsId=1,InvoiceId=1},
              //new DayService {dsID=2,  DateGetIn=9/9/2222 12:00:00 AM, DateGetOut=9/9/2222 12:00:00 AM, PricePerDag=100.00, PetsId=3,InvoiceId=2},
              //new DayService {dsID=3, DateGetIn=9/9/2222 12:00:00 AM, DateGetOut=9/9/2222 12:00:00 AM, PricePerDag=100.00, PetsId=2,InvoiceId=3},
        };
    }
}
