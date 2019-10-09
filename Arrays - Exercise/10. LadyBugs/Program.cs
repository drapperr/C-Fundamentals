using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] indexesOfLadybugs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] ladybugsPositions = new int[sizeOfField];
            for (int i = 0; i < indexesOfLadybugs.Length; i++)
            {
                if (indexesOfLadybugs[i] >= 0 && indexesOfLadybugs[i] < sizeOfField)
                {
                    ladybugsPositions[indexesOfLadybugs[i]] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandSplit = command.Split().ToArray();
                int index = int.Parse(commandSplit[0]);
                int flyLength = int.Parse(commandSplit[2]);
                string direction = commandSplit[1];
                if (index >= 0 && index < ladybugsPositions.Length && ladybugsPositions[index] == 1)
                {
                    if (direction == "right")
                    {
                        int flyIndex = index + flyLength;
                        ladybugsPositions[index] = 0;
                        while (true)
                        {
                            if (flyIndex >= 0 && flyIndex < ladybugsPositions.Length)
                            {
                                if (ladybugsPositions[flyIndex] == 1)
                                {
                                    flyIndex += flyLength;
                                    continue;
                                }
                                else
                                {
                                    ladybugsPositions[flyIndex] = 1;
                                    break;
                                }
                            }
                            else break;
                        }
                    }
                    else if (direction == "left")
                    {
                        int flyIndex = index - flyLength;
                        ladybugsPositions[index] = 0;
                        while (true)
                        {
                            if (flyIndex >= 0 && flyIndex < ladybugsPositions.Length)
                            {
                                if (ladybugsPositions[flyIndex] == 1)
                                {
                                    flyIndex -= flyLength;
                                    continue;
                                }
                                else
                                {
                                    ladybugsPositions[flyIndex] = 1;
                                    break;
                                }
                            }
                            else break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", ladybugsPositions));
        }
    }
}
