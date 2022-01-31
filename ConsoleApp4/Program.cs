using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Simple Calculator
            
            Console.WriteLine("What type of calculation would you like to prefrom");
            Console.WriteLine("(1)Addition");
            Console.WriteLine("(2)Subtraction");
            Console.WriteLine("(3)Multiplication");
            Console.WriteLine("(4)Division");

            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Enter two numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                int result = number1 + number2;

                Console.WriteLine($"{number1} + {number2} = {result}");

            }else if (option == "2")
            {
                Console.WriteLine("Enter two numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                int result = number1 - number2;

                Console.WriteLine($"{number1} - {number2} = {result}");

            }
            else if (option == "3")
            {
                Console.WriteLine("Enter two numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                int result = number1 * number2;

                Console.WriteLine($"{number1} * {number2} = {result}");

            }
            else if (option == "4")
            {
                Console.WriteLine("Enter two numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                double result = (number1) / (number2);

                Console.WriteLine($"{number1} / {number2} = {result}");
            }
            else
            {
                Console.WriteLine("Wrong entry try again ");
            }






        }
    }
}
