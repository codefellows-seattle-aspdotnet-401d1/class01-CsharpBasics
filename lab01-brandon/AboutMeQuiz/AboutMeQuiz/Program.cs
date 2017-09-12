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
        }
    }
}
