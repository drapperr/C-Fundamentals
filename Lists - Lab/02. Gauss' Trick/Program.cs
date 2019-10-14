using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sumList = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int sum = numbers[i] + numbers[numbers.Count - 1 - i];
                sumList.Add(sum);
            }
            if (numbers.Count % 2 != 0)
            {
                int midNumber = numbers[numbers.Count / 2];
                sumList.Add(midNumber);
            }
            Console.WriteLine(string.Join(" ", sumList));
        }
    }
}
