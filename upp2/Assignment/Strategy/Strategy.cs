using Design_Patterns_Assignment.Strategy;
 
using System;

namespace Design_Patterns_Assignment
{
    /* What i want to happen to happen is    
             - Change type of message to send to sms etc.
             - send message */

    internal class Strategy_class 
    {
        // Refactor this code so that it uses the strategy Pattern
        //MessageHandler.SendEmail(message);
        //MessageHandler.SendSMS(message);
        //MessageHandler.SendFacebookMessage(message);
        internal static void Run()        {
            

            //Text Text = new Text();  
            MessageHandler MessageHandler = new MessageHandler();
            FacebookMessage FacebookMessage = new FacebookMessage();
            Email Email = new Email();
            SMS SMS = new SMS();

            Console.WriteLine("Strategy");
            var message = "This is the message";    

            //Menu
                Console.WriteLine(" Strategy . MessageHandler.");
                Console.WriteLine("---------------------");
                Console.WriteLine("  Select an action   ");
                Console.WriteLine("---------------------");          
          
                Console.WriteLine(" F: to send message by Email");
                Console.WriteLine(" W: to send message by SMS");
                Console.WriteLine(" C: to send message by FacebookMessage");
                Console.WriteLine(" Q: to Quit Program");
                Console.WriteLine("---------------------");

            //Main Game Loop
            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                     
                     
                    case 'f' or 'F':
                        ClearRow();
                        Console.WriteLine("\n by Email press SEND");
                        MessageHandler.SendText = Email;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'w' or 'W':
                        ClearRow();
                        Console.WriteLine("\n by SMS press SEND");
                        MessageHandler.SendText = SMS;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'c' or 'C':
                        ClearRow();
                        Console.WriteLine("\n by FacebookMessage press SEND");
                        MessageHandler.SendText=FacebookMessage;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'q' or 'Q':
                        ClearRow();
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        ClearRow();
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }

        private static void ClearRow()
        {
            // Set cursor below the menu
            Console.SetCursorPosition(1, 9);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }

    }
}
 