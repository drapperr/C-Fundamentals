using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();
            string[] secondArr = Console.ReadLine().Split().ToArray();
            string commonElements = string.Empty;
            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        commonElements += secondArr[i] + " ";
                    }
                }
            }
            Console.WriteLine(commonElements);
        }
    }
}
