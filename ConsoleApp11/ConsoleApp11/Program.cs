using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            float payRate = 17.50f;
            Console.WriteLine("Enter pay rate:");

            bool option;
            do
            {
                int pay = Convert.ToInt32(Console.ReadLine());
                if (pay < 5.65 || pay > 50)
                {
                    option = false;
                    Console.WriteLine("Enter pay rate:");
                }
                else
                {
                    option = true;
                    Console.WriteLine($"correct pay: {payRate}");
                }
            } while (option == false);
        }
    }
}
