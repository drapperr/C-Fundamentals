using System;

class Solution
{
    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
