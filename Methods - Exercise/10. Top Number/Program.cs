using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetTopNumbers(number);
        }

        private static void GetTopNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (CheckOddDigit(i) && (SumDigit(i) % 8 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static int SumDigit(int number)
        {
            int sumDigits = 0;
            while (number != 0)
            {
                int currentDigit = number % 10;
                sumDigits += currentDigit;
                number /= 10;
            }
            return sumDigits;
        }

        private static bool CheckOddDigit(int number)
        {
            bool haveOddDigit = false;
            while (number != 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    haveOddDigit = true;
                }
                number /= 10;
            }
            return haveOddDigit;
        }
    }
}
