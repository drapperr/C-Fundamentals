using System;
using System.Collections.Generic;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> songsList = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song currentSong = new Song();

                currentSong.TypeList = type;
                currentSong.Name = name;
                currentSong.Time = time;

                songsList.Add(currentSong);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songsList)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
