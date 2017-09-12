using System;

namespace lab01_tom
{
    class Program
    {
        static void Main()
        {
            NameQuestion();
            Total();
            Console.Read();
        }

        static void NameQuestion()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            if (string.IsNullOrEmpty(userName.Trim()))
            {
                Console.WriteLine("Please type a name!");

                NameQuestion();
            }
            else
            {
                Console.WriteLine($"Welcome {userName}, let's play a game!");
            }
        }

        static int Question1()
        {
            Console.WriteLine("My current favorite game is Overwatch. Yes or No?");
            string game = Console.ReadLine().ToLower();
            int counter = 0;
            if (game == "yes" || game == "y")
            {
                Console.WriteLine("Yes it is. D.Va is the best!");
                counter++;
            }
            else
            {
                Console.WriteLine("Wrong, it is!");
            }
            return counter;
        }

        static int Question2()
        {
            Console.WriteLine("Out of the following, who is my favorite member of the Justice League?");
            string[] heroesArray = new string[] { "Batman", "Superman", "Wonder Woman", "The Flash"};
            int counter = 0;

            foreach (string heroes in heroesArray)
            {
                Console.WriteLine(heroes);
            }

            string hero = Console.ReadLine().ToLower();

            if (hero == "batman")
            {
                Console.WriteLine("That's right!");
                counter++;
            }
            else
            {
                Console.WriteLine("Wrong, it's Batman!");
            }
            return counter;
        }

        static int Question3()
        {
            Console.WriteLine("I drive a Jeep. Yes or No?");
            string car = Console.ReadLine().ToLower();
            int counter = 0;
            if (car == "no" || car == "n")
            {
                Console.WriteLine("Correct. I actually drive a Volkswagen.");
                counter++;
            }
            else
            {
                Console.WriteLine("No, I don't, but Jeeps are cool!");
            }
            return counter;
        }

        static int Question4()
        {
            Console.WriteLine("I have a sister. Yes or No?");
            string sister = Console.ReadLine().ToLower();
            int counter = 0;
            if (sister == "yes" || sister == "y")
            {
                Console.WriteLine("Yep, I have a younger sister.");
                counter++;
            }
            else
            {
                Console.WriteLine("I do! I have a younger sister.");
            }
            return counter;
        }

        static void Total()
        {
            int numberCorrect = Question1() + Question2() + Question3() + Question4();
            Console.WriteLine($"Thanks for playing!. You got {numberCorrect} questions correct!");
        }
    }
}   