using System;

namespace about_me_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game!");
            Console.WriteLine("I'm your host Austin, and you'll be answering questions about me!");
            QuestionLoop();
        }
        static string PrintHint(int index)
        {
            string[] hints = new string[5];
            hints[0] = "Austin moved to Seattle from Honolulu.";
            hints[1] = "Austin has very little interest in Sports.";
            hints[2] = "Austin served on board the USCGC SEA DEVIL.";
            hints[3] = "It is a Wes Anderson movie starring Bill Murray.";
            hints[4] = "Did we just become best friends?";
            return hints[index];
        }
        static void QuestionLoop()
        {
            string[] questions = new string[5];
            questions[0] = "Dude, where's my car?  Enter a state.";
            questions[1] = "Am I good at basketball? Y/N.";
            questions[2] = "I served in the Military, what branch?";
            questions[3] = "My screen name - ThugLifeAquatic, is a reference to what movie?";
            questions[4] = "What's my favorite dinosaur?";

            string[] answers = new string[5];
            answers[0] = "HAWAII";
            answers[1] = "N";
            answers[2] = "COAST GUARD";
            answers[3] = "THE LIFE AQUATIC";
            answers[4] = "VELOCIRAPTOR";

            int firstTry = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(questions[i]);
                    string response = Console.ReadLine();
                    response = response.ToUpper();
                    if (response == answers[i])
                    {
                        if (j == 0)
                        {
                            firstTry++;
                        }
                        Console.WriteLine("You got it!");
                        j = 3;
                    }
                    else
                    {
                        if (j == 2)
                        {
                            Console.WriteLine("Dang! You're out of guesses.");
                        }
                        else
                        {
                            Console.WriteLine("Nope.  Heres a hint:");
                            Console.WriteLine(PrintHint(i));
                        }
                    }
                }

            }
            Console.WriteLine($"You got {firstTry} correct on your first try!");
            Console.WriteLine("OH SNAP! BONUS ROUND! Play? Y/N");
            string bonus = Console.ReadLine().ToUpper();
            if (bonus == "Y")
            {
                BonusRound(3);
            }
            else
            {
                Console.WriteLine("Thanks for playing! Buh Bye!");
                Console.Read();
            }
        }
        static void numberloop(int randNum, int trys)
        {
            int roll = randNum;
            Console.WriteLine($"Guess a number between 1 and 10. You have {trys} guesses.");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess < roll)
            {
                Console.WriteLine("To low.");
            }
            else if (guess > roll)
            {
                Console.WriteLine("To high.");
            }
            else
            {
                Console.WriteLine("Way to go! Your skills are mad!");
                return;
            }

        }
        static void BonusRound(int trys)
        {
            Console.WriteLine("Welcome to the bonus round.");
            Random rand = new Random();
            int roll = rand.Next(0, 11);
            try
            {
                for (int i = trys; i > 0; i--)
                {
                    trys = i;
                    numberloop(roll, i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}:Please enter a valid number. Press any key to continue.");
                Console.ReadLine();
                try
                {
                    for (int i = trys; i > 0; i--)
                    {
                        trys = i;
                        numberloop(roll, i);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You entered something other than a number AGAIN! The program will now crash, hope you're happy.");
                    Console.WriteLine("Please press any key to crash the program...ya jerk.");
                    Console.Read();
                    throw new Exception("User cannot follow simple directions.");
                }
            }
            finally
            {
                Console.WriteLine("Thanks for playing.  Press any key to exit.");
                Console.Read();
            }
        }
    }
}
