using System;
using System.Collections.Generic;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gifts = Console.ReadLine().Split();
            string input;
            while ((input = Console.ReadLine()) != "No Money")
            {
                string[] comands = input.Split();
                string command = comands[0];
                string gift = comands[1];
                if (command == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gift == gifts[i])
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    int index = int.Parse(comands[2]);
                    if (index >= 0 && index < gifts.Length)
                    {
                        gifts[index] = gift;
                    }
                }
                else if (command == "JustInCase")
                {
                    gifts[gifts.Length - 1] = gift;
                }
            }
            List<string> result = new List<string>();
            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] != "None")
                {
                    result.Add(gifts[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}