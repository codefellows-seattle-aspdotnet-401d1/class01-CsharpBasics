using System;
namespace lab01_ken
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Kenneth's About Me Quiz");
            Console.WriteLine("Ready for the first question? Press Enter!");
            Console.Read();
            Question1();
            Console.WriteLine("Here's Question number 2");
            Console.Read();
            Question2();
            Console.WriteLine("Here's your next question");
            Console.Read();
            Question3();
            Console.WriteLine("Here's your last question");
            Console.Read();
            Question4();
        }

        static void Question1()
        {
            Console.WriteLine("What state is Kenneth orginally from?, two letters only please");
            Console.Read();
            string state = Console.ReadLine().ToUpper();

            Console.WriteLine($"You guessed {state}");


            if (state == "FL")
            {
                Console.WriteLine("That's correct! Press enter to go to the next question");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Sorry, I'm from Florida");   
                Console.Read();
            }
        }
        static void Question2()
        {
            Console.WriteLine("What branch of the military did Ken serve?");
            string branch = Console.ReadLine().ToUpper();
            Console.WriteLine($"You guessed {branch}");

            if(branch == "ARMY")
            {
                Console.WriteLine("That's correct! Press enter to go to the next question");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Nope, I was in the Army.");
                Console.Read();
            }
        }
        static void Question3()
        {
            Console.WriteLine("I was just on vacation. Name one of the four countries I visted");
            string country = Console.ReadLine().ToUpper();
            Console.WriteLine($"You guessed {country}");

            if (country == "GERMANY" || country == "ISRAEL" || country == "PALESTINE" || country == "ROMANIA")
            {
                Console.WriteLine("That's correct!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Incorrect. I went to Germany, Israel, Palestine, and Romania");
                Console.Read();
            }
        }
        static int Question4()
        {
            try
            {
                Console.WriteLine("How old is Kenneth?");
                Console.Read();
                string myage = Console.ReadLine();
                int age = Convert.ToInt32(myage);
                Console.WriteLine($"You guessed {age}");
               
                if(age == 38)
                {
                    Console.WriteLine("That's correct! Press Enter to exit the game.");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Wrong, I'm 38. Press Enter to exit the game." );
                    Console.Read();
                }
                //because you declare an int in the method, you have to return an int in the code block
                return age;
            }catch(FormatException fe)
            {
                Console.WriteLine("You didn't input a number.");
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Ok, this is the finally block");
            }
            return 0;

            
        }
    }
}
