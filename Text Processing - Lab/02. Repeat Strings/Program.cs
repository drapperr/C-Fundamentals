using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split();

            string resultText = string.Empty;

            foreach (var word in inputText)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    resultText += word;
                }
            }
            Console.WriteLine(resultText);
        }
    }
}