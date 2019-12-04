using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexInput = new Regex(@"^((?<name>[A-Za-z0-9!@#$?]+)=(?<length>[0-9]+)+<<(?<code>.+))$");
            Regex regexName = new Regex(@"[A-Za-z0-9]+");
            Regex regexSybols = new Regex(@"[,.]");

            string input;

            while ((input = Console.ReadLine()) != "Last note")
            {
                if (regexInput.IsMatch(input))
                {
                    var inputArgs = regexInput.Match(input);

                    string name = inputArgs.Groups["name"].Value;
                    int length = int.Parse(inputArgs.Groups["length"].Value);
                    string code = inputArgs.Groups["code"].Value;

                    if (regexName.IsMatch(name) && !regexSybols.IsMatch(name))
                    {
                        if (code.Length == length)
                        {
                            StringBuilder correctName = new StringBuilder();

                            foreach (Match currentSymbols in regexName.Matches(name))
                            {
                                correctName.Append(currentSymbols);
                            }
                            Console.WriteLine($"Coordinates found! {correctName} -> {code}");
                            continue;
                        }
                    }
                }
                Console.WriteLine("Nothing found!");
            }
        }
    }
}