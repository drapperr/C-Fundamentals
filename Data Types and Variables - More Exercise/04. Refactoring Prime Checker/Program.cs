using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", i);
                }
                else
                {
                    Console.WriteLine("{0} -> false", i);
                }
            }

        }
    }
}
