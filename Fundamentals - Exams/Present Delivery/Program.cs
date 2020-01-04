using System;
using System.Collections.Generic;
using System.Linq;

namespace Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersOfMembers = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();

            string input;
            int currentPosition = 0;

            while ((input = Console.ReadLine()) != "Merry Xmas!")
            {
                string[] jump = input.Split();
                int jumpLength = int.Parse(jump[1]);

                currentPosition += jumpLength;

                if (currentPosition < numbersOfMembers.Count)
                {
                    GivePresents(numbersOfMembers, currentPosition);
                }
                else
                {
                    while (currentPosition >= numbersOfMembers.Count)
                    {
                        currentPosition -= numbersOfMembers.Count;
                    }
                    GivePresents(numbersOfMembers, currentPosition);
                }
            }
            int failedHouses = 0;

            foreach (var members in numbersOfMembers)
            {
                if (members > 0)
                {
                    failedHouses++;
                }
            }
            Console.WriteLine($"Santa's last position was {currentPosition}.");

            if (failedHouses == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {failedHouses} houses.");
            }
        }

        private static void GivePresents(List<int> numbersOfMembers, int currentPosition)
        {
            if (numbersOfMembers[currentPosition] > 0)
            {
                numbersOfMembers[currentPosition] -= 2;
            }
            else
            {
                Console.WriteLine($"House {currentPosition} will have a Merry Christmas.");
            }
        }
    }
}
