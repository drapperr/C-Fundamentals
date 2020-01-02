using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input.Split();
                string command = splitedInput[0];

                if (command == "Switch")
                {
                    int index = int.Parse(splitedInput[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] *= -1;
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(splitedInput[1]);
                    int value = int.Parse(splitedInput[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] = value;
                    }
                }
                else if (command == "Sum")
                {
                    string secondCommand = splitedInput[1];
                    int sum = 0;

                    if (secondCommand == "Negative")
                    {
                        foreach (var number in numbers)
                        {
                            if (number < 0)
                            {
                                sum += number;
                            }
                        }
                    }
                    else if (secondCommand == "Positive")
                    {
                        foreach (var number in numbers)
                        {
                            if (number >= 0)
                            {
                                sum += number;
                            }
                        }
                    }
                    else if (secondCommand == "All")
                    {
                        foreach (var number in numbers)
                        {
                            sum += number;
                        }
                    }
                    Console.WriteLine(sum);
                }
            }
            numbers = numbers.Where(x => x >= 0).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
