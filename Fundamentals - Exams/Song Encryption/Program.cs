using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^((?<artist>[A-Z][a-z ']+):([A-Z ]+))$");

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);

                    string artist = match.Groups["artist"].Value;

                    int key = artist.Length;

                    StringBuilder encryptedInput = new StringBuilder();

                    for (int i = 0; i < input.Length; i++)
                    {
                        char symbol = input[i];
                        int asciisymbol = symbol;

                        if (char.IsLower(symbol))
                        {
                            asciisymbol += key;
                            while (asciisymbol > 'z')
                            {
                                int diff = asciisymbol - 'z';
                                asciisymbol = 'a' - 1 + diff;
                            }
                            symbol = (char)asciisymbol;
                        }
                        else if (char.IsUpper(symbol))
                        {
                            asciisymbol += key;
                            while (asciisymbol > 'Z')
                            {
                                int diff = asciisymbol - 'Z';
                                asciisymbol = 'A' - 1 + diff;
                            }
                            symbol = (char)asciisymbol;
                        }
                        else if (symbol == ':')
                        {
                            symbol = '@';
                        }
                        encryptedInput.Append(symbol);
                    }
                    Console.WriteLine($"Successful encryption: {encryptedInput}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
