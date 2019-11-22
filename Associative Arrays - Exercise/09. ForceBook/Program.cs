using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] splitedInput = input.Split(" | ");
                    string side = splitedInput[0];
                    string user = splitedInput[1];

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();
                    }
                    bool memberExists = false;

                    foreach (var kvp in forceBook)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            memberExists = true;
                            break;
                        }
                    }

                    if (!forceBook[side].Contains(user) && !memberExists)
                    {
                        forceBook[side].Add(user);
                    }
                }
                else
                {
                    string[] splitedInput = input.Split(" -> ");
                    string user = splitedInput[0];
                    string side = splitedInput[1];

                    bool memberExists = false;
                    string userSide = string.Empty;

                    foreach (var kvp in forceBook)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            memberExists = true;
                            userSide = kvp.Key;
                            break;
                        }
                    }
                    if (memberExists)
                    {
                        forceBook[userSide].Remove(user);
                    }

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();
                    }
                    if (!forceBook[side].Contains(user))
                    {
                        forceBook[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    //string userSide = string.Empty;

                    //if (forceBook.ContainsKey(side))
                    //{
                    //    foreach (var kvp in forceBook)
                    //    {
                    //        if (kvp.Value.Contains(user))
                    //        {
                    //            userSide = kvp.Key;
                    //            break;
                    //        }
                    //    }

                    //    if (!forceBook[side].Contains(user))
                    //    {
                    //        if (userSide != string.Empty)
                    //        {
                    //            forceBook[userSide].Remove(user);
                    //        }
                    //        forceBook[side].Add(user);
                    //        Console.WriteLine($"{user} joins the {side} side!");
                    //    }
                    //}
                }
            }
            forceBook = forceBook
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in forceBook)
            {
                if (kvp.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    List<string> users = kvp.Value.OrderBy(x => x).ToList();

                    foreach (var user in users)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
