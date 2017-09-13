using System;

namespace lab01_Erik
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("This is Eriks about me quiz");
            Greeting();
            int questionsRight = 0;
            questionsRight += VideoGames();
            questionsRight += MyCar(); 
            Console.WriteLine($"you got {questionsRight}/2 right");
            Console.Read();
        }    
        static int VideoGames()
        {
            Console.WriteLine("Does Erik Like VideoGames?.. (yes or no)");
            String userAnswer = Console.ReadLine();
           
            if (userAnswer == "YES" || userAnswer == "yes")
            {
               
                Console.WriteLine("good work you got it right!..");
                return 1;
            }
            else
            {
                Console.WriteLine("Nope wrong");
                return 0;
            }
        
        }
        static int MyCar()
        {
            string[] carName = new string[3] { "NISSAN", "TOYOTA", "FORD"};
            Console.WriteLine("name a car manufacturer that erik has used.");
            string userAnswer = Console.ReadLine().ToUpper();
            int answer = 0;
            foreach (string make in carName)
            {
                if(userAnswer == make)
                {
                    Console.WriteLine("nice work that is correct");
                    answer += 1; 
                }
                else
                {
                    answer += 0; 
                }
            }
            if (answer == 0)
            {
                Console.WriteLine("Sorry that was incorect!..");
            }
            return answer; 
        }
        static void Greeting()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}");
        }
        
   
    }
}
