using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<char> text = Console.ReadLine().ToList();
            string result = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                int index = 0;
                while (numbers[i] > 0)
                {
                    index += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                while (index >= text.Count)
                {
                    index -= text.Count;
                }
                result += text[index];
                text.RemoveAt(index);
            }
            Console.WriteLine(result);
        }
    }
}
