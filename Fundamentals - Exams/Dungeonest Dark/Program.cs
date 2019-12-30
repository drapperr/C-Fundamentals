using System;
using System.Collections.Generic;
using System.Linq;

namespace Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            int roomCouter = 0;

            List<string> rooms = Console.ReadLine().Split('|').ToList();

            foreach (var room in rooms)
            {
                roomCouter++;
                string[] splitedRoom = room.Split();
                string input = splitedRoom[0];
                int number = int.Parse(splitedRoom[1]);

                if (input == "potion")
                {
                    int heltedWith = 0;
                    if (health + number > 100)
                    {
                        heltedWith = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        heltedWith = number;
                        health += number;
                    }
                    Console.WriteLine($"You healed for {heltedWith} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (input == "chest")
                {
                    coins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {input}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {input}.");
                        Console.WriteLine($"Best room: {roomCouter}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
