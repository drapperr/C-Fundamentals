using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("#").ToArray();
            List<int> cells = new List<int>();
            int water = int.Parse(Console.ReadLine());
            double totalEffort = 0;
            int totalFire = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string[] currentComand = input[i].Split(" = ").ToArray();
                string typeOfFire = currentComand[0];
                int valueOfCell = int.Parse(currentComand[1]);
                bool validComand = (typeOfFire == "High" && valueOfCell >= 81 && valueOfCell <= 125) ||
                                   (typeOfFire == "Medium" && valueOfCell >= 51 && valueOfCell <= 80) ||
                                   (typeOfFire == "Low" && valueOfCell >= 1 && valueOfCell <= 50);
                if (validComand && ((totalFire + valueOfCell) <= water))
                {
                    double currentEffort = valueOfCell * 0.25;
                    totalEffort += currentEffort;
                    totalFire += valueOfCell;
                    cells.Add(valueOfCell);
                }
            }
            Console.WriteLine("Cells:");
            foreach (var cell in cells)
            {
                Console.WriteLine($"- {cell}");
            }
            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}