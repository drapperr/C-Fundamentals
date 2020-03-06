using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            char lastChar = input[0];
            ;
            result.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == lastChar)
                {
                    continue;
                }
                else
                {
                    result.Append(input[i]);
                    lastChar = input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}