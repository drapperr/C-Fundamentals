using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = string.Empty;
            double totalMoney = 0;
            while ((money = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(money);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                else
                {
                    totalMoney += coins;
                }
            }
            string product = string.Empty;
            while ((product = Console.ReadLine()) != "End")
            {
                double productsPrice = 0;
                bool purchase = false;
                if (product == "Nuts")
                {
                    productsPrice += 2.0;
                    purchase = true;
                }
                else if (product == "Water")
                {
                    productsPrice += 0.7;
                    purchase = true;
                }
                else if (product == "Crisps")
                {
                    productsPrice += 1.5;
                    purchase = true;
                }
                else if (product == "Soda")
                {
                    productsPrice += 0.8;
                    purchase = true;
                }
                else if (product == "Coke")
                {
                    productsPrice += 1.0;
                    purchase = true;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (productsPrice <= totalMoney && purchase)
                {
                    totalMoney -= productsPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (purchase)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
