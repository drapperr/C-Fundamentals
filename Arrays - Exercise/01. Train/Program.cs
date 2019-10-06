using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peopleOnWagon = new int[wagons];
            int sum = 0;
            for (int i = 0; i < wagons; i++)
            {
                peopleOnWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleOnWagon[i];
            }
            Console.WriteLine(string.Join(" ", peopleOnWagon));
            Console.WriteLine(sum);
        }
    }
}
