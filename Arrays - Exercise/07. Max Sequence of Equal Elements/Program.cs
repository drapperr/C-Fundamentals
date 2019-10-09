using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentNum = int.MaxValue;
            int counter = 1;
            int maxEquals = 0;
            int equalNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (currentNum == numbers[i])
                {
                    counter++;
                    if (counter > maxEquals)
                    {
                        maxEquals = counter;
                        equalNum = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                    currentNum = numbers[i];
                }
            }
            for (int i = 0; i < maxEquals; i++)
            {
                Console.Write(equalNum + " ");
            }
            Console.WriteLine();
        }
    }
}
