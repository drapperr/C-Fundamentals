using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts.Add(word, 1);
                }
            }
            List<string> result = new List<string>();

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    result.Add(count.Key);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}