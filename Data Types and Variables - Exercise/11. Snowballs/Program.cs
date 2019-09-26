using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger snowballSnowBest = 0;
            BigInteger snowballTimeBest = 0;
            BigInteger snowballQualityBest = 0;
            BigInteger snowballValueBest = 0;
            for (int i = 0; i < n; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > snowballValueBest)
                {
                    snowballSnowBest = snowballSnow;
                    snowballTimeBest = snowballTime;
                    snowballQualityBest = snowballQuality;
                    snowballValueBest = snowballValue;
                }
            }
            Console.WriteLine($"{snowballSnowBest} : {snowballTimeBest} = {snowballValueBest} ({snowballQualityBest})");
        }
    }
}
