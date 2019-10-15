using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int maxLength = Math.Max(firstLine.Count, secondLine.Count);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < firstLine.Count)
                {
                    result.Add(firstLine[i]);
                }
                if (i < secondLine.Count)
                {
                    result.Add(secondLine[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
