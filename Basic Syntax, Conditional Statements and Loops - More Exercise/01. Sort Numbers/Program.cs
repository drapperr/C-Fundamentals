using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int firstNumber, secondNumber, thirdNumber;
            if (n1 > n2 && n1 > n3)
            {
                firstNumber = n1;
                if (n2 > n3)
                {
                    secondNumber = n2;
                    thirdNumber = n3;
                }
                else
                {
                    secondNumber = n3;
                    thirdNumber = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                firstNumber = n2;
                if (n1 > n3)
                {
                    secondNumber = n1;
                    thirdNumber = n3;
                }
                else
                {
                    secondNumber = n3;
                    thirdNumber = n1;
                }
            }
            else
            {
                firstNumber = n3;
                if (n1 > n2)
                {
                    secondNumber = n1;
                    thirdNumber = n2;
                }
                else
                {
                    secondNumber = n2;
                    thirdNumber = n1;
                }
            }
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
