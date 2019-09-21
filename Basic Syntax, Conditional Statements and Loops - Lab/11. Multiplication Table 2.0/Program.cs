using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    int result = i * num;
                    Console.WriteLine($"{num} X {i} = {result}");
                }
            }
            else
            {
                int result = times * num;
                Console.WriteLine($"{num} X {times} = {result}");
            }
        }
    }
}
