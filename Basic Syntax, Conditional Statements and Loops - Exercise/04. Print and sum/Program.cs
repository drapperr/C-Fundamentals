using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int currentNumber = firsNumber; currentNumber <= lastNumber; currentNumber++)
            {
                sum += currentNumber;
                Console.Write($"{currentNumber} ");
                if (currentNumber == lastNumber)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
