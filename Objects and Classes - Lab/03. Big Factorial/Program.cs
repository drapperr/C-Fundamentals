using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger bigFactorial = 1;
            for (int i = 1; i <= number; i++)
            {
                bigFactorial *= i;
            }
            Console.WriteLine(bigFactorial);
        }
    }
}
