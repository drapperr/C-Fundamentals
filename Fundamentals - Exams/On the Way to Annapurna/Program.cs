using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input.Split("->");

                string command = splitedInput[0];
                string store = splitedInput[1];

                if (command == "Add")
                {
                    if (!stores.ContainsKey(store))
                    {
                        stores[store] = new List<string>();
                    }

                    string item = splitedInput[2];

                    if (item.Contains(','))
                    {
                        string[] items = item.Split(',');
                        foreach (var currentItem in items)
                        {
                            stores[store].Add(currentItem);
                        }
                    }
                    else
                    {
                        stores[store].Add(item);
                    }
                }
                else if (command == "Remove")
                {
                    if (stores.ContainsKey(store))
                    {
                        stores.Remove(store);
                    }
                }
            }
            stores = stores
                .OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Stores list:");

            foreach (var kvp in stores)
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
