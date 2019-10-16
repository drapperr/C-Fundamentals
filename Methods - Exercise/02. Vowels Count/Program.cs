using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            GetVowelsCount(text);
        }

        private static void GetVowelsCount(string text)
        {
            int volwelsSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    volwelsSum++;
                }
            }
            Console.WriteLine(volwelsSum);
        }
    }
}
