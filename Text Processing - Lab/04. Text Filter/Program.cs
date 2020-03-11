using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var word in words)
            {
                string replaceWord = new string('*', word.Length);

                while (text.Contains(word))
                {
                    text = text.Replace(word, replaceWord);
                }
            }
            Console.WriteLine(text);
        }
    }
}