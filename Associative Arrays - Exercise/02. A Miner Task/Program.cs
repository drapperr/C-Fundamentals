using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resucesQuantity = new Dictionary<string, int>();

            string resurce;

            while ((resurce = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resucesQuantity.ContainsKey(resurce))
                {
                    resucesQuantity[resurce] += quantity;
                }
                else
                {
                    resucesQuantity.Add(resurce, quantity);
                }
            }
            foreach (var currentResurce in resucesQuantity)
            {
                Console.WriteLine($"{currentResurce.Key} -> {currentResurce.Value}");
            }
        }
    }
}