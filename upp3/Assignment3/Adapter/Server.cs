using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
   public class Server :IServer
    {
       private  ReturningStrings ReturningStrings { get; set; }
       private PrintingInts PrintingInts { get; set; }
        public Server()
        {
            ReturningStrings = new ReturningStrings();
            PrintingInts = new PrintingInts();
        }         

        public void Print()
        {
            PrintingInts.Print(int.Parse(ReturningStrings.ReturnString()));
        }
    }
}
