using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while ((num = int.Parse(Console.ReadLine())) % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
            }
            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
    }
}
