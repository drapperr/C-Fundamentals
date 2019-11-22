using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsResults = new Dictionary<string, int>();
            var subbmisions = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] splitedInput = input.Split('-');

                string userName = splitedInput[0];
                string language = splitedInput[1];

                if (language == "banned" && studentsResults.ContainsKey(userName))
                {
                    studentsResults.Remove(userName);
                }
                else
                {
                    int points = int.Parse(splitedInput[2]);

                    if (!studentsResults.ContainsKey(userName))
                    {
                        studentsResults[userName] = points;
                    }
                    if (studentsResults[userName] < points)
                    {
                        studentsResults[userName] = points;
                    }
                    if (!subbmisions.ContainsKey(language))
                    {
                        subbmisions[language] = 0;
                    }
                    subbmisions[language]++;
                }
            }
            studentsResults = studentsResults
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            subbmisions = subbmisions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var kvp in studentsResults)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in subbmisions)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}