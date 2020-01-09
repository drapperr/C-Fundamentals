using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            var regexStar = new Regex(@"[STARstar]");

            int countInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < countInput; i++)
            {
                string encryptedCode = Console.ReadLine();

                var starCollection = regexStar.Matches(encryptedCode);
                int decryptNum = starCollection.Count;

                StringBuilder decryptedCode = new StringBuilder();

                foreach (var charachter in encryptedCode)
                {
                    decryptedCode.Append((char)(charachter - decryptNum));
                }

                var regex = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*:\d+[^@\-!:>]*!(?<type>[A|D])![^@\-!:>]*->\d+");

                if (regex.IsMatch(decryptedCode.ToString()))
                {
                    var correctCode = regex.Match(decryptedCode.ToString());
                    string type = correctCode.Groups["type"].Value;
                    string name = correctCode.Groups["name"].Value;
                    if (type == "A")
                    {
                        attackedPlanets.Add(name);
                    }
                    else if (type == "D")
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
                Console.WriteLine(string.Join(Environment.NewLine, attackedPlanets.Select(x => $"-> {x}")));
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
                Console.WriteLine(string.Join(Environment.NewLine, destroyedPlanets.Select(x => $"-> {x}")));
        }
    }
}
