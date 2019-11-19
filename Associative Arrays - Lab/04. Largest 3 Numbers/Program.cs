using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToList();

            int counter = 0;
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (counter < 3)
                {
                    result.Add(number);
                    counter++;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}