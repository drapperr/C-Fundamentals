using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"@(?<name>[A-Za-z]+)[^-@!:>]+!(?<type>[G|N])!");
            List<string> result = new List<string>();

            int key = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder text = new StringBuilder();
                foreach (var symbol in input)
                {
                    text.Append((char)(symbol - key));
                }
                if (regex.IsMatch(text.ToString()))
                {
                    Match match = regex.Match(text.ToString());
                    string name = match.Groups["name"].Value;
                    string type = match.Groups["type"].Value;
                    if (type == "G")
                    {
                        result.Add(name);
                    }
                }
            }
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}