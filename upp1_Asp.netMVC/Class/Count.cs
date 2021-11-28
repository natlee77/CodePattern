using System;
using System.Runtime.Serialization;

namespace SOLID.Models
{
     
    public class Count : Exception
    {


        public   Count(int Item, double PricePerItem)
        {
            double v = (Item * PricePerItem);
            //return v;
        }
    }
}