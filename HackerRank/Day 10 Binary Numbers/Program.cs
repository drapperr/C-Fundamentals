using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string binary = Convert.ToString(n, 2);

        int maxConsecutive = 0;
        int currentConsecutive = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i]== '1')
            {
                currentConsecutive++;
            }
            else
            {
                
                if (currentConsecutive>maxConsecutive)
                {
                    maxConsecutive = currentConsecutive;
                }

                currentConsecutive = 0;
            }
        }

        if (currentConsecutive > maxConsecutive)
        {
            maxConsecutive = currentConsecutive;
        }

        Console.WriteLine(maxConsecutive);
    }
}
