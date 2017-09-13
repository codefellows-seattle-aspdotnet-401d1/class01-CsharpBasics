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
            string readyToPlay = Console.ReadLine();
            if (!string.IsNullOrEmpty(readyToPlay.Trim()))
            {
                GameStart(readyToPlay);
            }
            Console.WriteLine($"Player Score is {player.UserScore}");
            Console.WriteLine("How old do you think Brian is?");
            AgeGuess();
            if (AgeGuess())
            {
                player.UserScore++;
            }
            string[] CountriesVisited = new[]
                {"thailand", "sweden", "netherlands", "greece", "united kingdom", "italy", "canada", "mexico"};
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

        public static bool AgeGuess()
        {
            try
            {
                string ageGuess = Console.ReadLine();
                AgeInput usersInput = new AgeInput(Convert.ToInt32(ageGuess));
                if (usersInput.Age == 34)
                {
                    Console.WriteLine("Great job, you guessed it!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Next Question!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    return true;
                }
                else
                {
                    Console.WriteLine($@"Looks like you guessed {usersInput.Difference(Convert.ToInt32(ageGuess))} years off.
Better Luck next time");
                    Thread.Sleep(2000);
                    Console.WriteLine("Next Question!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    return false;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e.GetType().Name}: A non interger vale was entered when an interger vale was expected. Try again...");
                AgeGuess();
            }
            catch (Exception)
            {
                throw new Exception("An Unknown execption has occured. Please notify your system admit...");
            }
            finally
            {
                Console.WriteLine("Let's contineu shall we?");
            }
            return false;
        }
    }
}
