using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> currentCommand = command.Split().ToList();
                string action = currentCommand[0];
                int number = int.Parse(currentCommand[1]);
                if (action == "Add")
                {
                    numbers.Add(number);
                }
                else if (action == "Remove")
                {
                    numbers.Remove(number);
                }
                else if (action == "RemoveAt")
                {
                    int index = number;
                    numbers.RemoveAt(index);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(currentCommand[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
