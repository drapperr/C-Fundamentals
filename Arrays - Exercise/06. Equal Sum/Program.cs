using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rigtSum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += numbers[j];
                    }
                    else if (j > i)
                    {
                        rigtSum += numbers[j];
                    }
                }
                if (leftSum == rigtSum)
                {
                    index = i;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
