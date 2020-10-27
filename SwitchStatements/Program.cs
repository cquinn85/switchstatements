using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is the worst!");
                    break;
                default:
                    Console.WriteLine("Math is far to complicated.");
                    break;
                case "science":
                    Console.WriteLine("Science is the key to life.");
                    break;
                case "history":
                    Console.WriteLine("History is absolutely the best!");
                    break;
                case "english":
                    Console.WriteLine("English can pretty boring and complicated.");
                    break;
                case "reading":
                    Console.WriteLine("A way to get lost in another world!");
                    break;

            }
        }
    }
}
