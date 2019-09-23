using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double usd = pounds * 1.31;
            Console.WriteLine($"{usd:f3}");
        }
    }
}
