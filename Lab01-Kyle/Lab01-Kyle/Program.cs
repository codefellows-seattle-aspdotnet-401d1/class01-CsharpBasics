using System;
using System.Linq;
namespace Lab01_Kyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play A Game!");
            //QuestionOne();
            //QuestionTwo();
            CorrectAnswerTotal();
            Console.Read();
        }


        static int QuestionOne()

        {
            Console.WriteLine("What State was I born in? I am going to be nice and give you 3 guesses.");
            int AnswerCounter = 0;
            string[] CorrectAnswer = new string[] { "indiana" };

            for (int i = 0; i < 2; i++)
            {
                string response = Console.ReadLine().ToLower();
                if (CorrectAnswer.Contains(response))
                {
                    Console.WriteLine("You are Correct! I was born in Indiana.");
                    AnswerCounter++;
                    i = 2;
                }
                else if (!CorrectAnswer.Contains(response))
                {
                    Console.WriteLine("Sorry please try again!");

                }
                else if (i == 2)
                {
                    Console.WriteLine("I am sorry, you are out of guesses.");
                }
                else
                {
                    Console.WriteLine("That is not a valid response!");
                    i--;
                }

            }
            return AnswerCounter;

        }
        static int QuestionTwo()

        {
            Console.WriteLine("Do you think I like Star Trek? Yes or No");
            string[] CorrectAnswer = new string[] { "no", "n" };
            int AnswerCounter = 0;
            string response = Console.ReadLine().ToLower();
            if (CorrectAnswer.Contains(response))
            {
                Console.WriteLine("You are Correct! I am a Star Wars fan.");
                AnswerCounter++;
            }
            else
            {
                Console.WriteLine("I am sorry that is not correct. I am a Star Wars fan.");
            }

            return AnswerCounter;
        }
        static void CorrectAnswerTotal()
        {
            int correctAnswerTotal = 0;
            correctAnswerTotal += QuestionOne(); 
            correctAnswerTotal += QuestionTwo();
            Console.WriteLine($"You got {correctAnswerTotal} Correct!");
            //needed a change to commit branch
        }
    }
}