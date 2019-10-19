using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        private static void PrintMatrix(int n)
        {
            for (int row = 0; row < n; row++)
            {
                PrntCols(n);
                Console.WriteLine();
            }
        }

        private static void PrntCols(int n)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
