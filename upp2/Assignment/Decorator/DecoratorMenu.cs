using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using System;

namespace Design_Patterns_Assignment
{
    internal class DecoratorMenu
    {
      
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("-------------------");
            Console.WriteLine(" Decorator");
            Console.WriteLine("-------------------");
            Console.WriteLine(" Please enter the text.");
            Console.WriteLine("-------------------");      
            Console.WriteLine(" Decorate your text. Select en TagStyle");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("A: Show");
            Console.WriteLine("B: Bold");
            Console.WriteLine("C: Deleted");
            Console.WriteLine("D: Emphasized");
            Console.WriteLine("E: Important");
            Console.WriteLine("F: Inserted");
            Console.WriteLine("G: Italic");
            Console.WriteLine("K: Marked");
            Console.WriteLine("L: Smaller");
            Console.WriteLine("M: SubScript");
            Console.WriteLine("N: SuperScript");
            Console.WriteLine("X: Exit");

            Console.WriteLine("\nType your text  : \n");
            
            
             

            var decorator = Factory.CreateText();
            decorator.SetUserInput();
            //var newdecor = decor;
            while (true)
            {
                Console.WriteLine("Add a tag style or press A to show  , X to Exit: \n");
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine($"Decorated text: {decorator.GetText()}");
                        //decor = newdecor;
                        break;
                    case 'b' or 'B':
                        Console.WriteLine("Add Bold text");
                        decorator = new Bold(decorator);
                        break;
                    case 'c' or 'C':
                        Console.WriteLine("Add Deleted text");
                        decorator = new Deleted(decorator);
                        break;
                    case 'd' or 'D':
                        Console.WriteLine("Add Emphasized text");
                        decorator = new Emphasize(decorator);
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Add Important text");
                        decorator = new Important(decorator);
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Add Inserted text");
                        decorator = new Insert(decorator);
                        break;

                    case 'g' or 'G':
                        Console.WriteLine("Add Italic text");
                        decorator = new Italic(decorator);
                        break;

                    case 'k' or 'K':
                        Console.WriteLine("Add Marked text");
                        decorator = new Marked(decorator);
                        break;
                    case 'l' or 'L':
                        Console.WriteLine("Add Smaller text");
                        decorator = new Smaller(decorator);
                        break;
                    case 'm' or 'M':
                        Console.WriteLine("Add SubScript text");
                        decorator = new SubScript(decorator);
                        break;

                    case 'n' or 'N':
                        Console.WriteLine("Add SuperScript text");
                        decorator = new SuperScript(decorator);
                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}
// Refactor this code so that it uses the Decorator Pattern
//Console.WriteLine("Decorator");
//Console.WriteLine("Please enter the text.");
//string textInput = Console.ReadLine();
//Console.WriteLine();
//Console.WriteLine("Bold");
//Console.WriteLine("Deleted");
//Console.WriteLine("Emphasized");
//Console.WriteLine("Important");
//Console.WriteLine("Inserted");
//Console.WriteLine("Italic");
//Console.WriteLine("Marked");
//Console.WriteLine("Smaller");
//Console.WriteLine("SubScript");
//Console.WriteLine("SuperScript");
//Console.WriteLine();
//Console.WriteLine("Type the tags you want separated by space");
//string tagSelection = Console.ReadLine();
//string result = HTMLGenerator.TagProcessor(tagSelection, textInput);
//Console.WriteLine(result);
//Console.WriteLine();