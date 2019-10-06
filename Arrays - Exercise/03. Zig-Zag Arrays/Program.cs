using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstLine = string.Empty;
            string secondLine = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstLine += numbers[0] + " ";
                    secondLine += numbers[1] + " ";
                }
                else
                {
                    firstLine += numbers[1] + " ";
                    secondLine += numbers[0] + " ";
                }
            }
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
        }
    }
}
