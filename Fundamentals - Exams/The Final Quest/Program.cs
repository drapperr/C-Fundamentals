
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] splitedInput = input.Split();

                string command = splitedInput[0];

                if (command == "Delete")
                {
                    int index = int.Parse(splitedInput[1]) + 1;
                    if (index < text.Count && index > 0)
                    {
                        text.RemoveAt(index);
                    }
                }
                else if (command == "Swap")
                {
                    string word1 = splitedInput[1];
                    string word2 = splitedInput[2];

                    if (text.Contains(word1) && text.Contains(word2))
                    {
                        int index1 = text.IndexOf(word1);
                        int index2 = text.IndexOf(word2);
                        text[index1] = word2;
                        text[index2] = word1;
                    }
                }
                else if (command == "Put")
                {
                    string word = splitedInput[1];
                    int index = int.Parse(splitedInput[2]) - 1;

                    if (index <= text.Count && index >= 0)
                    {
                        text.Insert(index, word);
                    }
                }
                else if (command == "Sort")
                {
                    text.Sort();
                    text.Reverse();
                }
                else if (command == "Replace")
                {
                    string word1 = splitedInput[1];
                    string word2 = splitedInput[2];

                    if (text.Contains(word2))
                    {
                        int index = text.IndexOf(word2);
                        text[index] = word1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
