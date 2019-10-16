using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintResult(firstChar, secondChar);
        }

        private static void PrintResult(char firstChar, char secondChar)
        {
            string result = string.Empty;
            int minChar = Math.Min((int)firstChar, (int)secondChar) + 1;
            int maxChar = Math.Max((int)firstChar, (int)secondChar);
            for (int i = minChar; i < maxChar; i++)
            {
                result += (char)i + " ";
            }
            Console.WriteLine(result);
        }
    }
}
