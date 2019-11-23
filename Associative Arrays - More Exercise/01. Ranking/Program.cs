using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contenstsPasswords = new Dictionary<string, string>();
            var studentsPoints = new SortedDictionary<string, Dictionary<string, int>>();
            var studenTotalPoints = new Dictionary<string, int>();

            string inputContest;

            while ((inputContest = Console.ReadLine()) != "end of contests")
            {
                string[] splitedInputContest = inputContest.Split(':');

                string contest = splitedInputContest[0];
                string password = splitedInputContest[1];

                contenstsPasswords[contest] = password;
            }

            string input;
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] splitedInput = input.Split("=>");

                string contest = splitedInput[0];
                string password = splitedInput[1];
                string username = splitedInput[2];
                int points = int.Parse(splitedInput[3]);

                if (contenstsPasswords.ContainsKey(contest))
                {
                    if (contenstsPasswords[contest] == password)
                    {
                        if (!studentsPoints.ContainsKey(username))
                        {
                            studentsPoints[username] = new Dictionary<string, int>();
                        }
                        if (!studentsPoints[username].ContainsKey(contest))
                        {
                            studentsPoints[username][contest] = 0;
                        }
                        if (studentsPoints[username][contest] < points)
                        {
                            if (!studenTotalPoints.ContainsKey(username))
                            {
                                studenTotalPoints[username] = 0;
                            }
                            studenTotalPoints[username] -= studentsPoints[username][contest];
                            studenTotalPoints[username] += points;

                            studentsPoints[username][contest] = points;
                        }
                    }
                }
            }
            string bestStudent = string.Empty;
            int bestStudentPoints = 0;

            foreach (var kvp in studenTotalPoints)
            {
                if (kvp.Value > bestStudentPoints)
                {
                    bestStudentPoints = kvp.Value;
                    bestStudent = kvp.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestStudentPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var currentStudent in studentsPoints)
            {
                Console.WriteLine(currentStudent.Key);

                Dictionary<string, int> currentStudentPoints = currentStudent.Value
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var kvp in currentStudentPoints)
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
