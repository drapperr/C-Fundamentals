using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string modelBiggestKeg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                double heightKeg = double.Parse(Console.ReadLine());
                double capacityKeg = Math.PI * radiusKeg * radiusKeg * heightKeg;
                if (capacityKeg > biggestKeg)
                {
                    biggestKeg = capacityKeg;
                    modelBiggestKeg = kegModel;
                }
            }
            Console.WriteLine(modelBiggestKeg);
        }
    }
}
