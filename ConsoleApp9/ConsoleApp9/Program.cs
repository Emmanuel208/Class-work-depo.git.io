using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the random Number");

            int randomNumber;

            Random random = new Random();

            randomNumber = random.Next(1, 11);

            //*note* Print to check if random number works
            Console.WriteLine($"Random number is {randomNumber}");

            
            bool option;
            do {
                Console.WriteLine("Enter number:");
                
                int guess = Convert.ToInt32(Console.ReadLine());

            
                if (guess == randomNumber)
                {
                    option = true;
                    Console.WriteLine("Correct");

                }
                else
                {
                    option = false;
                    Console.WriteLine("worng try again");
                }
            }while (option == false) ;
        }

    }
}
