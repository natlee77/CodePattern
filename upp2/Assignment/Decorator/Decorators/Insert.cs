using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   internal class Insert : TextDecorator , IInsert
    {
        public Insert(IText text) : base(text)
        {
            tagSelection = "<ins>";
        }

    }
}
