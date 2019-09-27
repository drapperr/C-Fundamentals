using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            a /= 0.000001;
            b /= 0.000001;
            Console.WriteLine((int)a == (int)b);
        }
    }
}
