using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string commandLine;
            while ((commandLine = Console.ReadLine()) != "END")
            {
                List<string> command = commandLine.Split().ToList();
                string action = command[0];
                if (action == "Change")
                {
                    string paintingNumber = command[1];
                    string changedNumber = command[2];
                    if (numbers.Contains(paintingNumber))
                    {
                        int index = numbers.IndexOf(paintingNumber);
                        numbers.RemoveAt(index);
                        numbers.Insert(index, changedNumber);
                    }
                }
                else if (action == "Hide")
                {
                    string paintingNumber = command[1];
                    if (numbers.Contains(paintingNumber))
                    {
                        numbers.Remove(paintingNumber);
                    }
                }
                else if (action == "Switch")
                {
                    string paintingNumber = command[1];
                    string paintingNumber2 = command[2];
                    if (numbers.Contains(paintingNumber) && numbers.Contains(paintingNumber2))
                    {
                        int index1 = numbers.IndexOf(paintingNumber);
                        int index2 = numbers.IndexOf(paintingNumber2);
                        numbers.RemoveAt(index1);
                        numbers.Insert(index1, paintingNumber2);
                        numbers.RemoveAt(index2);
                        numbers.Insert(index2, paintingNumber);
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(command[1]) + 1;
                    string paintingNumber = command[2];
                    if (index > 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, paintingNumber);
                    }
                }
                else if (action == "Reverse")
                {
                    numbers.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
