using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_Cameron
{
    class Program
    {

        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Enter Name to Start: ");
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Enter Name or Exit Game!");
            }
            else
            {
                Console.WriteLine($"Welcome {userInput}");
            }
            total += Places();
            total += Cars();
            Console.WriteLine($"total score: {total}");
            Console.ReadLine();
        }
        static int Places()
        {
            Console.WriteLine("Which ONE of these places as Cameron NOT lived: ");
            string[] placeArray = new string[] { "a- TX", "b- WA", "c- MS", "d- OK", "e- OR", "f- KY" };
            foreach (string place in placeArray)
            {
                Console.WriteLine(place);
            }
            string answerOne = Console.ReadLine();
            if (answerOne == "d")
            {
                Console.WriteLine("Correct!");
                return 1;
            }
            else
            {
                Console.WriteLine("Wrong Answer, next question.");
                return 0;

            }

        }
        static int Cars()
        {
            Console.WriteLine("What is the 3rd vehicle Cameron Owned?");
            string[] carArray = new string[] { "a- Monte Carlo", "b- Malibu", "c- Grand Prix", "d- Passat", "e-Fiesta" };
            foreach (string car in carArray)
            {
                Console.WriteLine(car);
            }
            string answerTwo = Console.ReadLine();
            if (answerTwo == "c")
            {
                Console.WriteLine("Correct!");
                return 1;
            }
            else
            {
                Console.WriteLine("Maybe Next time! Goodbye");
                return 0;

            }
        }
    }
}

