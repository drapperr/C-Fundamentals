using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startinYield = int.Parse(Console.ReadLine());
            int currentYield = startinYield;
            int totalSpice = 0;
            int days = 0;
            while (currentYield >= 100)
            {
                totalSpice += currentYield;
                totalSpice -= 26;
                currentYield -= 10;
                days++;
            }
            if (totalSpice >= 26)
            {
                totalSpice -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
