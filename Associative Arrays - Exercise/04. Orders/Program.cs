using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Item> products = new Dictionary<string, Item>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] splitedInput = input.Split();

                string product = splitedInput[0];
                double price = double.Parse(splitedInput[1]);
                int quantity = int.Parse(splitedInput[2]);

                if (!products.ContainsKey(product))
                {
                    products[product] = new Item(price, quantity);
                }
                else
                {
                    products[product].Price = price;
                    products[product].Quantity += quantity;
                }

            }
            foreach (var product in products)
            {
                string productName = product.Key;
                double productTotalPrice = product.Value.Quantity * product.Value.Price;
                Console.WriteLine($"{productName} -> {productTotalPrice:F2}");
            }
        }
    }
    class Item
    {
        public Item(double price, int quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}