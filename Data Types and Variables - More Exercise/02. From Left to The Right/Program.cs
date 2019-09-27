using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] nums = input.Split();
                BigInteger firstNum = BigInteger.Parse(nums[0]);
                BigInteger secondNum = BigInteger.Parse(nums[1]);
                BigInteger biggerNummber;
                int sum = 0;
                if (firstNum > secondNum)
                {
                    biggerNummber = firstNum;
                }
                else
                {
                    biggerNummber = secondNum;
                }
                if (biggerNummber < 0)
                {
                    biggerNummber *= -1;
                }
                while (biggerNummber != 0)
                {
                    BigInteger digit = biggerNummber % 10;
                    sum += (int)digit;
                    biggerNummber /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
