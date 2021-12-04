using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        // Skriv en adapter för ReturningStrings--string  som kan konsumeras av PrintingInts--int 
        
        // OBS TRASIG KOD - TA BORT NÄR DU BÖRJAR KODA
        // Det jag vill göra men inte kan är
        //ReturningStrings returningStrings = new ReturningStrings();
        //PrintingInts printingInts = new();
        //printingInts.Print(returningStrings.ReturnString());
        public void Run()
        {
            IServer printServer = new  Server(); 
            printServer.Print( );
             

            //Console.Read();
        }
    }
}
