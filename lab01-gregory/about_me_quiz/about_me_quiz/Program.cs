using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game about me!");
            Console.WriteLine("First, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Thank you {userName}, let's begin.");
            Console.Read();
            CityBorn();
            KillForPizza();
            NumberOfToppings();
            TypeOfToppings();
            EndOfGame();
            //Total();

        }

        static int CityBorn()
        {
            Console.WriteLine("Was I born in Washington?");
            Console.Read();
            int counter = 0;
            string city = Console.ReadLine().ToLower();
            //Console.Read();

            if (city == "yes" || city == "y")
            {
                Console.WriteLine("Nope!  I was born in Colorado! In Denver.");

                Console.Read();

            }
            else if (city == "no" || city == "n")
            {
                Console.WriteLine("Correct! I was born in Denver, Colorado.");
                Console.Read();
                counter++;
            }
            else
            {
                Console.WriteLine("Please answer with 'yes' or 'no'.");
                CityBorn();
            }
            return counter;
        }

        static void KillForPizza()
        {
            Console.WriteLine("Would I kill for some pizza?");
            Console.Read();
            //int counter;
            string kill = Console.ReadLine().ToLower();
            //Console.Read();

            if (kill == "yes" || kill == "y")
            {
                Console.WriteLine("Um, no, murder is illigal! But I really do want some pizza right now.");
                Console.Read();

            }
            else if (kill == "no" || kill == "n")
            {
                Console.WriteLine("Right, because murder is illigal, but I really do want some pizza right now.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Please answer with 'yes' or 'no'.");
                KillForPizza();
            }
        }

        static void NumberOfToppings()
        {
            int guesses = 5;
            do
            {
                try
                {
                    Console.WriteLine("How many toppings do I prefer on my pizza?");
                    Console.WriteLine($"You have {guesses} guesses.");

                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 4)
                    {
                        Console.WriteLine("Great guess!  4 toppings is perfect for maximum yummage!");
                        break;
                    }
                    if (userInput > 4)
                    {
                        Console.WriteLine("Slow down High Speed, don't overload the pie!  Try agian.");
                        guesses--;
                    }
                    if (userInput < 4)
                    {
                        Console.WriteLine("That pie is almost naked!  More please.");
                        guesses--;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number./Format Exception");
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number. /Exception Exception");
                }
            }
            while (guesses > 0);
            if (guesses == 0)
            {
                Console.WriteLine("Sorry, you are out of guesses. I think 4 toppings is perfect for maximum yummage!");
                Console.Read();
            }
        }

        static void TypeOfToppings()
        {
            List<string> toppings = new List<string>();
            toppings.Add("pepperoni");
            toppings.Add("sausage");
            toppings.Add("jalepeno");
            toppings.Add("cheese");

            Console.WriteLine("What toppings do I prefer on my pizza?");
            string toppingGuess = Console.ReadLine().ToLower();

            if (toppings.Contains(toppingGuess))
            {
                Console.WriteLine($"Great Guess, {toppingGuess} makes pizza delicious!");
                Console.Read();
            }else
            {
                Console.WriteLine("Eww, gross.  That is NOT what I want on my pie.");
                Console.Read();

            }

        }
        static void EndOfGame()
        {

            Console.WriteLine($"Game Over. Thanks for playing!");
            Console.WriteLine("Would you like to play agian?");
            string doesntMatter = Console.ReadLine();
            Console.WriteLine($"User Response: '{doesntMatter}' is invalid.");
            Console.WriteLine("The system will now exit.");
            Console.Read();
        if (doesntMatter == null)
            {
                throw new System.ArgumentException("The system will now exit.");

            }


        }



        //static void Total()
        //{
        //    int total = CityBorn() + NumberOfToppings() + KillForPizza();
        //    Console.WriteLine($"You got {total} questions right!");
        //}
    }
}
