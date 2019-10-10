using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] triangleLine = { 1 };
            int[] oldTriangleLine = triangleLine;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(string.Join(" ", triangleLine));
                triangleLine = new int[i + 1];
                triangleLine[0] = 1;
                triangleLine[triangleLine.Length - 1] = 1;
                for (int j = 1; j < triangleLine.Length - 1; j++)
                {
                    triangleLine[j] = oldTriangleLine[j - 1] + oldTriangleLine[j];
                }
                oldTriangleLine = triangleLine;
            }
        }
    }
}
