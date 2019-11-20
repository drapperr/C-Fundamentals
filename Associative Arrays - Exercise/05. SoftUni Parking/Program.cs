using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> plates = new Dictionary<string, string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split();

                string action = command[0];
                string userName = command[1];

                if (action == "register")
                {
                    string plateNymber = command[2];

                    if (plates.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plates[userName]}");
                    }
                    else
                    {
                        plates[userName] = plateNymber;
                        Console.WriteLine($"{userName} registered {plateNymber} successfully");
                    }
                }
                else if (action == "unregister")
                {
                    if (plates.ContainsKey(userName))
                    {
                        plates.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }
            foreach (var plate in plates)
            {
                Console.WriteLine($"{plate.Key} => {plate.Value}");
            }
        }
    }
}