using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public abstract class TextDecorator : IText
    {
        public IText Text { get; set; }
        public string tagSelection;
        
        //tagSelection, textInput
        public TextDecorator(IText text)
        {
            Text = text;
        }
        public string GetText()//add to previos price
        {
            return tagSelection + Text.GetText() + tagSelection;
        }


       public void  SetUserInput()
        {
             //return Text.GetText() + ", " + tagSelection  ;  
        }
    }
}
