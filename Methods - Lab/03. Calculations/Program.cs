using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            PrintResult(action, firsNumber, secondNumber);
        }

        private static void PrintResult(string action, int firsNumber, int secondNumber)
        {
            if (action == "add")
            {
                Add(firsNumber, secondNumber);
            }
            else if (action == "multiply")
            {
                Multiply(firsNumber, secondNumber);
            }
            else if (action == "subtract")
            {
                Subtract(firsNumber, secondNumber);
            }
            else if (action == "divide")
            {
                Divide(firsNumber, secondNumber);
            }
        }

        private static void Divide(int firsNumber, int secondNumber)
        {
            Console.WriteLine(firsNumber / secondNumber);
        }

        private static void Subtract(int firsNumber, int secondNumber)
        {
            Console.WriteLine(firsNumber - secondNumber);
        }

        private static void Multiply(int firsNumber, int secondNumber)
        {
            Console.WriteLine(firsNumber * secondNumber);
        }

        private static void Add(int firsNumber, int secondNumber)
        {
            Console.WriteLine(firsNumber + secondNumber);
        }
    }
}
