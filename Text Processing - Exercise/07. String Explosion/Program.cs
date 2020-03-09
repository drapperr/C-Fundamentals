using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            int bombStrength = 0;

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    bombStrength += int.Parse(item.ToString());
                }
                if (item == '>')
                {
                    result.Append(item);
                }
                else
                {
                    if (bombStrength == 0)
                    {
                        result.Append(item);
                    }
                    else
                    {
                        bombStrength--;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}