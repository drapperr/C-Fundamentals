using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMinNumber(a, b, c);
        }

        private static void GetMinNumber(int a, int b, int c)
        {
            int minNumber = int.MaxValue;
            if (a < minNumber)
            {
                minNumber = a;
            }
            if (b < minNumber)
            {
                minNumber = b;
            }
            if (c < minNumber)
            {
                minNumber = c;
            }
            Console.WriteLine(minNumber);
        }
    }
}
