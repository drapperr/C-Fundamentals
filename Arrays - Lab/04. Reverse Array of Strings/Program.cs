using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();
            Array.Reverse(text);
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
