using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   internal class Italic : TextDecorator , IItalic
    {
        public Italic(IText text) : base(text)
        {
            tagSelection = "<i>";
        }

    }
}
