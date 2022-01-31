using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //question 2
            Console.WriteLine("Enter length and width of your room");
            Console.WriteLine("Length:"); int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width:"); int width = Convert.ToInt32(Console.ReadLine());

            //cost of carpeting per square foot
            const int carpetingCostPerSquareFoot = 10;
            int cost = (lenght + width) * (carpetingCostPerSquareFoot);

            Console.WriteLine("Total cost : " + cost);
            






        }
    }
}
