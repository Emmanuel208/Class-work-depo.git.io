using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter payment amount");

            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount < 7.50 || amount > 49.00)
            {
                Console.WriteLine("Error Message");
            }
            else
            {
                Console.WriteLine("Rate ok");
            }
        }
    }
}
