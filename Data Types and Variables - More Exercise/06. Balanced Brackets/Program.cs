using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool closed = true;
            int openingBracket = 0;
            int closingBracket = 0;
            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                if (text == "(")
                {
                    closed = false;
                    openingBracket++;
                }
                else if (text == ")")
                {
                    if (!closed)
                    {
                        closed = true;
                    }
                    closingBracket++;
                }
            }
            if (closed && openingBracket == closingBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
