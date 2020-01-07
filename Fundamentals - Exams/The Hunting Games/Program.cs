using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            decimal waterPerPerseon = decimal.Parse(Console.ReadLine());
            decimal foodPerPerseon = decimal.Parse(Console.ReadLine());
            decimal totalGroupWater = waterPerPerseon * players * days;
            decimal totalGroupFood = foodPerPerseon * players * days;
            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                double lossEnergy = double.Parse(Console.ReadLine());
                groupEnergy -= lossEnergy;
                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalGroupFood:f2} food and {totalGroupWater:f2} water.");
                    return;
                }
                if (currentDay % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    totalGroupWater -= totalGroupWater * (decimal)0.3;
                }
                if (currentDay % 3 == 0)
                {
                    totalGroupFood -= totalGroupFood / players;
                    groupEnergy += groupEnergy * 0.1;
                }
            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");

        }
    }
}