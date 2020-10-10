using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;

            while ((input = Console.ReadLine()) != "find")
            {
                StringBuilder decrypedInput = new StringBuilder();
                int keyCounter = 0;

                foreach (var character in input)
                {
                    decrypedInput.Append((char)(character - key[keyCounter]));
                    keyCounter++;
                    if (keyCounter == key.Length)
                    {
                        keyCounter = 0;
                    }
                }
                int IndexOfType = decrypedInput.ToString().IndexOf('&') + 1;
                int startIndexOfCoordinates = decrypedInput.ToString().IndexOf('<') + 1;
                int lastIndexOfCoordinates = decrypedInput.ToString().IndexOf('>') - 1;
                string type = string.Empty;
                string coordinates = string.Empty;

                for (int i = IndexOfType; i < decrypedInput.Length; i++)
                {
                    if (decrypedInput[i] == '&')
                    {
                        break;
                    }
                    type += decrypedInput[i];
                }
                for (int i = startIndexOfCoordinates; i <= lastIndexOfCoordinates; i++)
                {
                    coordinates += decrypedInput[i];
                }
                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}