using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = 1; counter < n; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
                counter++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
