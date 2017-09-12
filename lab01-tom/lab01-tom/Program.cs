using System;

namespace lab01_tom
{
    class Program
    {
        static void Main(string[] args)
        {
            NameQuestion();
            IterationStatements();
            Console.Read();
        }

        static void IterationStatements()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
            }

            int[] numberArray = new int[] { 72, 42, 21, 38 };
            foreach (int number in numberArray)
            {
                Console.WriteLine(number);
            }

            int z = 0;
            while (z < 10)
            {
                Console.WriteLine(z);
                z++;
            }

            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n < 5);
        }

        static void NameQuestion()
        {
            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput.Trim()))
            {
                Console.WriteLine("Please type a name!");

                NameQuestion();
            }
            else
            {
                Console.WriteLine($"Welcome {userInput}, let's play a game!");
            }
        }
    }
}
