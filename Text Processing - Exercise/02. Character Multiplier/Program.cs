using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string text1 = input[0];
            string text2 = input[1];

            int maxLength = Math.Max(text1.Length, text2.Length);
            int sum = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < text1.Length && i < text2.Length)
                {
                    sum += text1[i] * text2[i];
                }
                else if (i < text1.Length)
                {
                    sum += text1[i];
                }
                else if (i < text2.Length)
                {
                    sum += text2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}