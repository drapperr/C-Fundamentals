using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char code = char.Parse(Console.ReadLine());
                message += (char)(code + key);
            }
            Console.WriteLine(message);
        }
    }
}
