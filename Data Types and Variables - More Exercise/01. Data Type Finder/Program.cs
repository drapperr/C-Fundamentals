using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                bool isBolean = bool.TryParse(input, out bool boolean);
                bool isInteger = int.TryParse(input, out int integer);
                bool isChar = char.TryParse(input, out char character);
                bool isDouble = double.TryParse(input, out double floating);
                if (isBolean)
                {
                    Console.WriteLine($"{input} is boolean type");

                }
                else if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");

                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");

                }
                else if (isDouble)
                {
                    Console.WriteLine($"{input} is floating point type");

                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
