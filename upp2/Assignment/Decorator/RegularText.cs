
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    class RegularText : IRegularText
    {    //tagSelection,
         //string textInput = Console.ReadLine();

         
        public string TextInput { get; private set; }

        public RegularText()
        {
            
            TextInput = "";
        }

        
        public string GetText()
        {
            return TextInput;
        }

        public void SetUserInput()
        {
            bool validInput = false;
            while (!validInput)
            {
                string textInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(textInput))
                {
                    validInput = true;
                    TextInput = textInput;
                }
            }
        }

       
         

    }
}
