using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wlecome to the lawn mowing service company");
            Console.WriteLine("Please enter the length and width of your lawn");
            Console.WriteLine();
            Console.WriteLine("length:");

            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("width:");
            int width = Convert.ToInt32(Console.ReadLine());

            const int weeklyFeeUnder400 = 25;
            const int weeklyFee400_600 = 35;
            const int weeklyFee600Above = 50;

            int sizeOfLawn = length * width;

            if (sizeOfLawn < 400)
            {
                Console.WriteLine($"weekly amount due is : ${weeklyFeeUnder400}");
                Console.WriteLine($"Total fee for season is : ${weeklyFeeUnder400 * 20 }");

            }else if (sizeOfLawn > 400 && sizeOfLawn <= 600)
            {
                Console.WriteLine($"weekly amount due is : ${weeklyFee400_600}");
                Console.WriteLine($"Total fee for season is : ${weeklyFee400_600 * 20 }");

            }else if (sizeOfLawn > 600)
            {
                Console.WriteLine($"weekly amount due is : ${weeklyFee600Above}");
                Console.WriteLine($"Total fee for season is : ${weeklyFee600Above * 20 }");

            }
            else
            {
                Console.WriteLine("Bad input");
            }
        }
    }
}
