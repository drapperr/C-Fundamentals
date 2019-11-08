using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> originalDrumSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> currentDrumSet = originalDrumSet.ToList();
            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    currentDrumSet[i] -= hitPower;
                    if (currentDrumSet[i] <= 0)
                    {
                        if (money - 3 * originalDrumSet[i] >= 0)
                        {
                            currentDrumSet[i] = originalDrumSet[i];
                            money -= originalDrumSet[i] * 3;

                        }
                        else
                        {
                            currentDrumSet.RemoveAt(i);
                            originalDrumSet.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", currentDrumSet));
            Console.WriteLine($"Gabsy has {money:F2}lv.");
        }
    }
}
