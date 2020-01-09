using System;
using System.Text.RegularExpressions;
class Extract_Emails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1]);
        }
    }
}