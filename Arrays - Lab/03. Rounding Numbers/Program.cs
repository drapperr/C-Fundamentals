﻿using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num} => {num:f0}");
            }
        }
    }
}
