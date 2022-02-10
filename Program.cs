using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int usersGuess;
            int amountOfGuesses = 0;
            do
            {
                Console.WriteLine("Guess the random number");
                usersGuess = Convert.ToInt32(Console.ReadLine());
                if (usersGuess < randomNumber)
                {
                    Console.WriteLine(" Guess is on the low side");
                }
                else if (usersGuess > randomNumber)
                {
                    Console.WriteLine(" Guess is on the high side");
                }
                else
                {
                    Console.WriteLine("correct guess, sweet in the middel");
                }
                amountOfGuesses++;

            } while (usersGuess != randomNumber);
            Console.WriteLine("You guessed {0} times :", amountOfGuesses);
            //Console.ReadLine();


        }
    }
}
