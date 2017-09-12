using System;
namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm 30 years old, how many months have I been alive for? ");
            bool playing = true;
            while (playing) // When playing = false, program will stop
            {
                int theAge = GetInput();
                AboutMe(theAge);
                Console.WriteLine("Would you like to try again? (type y for Yes or n for No)");
                playing = Question();
            }

            Console.WriteLine("Thanks for playing. Press any key to exit.");
            Console.Read();
        }

        static void AboutMe(int z) // int z is the user's guess of my months old
        {
            int numberCorrect = 0;
            if (z == 360)
            {
                numberCorrect++;
            }
            Console.WriteLine("Do you know my first name? Please enter it: ");
            string nameGuess = Console.ReadLine();
            if (nameGuess == "Adam" || nameGuess == "adam" || nameGuess == "ADAM")
            {
                numberCorrect++;
            }
            Console.WriteLine("Am I currently taking 401, 301, or 801? Please enter it: ");

            string courseGuess = Console.ReadLine();
            if (courseGuess == "401")
            {
                numberCorrect++;
            }
            Console.WriteLine($"Ok. We're done. You got {numberCorrect} question(s) correct.");
        }

        static int GetInput() // This will check to see if user input is an int
        {
            bool badInput = true;
            while (badInput)
            {
                string y = Console.ReadLine();
                if (int.TryParse(y, out int z))
                {
                    badInput = false;
                    return z;
                }
                else
                {
                    Console.WriteLine("Your response must be a whole number. Try entering the number again: ");
                }
            }
            return 0;
        }

        static bool Question() // Will return true if user wants to play again, false otherwise
        {
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}