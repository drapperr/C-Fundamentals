using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            foreach (var symbol in text)
            {
                char encryptedSymbol = (char)(symbol + 3);
                encryptedText.Append(encryptedSymbol);
            }
            Console.WriteLine(encryptedText);
        }
    }
}