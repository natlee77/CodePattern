using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   internal class Important : TextDecorator , IImportant
    {
        public Important(IText text) : base(text)
        {
            tagSelection = "<strong>";
        }

    }
}
