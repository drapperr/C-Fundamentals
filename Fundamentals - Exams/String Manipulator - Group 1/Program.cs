using System;

namespace String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];

                if (command == "Translate")
                {
                    string symbol = inputArgs[1];
                    string replacement = inputArgs[2];

                    text = text.Replace(symbol, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string part = inputArgs[1];

                    Console.WriteLine(text.Contains(part));
                }
                else if (command == "Start")
                {
                    string part = inputArgs[1];

                    string firstPart = text.Substring(0, part.Length);

                    Console.WriteLine(part == firstPart);
                }
                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char symbol = char.Parse(inputArgs[1]);

                    Console.WriteLine(text.LastIndexOf(symbol));
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(inputArgs[1]);
                    int count = int.Parse(inputArgs[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }
            }
        }
    }
}