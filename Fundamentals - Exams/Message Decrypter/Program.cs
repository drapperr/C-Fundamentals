using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(\$|%)(?<tag>[A-Z][a-z]{2,})\1:\s\[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|$");

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    string tag = match.Groups["tag"].Value;
                    char firstChar = (char)int.Parse(match.Groups["first"].Value);
                    char secondChar = (char)int.Parse(match.Groups["second"].Value);
                    char thirdChar = (char)int.Parse(match.Groups["third"].Value);
                    string message = firstChar.ToString() + secondChar + thirdChar;

                    Console.WriteLine($"{tag}: {message}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}