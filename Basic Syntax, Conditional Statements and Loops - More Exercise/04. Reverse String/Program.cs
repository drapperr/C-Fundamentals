using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string revertText = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                revertText += text[i];
            }
            Console.WriteLine(revertText);
        }
    }
}
