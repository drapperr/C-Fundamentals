using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualToatalPoints = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] splitedInput = input.Split(" -> ");

                string userName = splitedInput[0];
                string contestName = splitedInput[1];
                int contestPoints = int.Parse(splitedInput[2]);
                int oldPoints = 0;

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = new Dictionary<string, int>();
                    contests[contestName][userName] = contestPoints;
                }

                if (!contests[contestName].ContainsKey(userName))
                {
                    contests[contestName][userName] = contestPoints;
                }

                if (contests[contestName][userName] < contestPoints)
                {

                    oldPoints = contests[contestName][userName];
                    contests[contestName][userName] = contestPoints;
                }

                if (!individualToatalPoints.ContainsKey(userName))
                {
                    individualToatalPoints[userName] = 0;
                }
                individualToatalPoints[userName] -= oldPoints;
                individualToatalPoints[userName] += contestPoints;
            }
            foreach (var currentContest in contests)
            {
                Console.WriteLine($"{currentContest.Key}: {currentContest.Value.Count} participants");

                var sortedContest = currentContest.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                int i = 1;

                foreach (var kvp in sortedContest)
                {
                    Console.WriteLine($"{i}. {kvp.Key} <::> {kvp.Value}");
                    i++;
                }
            }
            individualToatalPoints = individualToatalPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Individual standings:");

            int j = 1;

            foreach (var kvp in individualToatalPoints)
            {
                Console.WriteLine($"{j}. {kvp.Key} -> {kvp.Value}");
                j++;
            }
        }
    }
}
