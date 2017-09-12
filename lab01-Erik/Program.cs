using System;

namespace lab01_Erik
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("This is Eriks about me quiz");
            int questionsRight = 0;
            questionsRight += VideoGames();
            bool car = true;
            while (car)
            {
                MyCar();
                if (MyCar() == 1)
                {
                    car = false;
                }
            }
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
                Console.WriteLine("Nope Sorry wrong");
                return 0;
            }
        
        }
        static int MyCar()
        {
            string[] carName = new string[3] { "NISSAN", "TOYOTA", "FORD"};
            Console.WriteLine("What company made Erik's car?");
            string userAnswer = Console.ReadLine().ToUpper();
            int answer = 0;
            foreach (string make in carName)
            {
                if(userAnswer == make)
                {
                    Console.WriteLine("nice work that is correct");
                    answer = 1; 
                }
                else
                {
                    Console.WriteLine("sorry try again");
                    answer = 0; 
                }
            }
            return answer; 
        }
   
    }
}
