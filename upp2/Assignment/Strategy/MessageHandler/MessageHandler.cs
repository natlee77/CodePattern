using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy 
{
   internal  class MessageHandler :IMessageHandler
    {
         
        public ISend SendText { get; set; }
        
         
        public void SendMessage(string message)
        {
            SendText.Send($"This is the text message ");
        }
    }
}
