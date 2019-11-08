using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();
            List<string> text = new List<string>();
            List<int> numbers = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                int number;
                if (int.TryParse(input[i].ToString(), out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    text.Add(input[i].ToString());
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
            List<string> result = new List<string>();
            int textCounter = -1;
            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    textCounter++;
                    if (textCounter < text.Count)
                    {
                        result.Add(text[textCounter]);
                    }
                }
                for (int j = 0; j < skipList[i]; j++)
                {
                    textCounter++;
                }
                if (textCounter == text.Count)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
