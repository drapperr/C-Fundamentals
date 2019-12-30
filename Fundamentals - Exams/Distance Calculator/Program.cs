using System;

namespace Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double lenghtOf1Step = double.Parse(Console.ReadLine());
            int neededDistance = int.Parse(Console.ReadLine());

            double totalDistance = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    totalDistance += lenghtOf1Step * 0.7;
                }
                else
                {
                    totalDistance += lenghtOf1Step;

                }
            }
            double percentOfDistance = totalDistance / neededDistance;

            Console.WriteLine($"You travelled {percentOfDistance:F2}% of the distance!");
        }
    }
}