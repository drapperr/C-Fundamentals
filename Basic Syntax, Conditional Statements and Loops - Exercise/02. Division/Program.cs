using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //2, 3, 6, 7, 10
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            if (number % 10 == 0)
            {
                result = 10;
            }
            else if (number % 7 == 0)
            {
                result = 7;
            }
            else if (number % 6 == 0)
            {
                result = 6;
            }
            else if (number % 3 == 0)
            {
                result = 3;
            }
            else if (number % 2 == 0)
            {
                result = 2;
            }
            if (result == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {result}");
            }
        }
    }
}
