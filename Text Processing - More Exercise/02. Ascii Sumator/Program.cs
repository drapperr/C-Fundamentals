using System;
using System.Text;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            char minChar = (char)Math.Min(firstChar, secondChar);
            char maxChar = (char)Math.Max(firstChar, secondChar);

            int sum = 0;

            foreach (var charachter in input)
            {
                if (charachter > minChar && charachter < maxChar)
                {
                    sum += charachter;
                }
            }
            Console.WriteLine(sum);
        }
    }
}