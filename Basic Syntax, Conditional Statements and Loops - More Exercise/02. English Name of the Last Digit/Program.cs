using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            string result = string.Empty;
            if (lastDigit == 0)
            {
                result = "zero";
            }
            else if (lastDigit == 1)
            {
                result = "one";
            }
            else if (lastDigit == 2)
            {
                result = "two";
            }
            else if (lastDigit == 3)
            {
                result = "three";
            }
            else if (lastDigit == 4)
            {
                result = "four";
            }
            else if (lastDigit == 5)
            {
                result = "five";
            }
            else if (lastDigit == 6)
            {
                result = "six";
            }
            else if (lastDigit == 7)
            {
                result = "seven";
            }
            else if (lastDigit == 8)
            {
                result = "eight";
            }
            else if (lastDigit == 9)
            {
                result = "nine";
            }
            Console.WriteLine(result);
        }
    }
}
