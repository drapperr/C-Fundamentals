using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> noisyKids = Console.ReadLine().Split('&').ToList();

            string input;

            while ((input = Console.ReadLine()) != "Finished!")
            {
                string[] splitedInput = input.Split();

                string command = splitedInput[0];

                if (command == "Bad")
                {
                    string kidName = splitedInput[1];

                    if (!noisyKids.Contains(kidName))
                    {
                        noisyKids.Insert(0, kidName);
                    }
                }
                else if (command == "Good")
                {
                    string kidName = splitedInput[1];

                    if (noisyKids.Contains(kidName))
                    {
                        noisyKids.Remove(kidName);
                    }
                }
                else if (command == "Rename")
                {
                    string oldName = splitedInput[1];
                    string newName = splitedInput[2];

                    int index = noisyKids.IndexOf(oldName);

                    if (index != -1)
                    {
                        noisyKids[index] = newName;
                    }
                }
                else if (command == "Rearrange")
                {
                    string kidName = splitedInput[1];

                    if (noisyKids.Contains(kidName))
                    {
                        noisyKids.Remove(kidName);
                        noisyKids.Add(kidName);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", noisyKids));
        }
    }
}