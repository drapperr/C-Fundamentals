using System;
using System.Linq;

namespace _09._0._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int longestSubsequence = -1;
            int longestSubIndex = -1;
            int longestSubSum = -1;
            int indexOfLongest = 0;
            int[] sequance = new int[length];
            int indexOfSequence = 1;
            string input;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int subsequence = 0;
                int subIndex = -1;
                int subSum = 0;
                int count = 0;
                for (int i = 0; i < length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        count++;
                        subSum++;
                        if (count > subsequence)
                        {
                            subsequence = count;
                            subIndex = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if (subsequence > longestSubsequence)
                {
                    longestSubIndex = subIndex;
                    longestSubsequence = subsequence;
                    longestSubSum = subSum;
                    sequance = currentSequence;
                    indexOfLongest = indexOfSequence;
                }
                else if (subsequence == longestSubsequence
                    && longestSubIndex > subIndex)
                {
                    longestSubIndex = subIndex;
                    longestSubSum = subSum;
                    sequance = currentSequence;
                    indexOfLongest = indexOfSequence;
                }
                else if (subsequence == longestSubsequence
                    && longestSubIndex == subIndex
                    && longestSubSum < subSum)
                {
                    longestSubSum = subSum;
                    sequance = currentSequence;
                    indexOfLongest = indexOfSequence;
                }
                indexOfSequence++;
            }
            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
            Console.WriteLine(string.Join(" ", sequance));
        }
    }
}
