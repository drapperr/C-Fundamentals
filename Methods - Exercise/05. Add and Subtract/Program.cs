using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum = SumNumbers(firstNumber, secondNumber);
            Console.WriteLine(Subtract(sum, thirdNumber));
        }

        private static int Subtract(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }

        private static int SumNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
