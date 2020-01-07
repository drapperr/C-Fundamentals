using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([#$%*&])(?<name>[A-Za-z]+)\1=(?<length>\d+)!!(?<code>.+)");

            string output = "Nothing found!";

            while (output == "Nothing found!")
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    string name = match.Groups["name"].Value;
                    int length = int.Parse(match.Groups["length"].Value);
                    string code = match.Groups["code"].Value;

                    if (length == code.Length)
                    {
                        StringBuilder decryptedCode = new StringBuilder();
                        foreach (var symbol in code)
                        {
                            decryptedCode.Append((char)(symbol + length));
                        }
                        output = $"Coordinates found! {name} -> {decryptedCode}";
                    }
                }
                Console.WriteLine(output);
            }
        }
    }
}