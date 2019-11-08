using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftSum = 0;
            double rightSum = 0;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    leftSum -= leftSum * 0.2;
                }
                else
                {
                    leftSum += numbers[i];
                }
                if (numbers[numbers.Count - 1 - i] == 0)
                {
                    rightSum -= rightSum * 0.2;
                }
                else
                {
                    rightSum += numbers[numbers.Count - 1 - i];
                }
            }
            if (leftSum < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
