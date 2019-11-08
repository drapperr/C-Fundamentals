using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondListNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> biggerList = new List<int>();
            List<int> smallerList = new List<int>();
            if (firstListNumbers.Count > secondListNumbers.Count)
            {
                biggerList = firstListNumbers;
                smallerList = secondListNumbers;
            }
            else
            {
                secondListNumbers.Reverse();
                biggerList = secondListNumbers;
                smallerList = firstListNumbers;
            }
            int minNumber = Math.Min(biggerList[biggerList.Count - 1],
                biggerList[biggerList.Count - 2]);
            int maxNumber = Math.Max(biggerList[biggerList.Count - 1],
                biggerList[biggerList.Count - 2]);
            biggerList.RemoveAt(biggerList.Count - 1);
            biggerList.RemoveAt(biggerList.Count - 1);
            List<int> result = new List<int>();
            for (int i = 0; i < smallerList.Count; i++)
            {
                if (smallerList[i] > minNumber && smallerList[i] < maxNumber)
                {
                    result.Add(smallerList[i]);
                }
                if (biggerList[i] > minNumber && biggerList[i] < maxNumber)
                {
                    result.Add(biggerList[i]);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
