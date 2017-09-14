using System;
namespace lab01_ken
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Kenneth's About Me Quiz");
            Console.WriteLine("Ready for the first question? Press Enter!");
            Console.Read();
            Question1();
            Console.WriteLine("Here's Question number 2");
            Console.Read();
            Question2();
            Console.WriteLine("Here's your last question");
            Console.Read();
            Question3();
        }

        static void Question1()
        {
            Console.WriteLine("What state is Kenneth orginally from?, two letters only please");
            Console.Read();
            string state = Console.ReadLine().ToUpper();

            Console.WriteLine($"You guessed {state}");


            if (state == "FL")
            {
                Console.WriteLine("That's correct! Press enter to go to the next question");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Sorry, I'm from Florida");   
                Console.Read();
            }
        }
        static void Question2()
        {
            Console.WriteLine("What branch of the military did Ken serve?");
            string branch = Console.ReadLine().ToUpper();
            Console.WriteLine($"You guessed {branch}");

            if(branch == "ARMY")
            {
                Console.WriteLine("That's correct! Press enter to go to the next question");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Nope, I was in the Army.");
                Console.Read();
            }
        }
        static void Question3()
        {
            Console.WriteLine("I was just on vacation. Name one of the four countries I visted");
            string country = Console.ReadLine().ToUpper();
            Console.WriteLine($"You guessed {country}");

            if (country == "GERMANY" || country == "ISRAEL" || country == "PALESTINE" || country == "ROMANIA")
            {
                Console.WriteLine("That's correct!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Incorrect. I went to Germany, Israel, Palestine, and Romania");
                Console.Read();
            }
        }
    }
}
