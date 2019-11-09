using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string number = Console.ReadLine();
            switch (type)
            {
                case "int": IntOperation(number); break;
                case "real": RealOperation(number); break;
                case "string": StringOperation(number); break;
            }
        }

        private static void StringOperation(string number)
        {
            Console.WriteLine($"${number}$");
        }

        private static void RealOperation(string number)
        {
            Console.WriteLine($"{double.Parse(number) * 1.5:F2}");
        }

        private static void IntOperation(string number)
        {
            Console.WriteLine(int.Parse(number) * 2);
        }
    }
}
