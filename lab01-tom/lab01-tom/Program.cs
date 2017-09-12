using System;

namespace lab01_tom
{
    class Program
    {
        //int[] questions = new int[0];

        static void Main()
        {
            NameQuestion();
            Question1();
            Question2();
            Question3();
            Question4();
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

        static void Question3()
        {
            Console.WriteLine("I drive a Jeep. Yes or No?");
            string car = Console.ReadLine();
            if (car == "No" || car == "no")
            {
                Console.WriteLine("Correct. I actually drive a Volkswagen.");
            }
            else
            {
                Console.WriteLine("No, I don't, but Jeeps are cool!");
            }
        }

        static void Question4()
        {
            Console.WriteLine("I have a sister. Yes or No?");
            string sister = Console.ReadLine();
            if (sister == "Yes" || sister == "yes")
            {
                Console.WriteLine("Yep, I have a younger sister.");
            }
            else
            {
                Console.WriteLine("I do! I have a younger sister.");
            }
        }

        static void Total()
        {
            //int numberCorrect = questions.Length;
            //Console.WriteLine($"Thanks for playing! You got {numberCorrect} questions correct.");
        }
    }
}   
