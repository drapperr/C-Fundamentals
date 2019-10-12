using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(Area(width, height));
        }

        private static int Area(int width, int height)
        {
            return width * height;
        }
    }
}
