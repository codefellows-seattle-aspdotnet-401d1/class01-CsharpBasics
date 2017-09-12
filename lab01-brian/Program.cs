using System;
using System.Linq;
using System.Threading;

namespace lab01_brian
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please Enter a Player Name: ");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);
            Console.WriteLine();
            Console.WriteLine($"Hello {player.UserName} welcome to my game!");
            Console.Write(@"Are you ready to play?
Y/n: ");
            var readyToPlay = Console.ReadLine();
            if (!string.IsNullOrEmpty(readyToPlay))
            {
                GameStart(readyToPlay);
            }
            Console.WriteLine($"Player Score is {player.UserScore}");
            Console.WriteLine("How old do you think Brian is?");
            if (Int32.TryParse(Console.ReadLine(), out int ageInput))
            {
                AgeInput ageGuess = new AgeInput(Convert.ToInt32(ageInput));
                if (ageGuess.Age == 34)
                {
                    Console.WriteLine("Great job, you guessed it!");
                    player.UserScore++;
                    Thread.Sleep(1000);
                    Console.WriteLine("Next Question!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($@"Looks like you guessed {ageGuess.Difference(ageInput)} years off.
Better Luck next time");
                    Thread.Sleep(1000);
                    Console.WriteLine("Next Question!");
                    Thread.Sleep(1000);
                    Console.Clear();

                }
            }
            string[] CountriesVisited = new[]
                {"thailand", "sweeden", "neatherlands", "greece", "united kingdom", "italy", "canada", "mexico"};
            for ( int attempts = 5; attempts > 0; attempts--)
            {
                Console.WriteLine($"Player Score is {player.UserScore}");
                Console.WriteLine($"You have {attempts} attempts to guess which countries i've visited");
                Console.Write("Enter a country name: ");
                var userInput = Console.ReadLine();
                if (CountriesVisited.Contains(userInput.ToLower().Trim()))
                {
                    Console.WriteLine($"Great guess! I have visited {userInput}");
                    player.UserScore++;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Sorry I've never been to {userInput}");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        static void GameStart(string yesOrNo)
        {
            var answer = yesOrNo.Trim().ToLower();
            if (answer == "y" || answer == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Rad, Let's Play!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Sad Day ... you suck!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}
