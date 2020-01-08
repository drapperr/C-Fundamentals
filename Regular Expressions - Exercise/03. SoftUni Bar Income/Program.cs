using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            double totalIncome = 0;

            var regex = new Regex(@"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|[^|$%.]*?(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.*\d*)\$");

            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    var regexInput = regex.Match(input);

                    string name = regexInput.Groups["name"].Value;
                    string product = regexInput.Groups["product"].Value;
                    int count = int.Parse(regexInput.Groups["count"].Value);
                    double price = double.Parse(regexInput.Groups["price"].Value);

                    double total = count * price;

                    result.Add($"{name}: {product} - {total:F2}");
                    totalIncome += total;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}