using System;
using System.Collections.Generic;
using System.Linq;

namespace Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> questsList = Console.ReadLine().Split(", ").ToList();

            string input;

            while ((input = Console.ReadLine()) != "Retire!")
            {
                string[] splitedInput = input.Split(" - ");

                string command = splitedInput[0];

                if (command == "Start")
                {
                    string quest = splitedInput[1];

                    if (!questsList.Contains(quest))
                    {
                        questsList.Add(quest);
                    }
                }
                else if (command == "Complete")
                {
                    string quest = splitedInput[1];

                    if (questsList.Contains(quest))
                    {
                        questsList.Remove(quest);
                    }
                }
                else if (command == "Side Quest")
                {
                    string[] splitedQues = splitedInput[1].Split(':');

                    string quest = splitedQues[0];
                    string sideQuest = splitedQues[1];

                    int index = questsList.IndexOf(quest);

                    if (index != -1 && !questsList.Contains(sideQuest))
                    {
                        questsList.Insert(index + 1, sideQuest);
                    }
                }
                else if (command == "Renew")
                {
                    string quest = splitedInput[1];

                    if (questsList.Contains(quest))
                    {
                        questsList.Remove(quest);
                        questsList.Add(quest);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", questsList));
        }
    }
}