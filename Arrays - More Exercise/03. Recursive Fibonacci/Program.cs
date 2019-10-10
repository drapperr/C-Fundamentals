using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] fibonacci = { 1, 1 };
            int[] lastFibonaci = fibonacci;
            for (int i = 3; i <= number; i++)
            {
                fibonacci = new int[i];
                for (int j = 0; j < lastFibonaci.Length; j++)
                {
                    fibonacci[j] = lastFibonaci[j];
                }
                fibonacci[fibonacci.Length - 1] = lastFibonaci[lastFibonaci.Length - 1]
                    + lastFibonaci[lastFibonaci.Length - 2];
                lastFibonaci = fibonacci;
            }
            Console.WriteLine(fibonacci[fibonacci.Length - 1]);
        }
    }
}
