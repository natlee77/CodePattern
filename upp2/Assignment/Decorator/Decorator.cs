using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator_class
    {
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
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("-------------------");
            Console.WriteLine(" Decorator");
            Console.WriteLine("-------------------");
            Console.WriteLine(" Please enter the text.");
            Console.WriteLine("-------------------");
            string textInput = Console.ReadLine();
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
            Console.WriteLine("\nType the tags you want separated by space");
            string tagSelection = Console.ReadLine();
            string result = HTMLGenerator.TagProcessor(tagSelection, textInput);
            Console.WriteLine(result);
            Console.WriteLine();

            var decor = Factory.CreateText();
            decor.SetUserInput();
            //var newdecor = decor;
            while (true)
            {
                Console.WriteLine("Add a tag style or press X for finished: ");
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine($"Decorated text: {decor.GetText()}");
                        //decor = newdecor;
                        break;
                    case 'b' or 'B':
                        Console.WriteLine("Add Bold text");
                        decor = new Bold(decor);
                        break;
                    case 'c' or 'C':
                        Console.WriteLine("Add Deleted text");
                        decor = new Deleted(decor);
                        break;
                    case 'd' or 'D':
                        Console.WriteLine("Add Emphasized text");
                        decor = new Emphasize(decor);
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Add Important text");
                        decor = new Important(decor);
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Add Inserted text");
                        decor = new Insert(decor);
                        break;

                    case 'g' or 'G':
                        Console.WriteLine("Add Italic text");
                        decor = new Italic(decor);
                        break;

                    case 'k' or 'K':
                        Console.WriteLine("Add Marked text");
                        decor = new Marked(decor);
                        break;
                    case 'l' or 'L':
                        Console.WriteLine("Add Smaller text");
                        decor = new Smaller(decor);
                        break;
                    case 'm' or 'M':
                        Console.WriteLine("Add SubScript text");
                        decor = new SubScript(decor);
                        break;

                    case 'n' or 'N':
                        Console.WriteLine("Add SuperScript text");
                        decor = new SuperScript(decor);
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