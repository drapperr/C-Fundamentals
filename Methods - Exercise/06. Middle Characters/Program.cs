using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string midCharacters = GetMidCharacter(text);
            Console.WriteLine(midCharacters);
        }

        private static string GetMidCharacter(string text)
        {
            if (text.Length % 2 == 0)
            {
                string firstChar = text[(text.Length - 1) / 2].ToString();
                string secondChar = text[((text.Length - 1) / 2) + 1].ToString();
                return firstChar + secondChar;
            }
            else
            {
                return text[(text.Length - 1) / 2].ToString();
            }
        }
    }
}
