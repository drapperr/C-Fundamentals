using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonimList = new Dictionary<string, List<string>>();

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (synonimList.ContainsKey(word))
                {
                    synonimList[word].Add(synonim);
                }
                else
                {
                    synonimList.Add(word, new List<string> { synonim });
                }
            }
            foreach (var item in synonimList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}