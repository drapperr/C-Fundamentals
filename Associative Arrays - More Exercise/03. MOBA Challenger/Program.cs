using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerSkills = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("vs"))
                {
                    string[] splitedInput = input.Split(" vs ");
                    string player1 = splitedInput[0];
                    string player2 = splitedInput[1];

                    string demotedPlayer = string.Empty;

                    if (playerSkills.ContainsKey(player1)
                        && playerSkills.ContainsKey(player2))
                    {
                        foreach (var kvp1 in playerSkills[player1])
                        {
                            foreach (var kvp2 in playerSkills[player2])
                            {
                                if (kvp1.Key == kvp2.Key)
                                {
                                    if (kvp1.Value > kvp2.Value)
                                    {
                                        demotedPlayer = player2;
                                        break;
                                    }
                                    else if (kvp1.Value < kvp2.Value)
                                    {
                                        demotedPlayer = player1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (demotedPlayer != string.Empty)
                    {
                        playerSkills.Remove(demotedPlayer);
                    }
                }
                else
                {
                    string[] splitedInput = input.Split(" -> ");
                    string player = splitedInput[0];
                    string position = splitedInput[1];
                    int skill = int.Parse(splitedInput[2]);

                    if (!playerSkills.ContainsKey(player))
                    {
                        playerSkills[player] = new Dictionary<string, int>();
                        playerSkills[player][position] = skill;
                    }

                    if (!playerSkills[player].ContainsKey(position))
                    {
                        playerSkills[player][position] = skill;
                    }

                    if (playerSkills[player][position] < skill)
                    {
                        playerSkills[player][position] = skill;
                    }
                }
            }
            var playerTotalSkill = new Dictionary<string, int>();

            foreach (var currentPlayer in playerSkills)
            {
                int totalSkills = 0;

                foreach (var kvp in currentPlayer.Value)
                {
                    totalSkills += kvp.Value;
                }

                if (!playerTotalSkill.ContainsKey(currentPlayer.Key))
                {
                    playerTotalSkill[currentPlayer.Key] = 0;
                }
                playerTotalSkill[currentPlayer.Key] = totalSkills;
            }
            playerTotalSkill = playerTotalSkill
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var currentPlayer in playerTotalSkill)
            {
                Console.WriteLine($"{currentPlayer.Key}: {currentPlayer.Value} skill");

                string playerName = currentPlayer.Key;

                Dictionary<string, int> currentPlayerSkills = playerSkills[playerName]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var kvp in currentPlayerSkills)
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }
}
