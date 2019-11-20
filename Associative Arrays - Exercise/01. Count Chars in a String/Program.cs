using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (var word in text)
            {
                foreach (var character in word)
                {
                    if (charCounts.ContainsKey(character))
                    {
                        charCounts[character]++;
                    }
                    else
                    {
                        charCounts.Add(character, 1);
                    }
                }
            }
            foreach (var currentChar in charCounts)
            {
                Console.WriteLine($"{currentChar.Key} -> {currentChar.Value}");
            }
        }
    }
}