using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sentDic = new Dictionary<string, int>();
            Dictionary<string, int> recievedDic = new Dictionary<string, int>();

            int capacity = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] inputArgs = input.Split('=');
                string command = inputArgs[0];

                if (command == "Add")
                {
                    string username = inputArgs[1];
                    int sent = int.Parse(inputArgs[2]);
                    int received = int.Parse(inputArgs[3]);

                    if (!sentDic.ContainsKey(username))
                    {
                        sentDic[username] = sent;
                        recievedDic[username] = received;
                    }
                }
                else if (command == "Message")
                {
                    string sender = inputArgs[1];
                    string receiver = inputArgs[2];

                    if (sentDic.ContainsKey(sender) && sentDic.ContainsKey(receiver))
                    {
                        sentDic[sender]++;
                        recievedDic[receiver]++;
                        if (sentDic[sender] + recievedDic[sender] >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            sentDic.Remove(sender);
                            recievedDic.Remove(sender);
                        }
                        if (sentDic[receiver] + recievedDic[receiver] >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            sentDic.Remove(receiver);
                            recievedDic.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string userName = inputArgs[1];

                    if (userName == "All")
                    {
                        sentDic.Clear();
                        recievedDic.Clear();
                    }
                    else
                    {
                        sentDic.Remove(userName);
                        recievedDic.Remove(userName);
                    }
                }
            }
            Console.WriteLine($"Users count: {recievedDic.Count}");
            foreach (var kvp in recievedDic.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string userName = kvp.Key;
                int messages = kvp.Value + sentDic[userName];
                Console.WriteLine($"{userName} - {messages}");
            }
        }
    }
}
