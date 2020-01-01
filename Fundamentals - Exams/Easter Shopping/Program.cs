using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();
            int comandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < comandsCount; i++)
            {
                List<string> currentCommand = Console.ReadLine().Split().ToList();
                string command = currentCommand[0];
                if (command == "Include")
                {
                    string shop = currentCommand[1];
                    shops.Add(shop);
                }
                else if (command == "Visit")
                {
                    string position = currentCommand[1];
                    int numberOfShops = int.Parse(currentCommand[2]);
                    if (shops.Count - numberOfShops < shops.Count && shops.Count - numberOfShops >= 0)
                    {
                        if (position == "first")
                        {
                            for (int j = 0; j < numberOfShops; j++)
                            {
                                shops.RemoveAt(0);
                            }
                        }
                        else if (position == "last")
                        {
                            for (int j = 0; j < numberOfShops; j++)
                            {
                                shops.RemoveAt(shops.Count - 1);
                            }
                        }
                    }
                }
                else if (command == "Prefer")
                {
                    int index1 = int.Parse(currentCommand[1]);
                    int index2 = int.Parse(currentCommand[2]);
                    if (index1 >= 0 && index1 < shops.Count
                        && index2 >= 0 && index2 < shops.Count
                        && index1 != index2)
                    {
                        string shopIndex1 = shops[index1];
                        string shopIndex2 = shops[index2];
                        shops.RemoveAt(index1);
                        shops.Insert(index1, shopIndex2);
                        shops.RemoveAt(index2);
                        shops.Insert(index2, shopIndex1);
                    }
                }
                else if (command == "Place")
                {
                    string shop = currentCommand[1];
                    int index = int.Parse(currentCommand[2]);
                    if (index >= 0 && index < shops.Count)
                    {
                        shops.Insert(index + 1, shop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
