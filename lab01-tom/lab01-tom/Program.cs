using System;

namespace lab01_tom
{
    class Program
    {
        static void Main(string[] args)
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
            else if (game == "no" || game == "n")
            {
                Console.WriteLine("Wrong, it is!");
            }
            else
            {
                Console.WriteLine("Please answer yes or no");
            }
            return counter;
        }

        static int Question2()
        {
            Console.WriteLine("Out of the following, who is my favorite member of the Justice League?");
            string[] heroesArray = new string[] { "Batman", "Superman", "Wonder Woman", "The Flash" };
            int counter = 0;

            foreach (string heroes in heroesArray)
            {
                Console.WriteLine(heroes);
            }

            string hero = Console.ReadLine().ToLower();

            ////////////////////////////////////////////////CLASS 02 LAB////////////////////////////////////////////////////////////////
            try
            {
                if (hero == "batman")
                {
                    Console.WriteLine("That's right!");
                    counter++;
                }
                else if (hero != "batman" && hero != "superman" && hero != "wonder woman" && hero != "the flash")
                {
                    throw new Exception();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("That...that wasn't even an option", e);
            }
            finally
            {
                if (hero != "batman")
                {
                    Console.WriteLine("My favorite is Batman!");
                }
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
            else if (car == "yes" || car == "y")
            {
                Console.WriteLine("No, I don't, but Jeeps are cool!");
            }
            else
            {
                Console.WriteLine("Please answer yes or no");
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
            else if (sister == "no" || sister == "n")
            {
                Console.WriteLine("I do! I have a younger sister.");
            }
            else
            {
                Console.WriteLine("Please answer yes or no");
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