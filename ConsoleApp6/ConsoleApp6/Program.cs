using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 3
            Console.WriteLine("Enter a total amount of time in minUTES");

            var totalMinutes = Convert.ToDouble(Console.ReadLine());
            var time = TimeSpan.FromMinutes(totalMinutes);
            Console.WriteLine("{0:00}:{1:00}", (int)time.TotalHours, time.Minutes);
        }
    }
}
