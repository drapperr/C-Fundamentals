using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;

            while ((inputText = Console.ReadLine()) != "end")
            {
                string reversedText = string.Empty;

                for (int i = inputText.Length - 1; i >= 0; i--)
                {
                    reversedText += inputText[i];
                }

                Console.WriteLine($"{inputText} = {reversedText}");
            }
        }
    }
}