using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();

                int startIndexOfName = input.IndexOf('@') + 1;
                int lastIndexOfName = input.IndexOf('|') - 1;
                StringBuilder name = new StringBuilder();

                for (int j = startIndexOfName; j <= lastIndexOfName; j++)
                {
                    name.Append(input[j]);
                }

                int startIndexOfAge = input.IndexOf('#') + 1;
                int lastIndexOfAge = input.IndexOf('*') - 1;
                StringBuilder age = new StringBuilder();

                for (int j = startIndexOfAge; j <= lastIndexOfAge; j++)
                {
                    age.Append(input[j]);
                }

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}