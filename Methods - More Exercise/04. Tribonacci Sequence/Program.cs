using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            GetTribonacci(count);
        }

        private static void GetTribonacci(int count)
        {
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
            for (int i = 0; i < count; i++)
            {
                int triboNum = firstNum + secondNum + thirdNum;
                if (i == 0)
                {
                    triboNum = 1;
                }
                Console.Write(triboNum + " ");
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = triboNum;
            }
        }
    }
}
