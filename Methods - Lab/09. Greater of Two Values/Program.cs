using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            PrintGreater(type, firstString, secondString);
        }

        private static void PrintGreater(string type, string firstString, string secondString)
        {

            if (type == "int")
            {
                int firstIntValue = int.Parse(firstString);
                int secondIntValue = int.Parse(secondString);
                GetGreater(firstString, secondString, firstIntValue, secondIntValue);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstString);
                char secondChar = char.Parse(secondString);
                GetGreater(firstString, secondString, firstChar, secondChar);
            }
            else if (type == "string")
            {
                int firstLength = firstString.Length;
                int secondLength = secondString.Length;
                GetGreater(firstString, secondString, firstLength, secondLength);
            }
        }

        private static void GetGreater(string firstString, string secondString, int firstConvertedString, int secindConvertedString)
        {
            if (firstConvertedString > secindConvertedString)
            {
                Console.WriteLine(firstString);
            }
            else
            {
                Console.WriteLine(secondString);
            }
        }

    }
}
