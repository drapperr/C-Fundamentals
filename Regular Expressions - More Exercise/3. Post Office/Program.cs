using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex lettersRegex = new Regex(@"([#$%*&])(?<letters>[A-Z]+)\1");
            Regex secondRegex = new Regex(@"(?<letter>\d{2}):(?<length>\d{2})");

            string[] parts = Console.ReadLine().Split('|');
            string firstPart = parts[0];
            string secondPart = parts[1];
            List<string> words = parts[2].Split().ToList();

            List<char> letters = lettersRegex.Match(firstPart).Groups["letters"].Value.ToList();

            var matches = secondRegex.Matches(secondPart);

            Dictionary<char, int> wordsLength = new Dictionary<char, int>();
            foreach (var letter in letters)
            {
                wordsLength[letter] = 0;
            }

            foreach (Match match in matches)
            {
                char letter = (char)(int.Parse(match.Groups["letter"].Value));
                int length = int.Parse(match.Groups["length"].Value);
                if (wordsLength.ContainsKey(letter))
                {
                    wordsLength[letter] = length;
                }
            }


            foreach (var kvp in wordsLength)
            {
                char letter = kvp.Key;
                int length = kvp.Value;

                Regex regex = new Regex($@"^([{letter}][^\s]{{{length}}})$");

                foreach (var word in words)
                {
                    if (regex.IsMatch(word))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}