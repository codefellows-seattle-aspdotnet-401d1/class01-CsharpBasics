using System;
using System.Linq;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            MainQuizHandler();
        }

        static void MainQuizHandler()
        {
            Console.WriteLine("Hello! My name is Brandon. Would you like to take a quiz about me?");
            string response = Console.ReadLine().ToLower();

            if (response == "y" || response == "yes")
            {
                Console.WriteLine("Great! Let's get started:");
            }
            else if (response == "n" || response == "no")
            {
                Console.WriteLine("Too bad, we're doing it anyway!");
            }

            int correctAnswersTotal = QuizOne() + QuizTwo();

            Console.WriteLine($"You got {correctAnswersTotal} questions correct!");
            Console.Read();
        }

        static int QuizOne()
        {
            Console.WriteLine("Was I born in Washington?");
            string response = Console.ReadLine().ToLower();
            int accumulator = 0;

            if (response == "y" || response == "yes")
            {
                Console.WriteLine("Wrong! I was born in Arizona.");
            }
            else if (response == "n" || response == "no")
            {
                Console.WriteLine("Correct! I was born in Arizona.");
                accumulator++;
            }
            else
            {
                Console.WriteLine("I didn't understand your response, please try again.");
                QuizOne();
            }

            return accumulator;
        }

        static int QuizTwo()
        {
            Console.WriteLine("What is one of my favorite colors? (There are several possible answers, so I will give you 3 tries!)");
            int accumulator = 0;
            string[] answers = new string[] { "blue", "green", "purple", "red", "black" };

            for (int i = 0; i < 4; i++)
            {
                string response = Console.ReadLine().ToLower();
                if (answers.Contains(response))
                {
                    Console.WriteLine($"Correct! The color {response} is one of my favorite colors!");
                    i = 4;
                    accumulator++;
                }
                else if (!answers.Contains(response))
                {
                    Console.WriteLine("Sorry, try again!");
                }
                else
                {
                    Console.WriteLine("I didn't understand your response, please try again.");
                    i--;
                } 
            }

            return accumulator;
        }
    }
}
