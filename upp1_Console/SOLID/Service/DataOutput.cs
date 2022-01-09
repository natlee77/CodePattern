using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Service 
{
    internal class DataOutput
    {
        internal static void ToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}