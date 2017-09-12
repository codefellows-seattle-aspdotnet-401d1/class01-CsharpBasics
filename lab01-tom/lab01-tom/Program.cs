using System;

namespace lab01_tom
{
    class Program
    {
        int[] questions = new int[4];


    static void Main(string[] args)
        {

            NameQuestion();
            Question1();
            Question2();
            //Question3();
            Console.Read();
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

        static void Question1()
        {
            Console.WriteLine("My current favorite game is Overwatch. Yes or No?");
            string game = Console.ReadLine();
            if (game == "yes" || game == "Yes")
            {
                Console.WriteLine("Yes it is. D.Va is the best!");
            }
            else
            {
                Console.WriteLine("Wrong, it is!");
            }
        }

        static void Question2()
        {
            Console.WriteLine("Out of the following, who is my favorite member of the Justice League?");
            string[] heroesArray = new string[] { "Batman", "Superman", "Wonder Woman", "The Flash"};
            foreach (string heroes in heroesArray)
            {
                Console.WriteLine(heroes);
            }
            string hero = Console.ReadLine();
            if (hero == "Batman" || hero == "batman")
            {
                Console.WriteLine("That's right!");
            }
            else
            {
                Console.WriteLine("Wrong, it's Batman!");
            }
        }

        static void Questions3()
        {

        }
    }
}
