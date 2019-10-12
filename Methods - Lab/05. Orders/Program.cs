using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //coffee – 1.50
            //water – 1.00
            //coke – 1.40
            //snacks – 2.00
            string productName = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            PrntResult(productName, count);
        }

        private static void PrntResult(string productName, int count)
        {
            double total = 0;
            if (productName == "coffee")
            {
                total = count * 1.50;
            }
            else if (productName == "water")
            {
                total = count * 1.00;
            }
            else if (productName == "coke")
            {
                total = count * 1.40;
            }
            else if (productName == "snacks")
            {
                total = count * 2.00;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
