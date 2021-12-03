using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   internal class Emphasize : TextDecorator , IEmphasize
    {
        public Emphasize(IText text) : base(text)
        {
            tagSelection = "<em>";
        }

    }
}
