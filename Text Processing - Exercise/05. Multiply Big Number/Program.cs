using System;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            string reversedResult = string.Empty;
            int residue = 0;
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentResult = int.Parse(bigNumber[i].ToString()) * number + residue;

                if (currentResult >= 10)
                {
                    residue = currentResult / 10;
                    currentResult %= 10;
                }
                else
                {
                    residue = 0;
                }
                reversedResult += currentResult;
            }
            if (residue != 0)
            {
                reversedResult += residue;
            }
            string result = string.Empty;
            bool isZero = true;
            for (int i = reversedResult.Length - 1; i >= 0; i--)
            {
                if (reversedResult[i] == '0' && isZero)
                {
                    continue;
                }
                else
                {
                    isZero = false;
                }
                if (!isZero)
                {
                    result += reversedResult[i];
                }
            }
            if (result == string.Empty)
            {
                result += 0;
            }
            Console.WriteLine(result);
        }
    }
}