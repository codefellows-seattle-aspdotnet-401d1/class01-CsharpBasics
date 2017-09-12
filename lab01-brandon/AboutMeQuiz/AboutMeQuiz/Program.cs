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
            int correctAnswersTotal = 0;

            if (response == "y" || response == "yes")
            {
                Console.WriteLine("Great! Let's get started:");
            }
            else if (response == "n" || response == "no")
            {
                Console.WriteLine("Too bad, we're doing it anyway!");
            }

            Console.WriteLine("Was I born in Washington?");
            correctAnswersTotal += QuizOne(Console.ReadLine().ToLower());

            Console.WriteLine("What is one of my favorite colors? (There are several possible answers, so I will give you 3 tries!)");
            correctAnswersTotal += QuizTwo(Console.ReadLine().ToLower());

            Console.WriteLine("Do I like cats?");
            correctAnswersTotal += QuizThree(Console.ReadLine().ToLower());

            Console.WriteLine("Am I over 30?");
            correctAnswersTotal += QuizFour(Console.ReadLine().ToLower());

            Console.WriteLine($"You got {correctAnswersTotal} question(s) correct!");
            Console.Read();
        }

        static int QuizOne(string response)
        {
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
                QuizOne(Console.ReadLine().ToLower());
            }

            return accumulator;
        }

        static int QuizTwo(string response)
        {
            int accumulator = 0;
            string[] answers = new string[] { "blue", "green", "purple", "red", "black" };

            for (int i = 3; i > 0; i--)
            {
                if (answers.Contains(response))
                {
                    Console.WriteLine($"Correct! The color {response} is one of my favorite colors!");
                    i = 3;
                    accumulator++;
                }
                else if (!answers.Contains(response))
                {
                    if ((i - 1) > 0)
                    {
                        Console.WriteLine($"Sorry, try again! You have {i - 1} tries left.");
                        response = Console.ReadLine().ToLower(); 
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is wrong and you are out of tries!");
                    }
                }
                else
                {
                    Console.WriteLine("I didn't understand your response, please try again.");
                    response = Console.ReadLine().ToLower();
                    i++;
                } 
            }

            return accumulator;
        }

        static int QuizThree(string response)
        {
            int accumulator = 0;

            if (response == "y" || response == "yes")
            {
                Console.WriteLine("I do! I also like dogs, but cats are my favorite.");
                accumulator++;
            }
            else if (response == "n" || response == "no")
            {
                Console.WriteLine("Incorrect! I'm a big fan.");
            }
            else
            {
                Console.WriteLine("I didn't understand your response, please try again.");
                QuizOne(Console.ReadLine().ToLower());
            }

            return accumulator;
        }

        static int QuizFour(string response)
        {
            int accumulator = 0;

            if (response == "y" || response == "yes")
            {
                Console.WriteLine("Yes! I am 31.");
                accumulator++;
            }
            else if (response == "n" || response == "no")
            {
                Console.WriteLine("Thanks, but I am actually 31!");
            }
            else
            {
                Console.WriteLine("I didn't understand your response, please try again.");
                QuizOne(Console.ReadLine().ToLower());
            }

            return accumulator;
        }
    }
}
