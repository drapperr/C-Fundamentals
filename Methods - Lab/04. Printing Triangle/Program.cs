using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintFirstPart(number);
            PrintSecondPart(number);
        }

        private static void PrintFirstPart(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }
        }

        private static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
        }

        private static void PrintSecondPart(int number)
        {
            for (int i = number - 1; i > 0; i--)
            {
                PrintLine(i);
                Console.WriteLine();
            }
        }
    }
}
