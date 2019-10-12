using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            PrintResult(text, count);
        }

        private static void PrintResult(string text, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(text);
            }
        }
    }
}
