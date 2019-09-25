using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            bool specialNum = false;
            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;
                while (currentNum > 0)
                {
                    total += currentNum % 10;
                    currentNum /= 10;
                }
                specialNum = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", i, specialNum);
                total = 0;
            }

        }
    }
}
