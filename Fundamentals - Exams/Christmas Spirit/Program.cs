using System;

namespace Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int ornamentSetPrice = 2;
            int skirtPrice = 5;
            int garlandsPrice = 3;
            int lightsPrice = 15;

            int totalCost = 0;
            int totalSpirit = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    totalCost += ornamentSetPrice * quantity;
                    totalSpirit += 5;
                }
                if (i % 3 == 0)
                {
                    totalCost += (skirtPrice + garlandsPrice) * quantity;
                    totalSpirit += 13;
                }
                if (i % 5 == 0)
                {
                    totalCost += lightsPrice * quantity;
                    totalSpirit += 17;
                    if (i % 3 == 0)
                    {
                        totalSpirit += 30;
                    }
                }
                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    totalCost += skirtPrice + garlandsPrice + lightsPrice;
                }
            }
            if (days % 10 == 0)
            {
                totalSpirit -= 30;
            }
            Console.WriteLine($"Total cost: {totalCost}");
            Console.WriteLine($"Total spirit: {totalSpirit}");
        }
    }
}