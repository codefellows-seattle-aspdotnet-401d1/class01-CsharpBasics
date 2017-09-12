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

            for(int i = 0; i < questions.Length; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(questions[i]);
                    string response = Console.ReadLine().ToUpper();
                    if (response == answers[i])
                    {
                        if(j == 0)
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
                        else {
                            Console.WriteLine("Nope.  Heres a hint:");
                            Console.WriteLine(PrintHint(i));
                        }
                    }
                }

            }
            Console.WriteLine($"You got {firstTry} correct on your first try!");
            Console.WriteLine("Thanks for playing! Buh Bye!");
            Console.Read();
        }
    }
}
