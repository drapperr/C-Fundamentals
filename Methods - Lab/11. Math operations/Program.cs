using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Calculate(a, @operator, b);
        }

        private static void Calculate(int a, string @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case "/": result = a / (double)b; break;
                case "*": result = a * b; break;
                case "+": result = a + b; break;
                case "-": result = a - b; break;
            }
            Console.WriteLine(result);
        }
    }
}
