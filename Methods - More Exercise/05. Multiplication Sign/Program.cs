using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int zeroCounter = 0;
            int negativeCounter = 0;
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                zeroCounter += CheckZero(number);
                negativeCounter += CheckNegative(number);
            }
            PrintResult(zeroCounter, negativeCounter);
        }

        private static int CheckNegative(int number)
        {
            if (number < 0)
            {
                return 1;
            }
            else return 0;
        }

        private static int CheckZero(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else return 0;
        }

        private static void PrintResult(int zeroCounter, int negativeCounter)
        {
            if (zeroCounter > 0)
            {
                Console.WriteLine("zero");
            }
            else if (negativeCounter % 2 != 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
