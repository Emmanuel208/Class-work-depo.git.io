using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[51];
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
                
                sum += i ;
                Console.WriteLine("Sum is {0}", sum);
                
               
            }

           
        }
    }
}
