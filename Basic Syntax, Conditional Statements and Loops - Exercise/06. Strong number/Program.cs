using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = number;
            int sumFactorial = 0;
            while (currentNumber != 0)
            {
                int digit = currentNumber % 10;
                int currentSum = 1;
                for (int i = 1; i <= digit; i++)
                {
                    currentSum *= i;
                }
                sumFactorial += currentSum;
                currentNumber /= 10;
            }
            if (sumFactorial == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
