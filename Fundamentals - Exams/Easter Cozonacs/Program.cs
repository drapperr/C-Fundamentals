using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double price1KgFlour = double.Parse(Console.ReadLine());
            double price1PackEggs = price1KgFlour * 0.75;
            double priceOneLMilk = price1KgFlour * 1.25;
            double totalPriceCozonac = price1KgFlour + price1PackEggs + priceOneLMilk / 4;
            int cozonacsCount = 0;
            int coloredEggsCount = 0;
            while (budget - totalPriceCozonac >= 0)
            {
                budget -= totalPriceCozonac;
                cozonacsCount++;
                coloredEggsCount += 3;
                if (cozonacsCount % 3 == 0)
                {
                    coloredEggsCount -= cozonacsCount - 2;
                }
            }
            Console.WriteLine($"You made {cozonacsCount} cozonacs! Now you have {coloredEggsCount} eggs and {budget:f2}BGN left.");
        }
    }
}