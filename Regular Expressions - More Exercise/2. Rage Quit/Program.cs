using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<symbols>[^\d]+)(?<number>[\d]+)");

            StringBuilder result = new StringBuilder();
            List<char> symbols = new List<char>();

            var inputs = regex.Matches(Console.ReadLine());

            foreach (Match currentInput in inputs)
            {
                string text = currentInput.Groups["symbols"].Value.ToUpper();
                int count = int.Parse(currentInput.Groups["number"].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(text);
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (!symbols.Contains(text[i]))
                    {
                        symbols.Add(text[i]);
                    }
                }
            }
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(result);
        }
    }
}