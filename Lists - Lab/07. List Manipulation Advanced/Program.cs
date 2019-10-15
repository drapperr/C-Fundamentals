using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> originalNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers = originalNumbers;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> currentCommand = command.Split().ToList();
                string action = currentCommand[0];
                if (action == "Add")
                {
                    numbers.Add(int.Parse(currentCommand[1]));
                }
                else if (action == "Remove")
                {
                    numbers.Remove(int.Parse(currentCommand[1]));
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(currentCommand[1]);
                    numbers.RemoveAt(index);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(currentCommand[2]);
                    numbers.Insert(index, int.Parse(currentCommand[1]));
                }
                else if (action == "Contains")
                {
                    int number = int.Parse(currentCommand[1]);
                    CheckContains(numbers, number);
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = GetEvenOrOddNumbers(numbers, 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = GetEvenOrOddNumbers(numbers, 1);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action == "GetSum")
                {
                    Console.WriteLine(GetSum(numbers));
                }
                else if (action == "Filter")
                {
                    string condition = currentCommand[1];
                    int number = int.Parse(currentCommand[2]);

                    List<int> filtredNumbers = FilterNumbers(numbers, condition, number);
                    Console.WriteLine(string.Join(" ", filtredNumbers));
                }
            }
            if (originalNumbers != numbers)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static List<int> FilterNumbers(List<int> numbers, string condition, int number)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {

                if (condition == "<")
                {
                    if (numbers[i] < number)
                    {
                        result.Add(numbers[i]);
                    }
                }
                else if (condition == ">")
                {
                    if (numbers[i] > number)
                    {
                        result.Add(numbers[i]);
                    }
                }
                else if (condition == ">=")
                {
                    if (numbers[i] >= number)
                    {
                        result.Add(numbers[i]);
                    }
                }
                else if (condition == "<=")
                {
                    if (numbers[i] <= number)
                    {
                        result.Add(numbers[i]);
                    }
                }
            }
            return result;
        }

        private static int GetSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static List<int> GetEvenOrOddNumbers(List<int> numbers, int evenOrOdd)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == evenOrOdd)
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }

        private static void CheckContains(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
