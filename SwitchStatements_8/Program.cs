using System;

namespace SwitchStatements_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine().ToLower();


            switch (subject)
            {
                case "biology":
                    Console.WriteLine("Your Favorite course is {0}! Mine too!", subject);
                    break;
                case "math":
                    Console.WriteLine("Your Favorite course is {0}! Mine too!", subject);
                    break;
                case "english":
                    Console.WriteLine("Your Favorite course is {0}! Mine too!", subject);
                    break;
                case "art":
                    Console.WriteLine("Your Favorite course is {0}! Mine too!", subject);
                    break;
                case "music":
                    Console.WriteLine("Your Favorite course is {0}! Mine too!", subject);
                    break;
                default:
                    Console.WriteLine("Oh wow! I haven't taken that subject before. {0} sounds fun.", subject);
                    break;
            }
        }
    }
}
