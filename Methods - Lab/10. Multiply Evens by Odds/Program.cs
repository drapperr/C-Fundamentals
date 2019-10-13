using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetMultipleOfEvenAndOdds(number);

        }

        private static void GetMultipleOfEvenAndOdds(int number)
        {
            Console.WriteLine(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = Math.Abs(number % 10);
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = Math.Abs(number % 10);
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
