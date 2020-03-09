using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0.0;

            foreach (var code in input)
            {
                string numberString = string.Empty;

                for (int i = 1; i < code.Length - 1; i++)
                {
                    numberString += code[i];
                }
                double number = double.Parse(numberString);
                char firstChar = code[0];
                char lastChar = code[code.Length - 1];

                if (char.IsUpper(firstChar))
                {
                    int codeNumber = (int)(firstChar - 'A' + 1);
                    number /= codeNumber;
                }
                else if (char.IsLower(firstChar))
                {
                    int codeNumber = (int)(firstChar - 'a' + 1);
                    number *= codeNumber;
                }

                if (char.IsUpper(lastChar))
                {
                    int codeNumber = (int)(lastChar - 'A' + 1);
                    number -= codeNumber;
                }
                else if (char.IsLower(lastChar))
                {
                    int codeNumber = (int)(lastChar - 'a' + 1);
                    number += codeNumber;
                }

                totalSum += number;
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}