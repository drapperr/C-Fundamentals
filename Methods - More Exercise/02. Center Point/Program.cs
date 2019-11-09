using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int minX = Check(x1, x2);
            int minY = Check(y1, y2);
            Console.WriteLine($"({minX}, {minY})");
        }

        static int Check(int x1, int x2)
        {
            if (Math.Abs(x1) < Math.Abs(x2))
            {
                return x1;
            }
            else return x2;
        }
    }
}
