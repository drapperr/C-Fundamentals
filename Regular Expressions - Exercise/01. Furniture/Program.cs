using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@">>(?<name>[A-z]+)<<(?<price>\d+\.*\d*)!(?<quantity>\d+)");

            List<string> fornitures = new List<string>();
            double total = 0;
            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    var matchInput = regex.Match(input);
                    string name = matchInput.Groups["name"].Value;
                    double price = double.Parse(matchInput.Groups["price"].Value);
                    int quantity = int.Parse(matchInput.Groups["quantity"].Value);

                    fornitures.Add(name);
                    total += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var forniture in fornitures)
            {
                Console.WriteLine(forniture);
            }

            Console.WriteLine($"Total money spend: {total:F2}");
        }
    }
}