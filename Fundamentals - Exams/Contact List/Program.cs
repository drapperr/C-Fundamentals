using System;
using System.Collections.Generic;
using System.Linq;

namespace Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];

                if (command == "Add")
                {
                    string contact = input[1];
                    int index = int.Parse(input[2]);

                    if (contacts.Contains(contact))
                    {
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.Insert(index, contact);
                        }
                    }
                    else
                    {
                        contacts.Add(contact);
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(input[1]);

                    if (index >= 0 && index < contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if (command == "Export")
                {
                    int startIndex = int.Parse(input[1]);
                    int count = int.Parse(input[2]);
                    int lastIndex;

                    if (startIndex < 0 || startIndex >= contacts.Count)
                    {
                        continue;
                    }

                    if (startIndex + count >= contacts.Count)
                    {
                        lastIndex = contacts.Count - 1;
                    }
                    else
                    {
                        lastIndex = startIndex + count - 1;
                    }
                    List<string> resultList = new List<string>();

                    for (int i = startIndex; i <= lastIndex; i++)
                    {
                        resultList.Add(contacts[i]);
                    }
                    if (resultList.Count != 0)
                    {
                        Console.WriteLine(string.Join(" ", resultList));
                    }
                }
                else if (command == "Print")
                {
                    string secondCommand = input[1];

                    if (secondCommand == "Normal")
                    {
                        Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                    }
                    else if (secondCommand == "Reversed")
                    {
                        contacts.Reverse();
                        Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                    }
                    return;
                }
            }
        }
    }
}
