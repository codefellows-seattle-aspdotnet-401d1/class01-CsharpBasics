using System;

namespace lab01_Erik
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("This is Eriks about me quiz");
            int questionsRight = Counter(0);
            VideoGames();
            Console.WriteLine($"you got {questionsRight}/3 right");
            Console.Read();
        }
        static int Counter(int num)
        {
            int corect = 0;
            corect += num; 
            return corect;
        }
        static void VideoGames()
        {
            Console.WriteLine("Does Erik Like VideoGames?.. (yes or no)");
            String userAnswer = Console.ReadLine();
           
            if (userAnswer == "YES" || userAnswer == "yes")
            {
               Counter(1);
                Console.WriteLine("good work you got it right!..");
            }
            else
            {
                Console.WriteLine("Nope Sorry wrong");
            }
        
        }
   
    }
}
