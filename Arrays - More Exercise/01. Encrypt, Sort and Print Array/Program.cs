using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());
            string[] names = new string[namesCount];
            ReadNames(namesCount, names);
            int[] nameCode = new int[namesCount];
            ConvertNames(nameCode, names);
            Array.Sort(nameCode);
            foreach (var code in nameCode)
            {
                Console.WriteLine(code);
            }
        }

        private static void ConvertNames(int[] nameCode, string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];
                int currentSum = 0;
                for (int j = 0; j < currentName.Length; j++)
                {
                    char currentChar = currentName[j];
                    bool vowel = currentChar == 'A' || currentChar == 'a' ||
                        currentChar == 'E' || currentChar == 'e' ||
                        currentChar == 'I' || currentChar == 'i' ||
                        currentChar == 'O' || currentChar == 'o' ||
                        currentChar == 'U' || currentChar == 'u';
                    if (vowel)
                    {
                        currentSum += currentChar * currentName.Length;
                    }
                    else
                    {
                        currentSum += currentChar / currentName.Length;
                    }
                }
                nameCode[i] = currentSum;
            }
        }

        private static void ReadNames(int namesCount, string[] names)
        {
            for (int i = 0; i < namesCount; i++)
            {
                names[i] = Console.ReadLine();
            }
        }
    }
}
