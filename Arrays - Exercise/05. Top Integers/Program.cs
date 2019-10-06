using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string biggerNums = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool bigger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        bigger = false;
                    }
                }
                if (bigger)
                {
                    biggerNums += numbers[i] + " ";
                }
            }
            Console.WriteLine(biggerNums);
        }
    }
}
