using System;
using System.Runtime.Serialization;

namespace AV3_SongAlbum
{
    [Serializable]
    internal class SongNotFoundException : Exception
    {
        public string Name { get; set; }

        public SongNotFoundException(string name) : base(string.Format("Song {0} was not found!", name))
        {

        }
    }
}