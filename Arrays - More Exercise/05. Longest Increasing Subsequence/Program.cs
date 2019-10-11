using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            List<int> lis = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                List<int> currentLis = new List<int>();
                currentLis.Add(numbers[i]);
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j]>currentLis[currentLis.Count-1])
                    {
                        currentLis.Add(numbers[j]);
                    }
                }
                if (currentLis.Count>lis.Count)
                {
                    lis = new List<int>(currentLis);
                }
            }
            Console.WriteLine(string.Join(" ",lis));
        }
    }
}
