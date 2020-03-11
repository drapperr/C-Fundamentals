using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                }
                else if (char.IsLetter(item))
                {
                    letters += item;
                }
                else
                {
                    others += item;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
