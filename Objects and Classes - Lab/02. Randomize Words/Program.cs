using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int randomIndex = rnd.Next(0, text.Length);
                string temp = text[i];
                text[i] = text[randomIndex];
                text[randomIndex] = temp;
            }
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
