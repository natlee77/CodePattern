using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   internal class SubScript : TextDecorator , ISubScript
    {
        public SubScript(IText text) : base(text)
        {
            tagSelection = "<sub>";
        }

    }
}
