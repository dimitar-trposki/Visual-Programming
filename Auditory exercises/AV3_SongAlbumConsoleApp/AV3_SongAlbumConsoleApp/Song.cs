using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AV3_SongAlbum
{
    internal class Song
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public float Rating { get; set; }

        public Song(string name, int duration, float rating)
        {
            Name = name;
            Duration = duration;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name} - {Duration}";
        }
    }
}
