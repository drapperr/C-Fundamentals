using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] leftNumbers = new int[numbers.Length / 4];
            int[] middleNumbers = new int[numbers.Length / 2];
            int[] rightNumbers = new int[numbers.Length / 4];
            int[] leftAndRight = new int[numbers.Length / 2];
            int[] SumNumbers = new int[numbers.Length / 2];
            GetLeftNumbers(numbers, leftNumbers);
            GetMiddleNumbers(numbers, middleNumbers, leftNumbers);
            GetRightNumbers(numbers, rightNumbers, middleNumbers);
            JoinLeftRightNumbers(leftNumbers, rightNumbers, leftAndRight);
            GetSumNumbers(middleNumbers, leftAndRight, SumNumbers);
            Console.WriteLine(string.Join(" ", SumNumbers));
        }

        private static void GetSumNumbers(int[] middleNumbers, int[] leftAndRight, int[] sumNumbers)
        {
            for (int i = 0; i < sumNumbers.Length; i++)
            {
                sumNumbers[i] = middleNumbers[i] + leftAndRight[i];
            }
        }

        private static void JoinLeftRightNumbers(int[] leftNumbers, int[] rightNumbers, int[] leftAndRight)
        {
            Array.Reverse(leftNumbers);
            Array.Reverse(rightNumbers);
            for (int i = 0; i < leftNumbers.Length; i++)
            {
                leftAndRight[i] = leftNumbers[i];
            }
            int counter = leftNumbers.Length;
            for (int i = 0; i < rightNumbers.Length; i++)
            {
                leftAndRight[counter] = rightNumbers[i];
                counter++;
            }
        }

        private static void GetRightNumbers(int[] numbers, int[] rightNumbers, int[] middleNumbers)
        {
            int counter = 0;
            for (int i = rightNumbers.Length + middleNumbers.Length; i < numbers.Length; i++)
            {
                rightNumbers[counter] = numbers[i];
                counter++;
            }
        }

        private static void GetMiddleNumbers(int[] numbers, int[] middleNumbers, int[] leftNumbers)
        {
            int counter = 0;
            for (int i = leftNumbers.Length; i < leftNumbers.Length + middleNumbers.Length; i++)
            {
                middleNumbers[counter] = numbers[i];
                counter++;
            }
        }

        private static void GetLeftNumbers(int[] numbers, int[] leftNumbers)
        {
            for (int i = 0; i < leftNumbers.Length; i++)
            {
                leftNumbers[i] = numbers[i];
            }
        }
    }
}
