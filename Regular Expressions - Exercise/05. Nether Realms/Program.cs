using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var separator = new Regex(@"\s*,\s*");
            var healthRegex = new Regex(@"[^\d+\-\/*.]");
            var numbersRegex = new Regex(@"-?\d+\.?\d*");
            var divOrMultregex = new Regex(@"[*\/]");

            List<string> result = new List<string>();

            string input = Console.ReadLine();
            string[] splitedInput = separator.Split(input);

            foreach (var name in splitedInput)
            {
                int healt = 0;
                var healthChars = healthRegex.Matches(name);
                foreach (Match charachter in healthChars)
                {
                    healt += char.Parse(charachter.Value);
                }
                double damage = 0;
                if (numbersRegex.IsMatch(name))
                {
                    var numbers = numbersRegex.Matches(name);
                    foreach (Match number in numbers)
                    {
                        damage += double.Parse(number.Value);
                    }
                    if (divOrMultregex.IsMatch(name))
                    {
                        var elements = divOrMultregex.Matches(name);
                        foreach (Match element in elements)
                        {
                            if (element.Value == "/")
                            {
                                damage /= 2;
                            }
                            else if (element.Value == "*")
                            {
                                damage *= 2;
                            }
                        }
                    }
                }
                result.Add($"{name} - {healt} health, {damage:F2} damage");
            }
            result.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
