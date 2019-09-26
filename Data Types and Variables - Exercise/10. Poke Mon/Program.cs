using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int coppyN = N;
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int target = 0;
            while (N >= M)
            {
                if (2 * N == coppyN)
                {
                    if (Y > 0)
                    {
                        N /= Y;
                    }
                    if (N < M)
                    {
                        break;
                    }
                }
                N -= M;
                target++;
            }
            Console.WriteLine(N);
            Console.WriteLine(target);
        }
    }
}
