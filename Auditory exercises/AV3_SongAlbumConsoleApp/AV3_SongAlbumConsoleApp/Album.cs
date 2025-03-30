using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV3_SongAlbum
{
    internal class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public List<Song> Songs { get; set; }

        public Album(string name, int year, List<Song> songs)
        {
            Name = name;
            Year = year;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddSong(string nameSong, int duration, float rating)
        {
            Song song = new Song(nameSong, duration, rating);
            Songs.Add(song);
        }

        public Song FindSong(string nameOfSong)
        {
            foreach (Song song in Songs)
            {
                if (song.Name.Equals(nameOfSong, StringComparison.OrdinalIgnoreCase))
                {
                    return song;
                }
            }
            throw new SongNotFoundException(nameOfSong);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append("\n");
            stringBuilder.Append(Year);
            stringBuilder.Append("\n");
            stringBuilder.Append("Songs");
            stringBuilder.Append("\n");
            foreach (Song song in Songs)
            {
                stringBuilder.Append(song.ToString());
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}
