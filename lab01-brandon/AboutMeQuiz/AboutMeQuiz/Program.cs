using System;

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

            int correctAnswersTotal = QuizOne();

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
    }
}
