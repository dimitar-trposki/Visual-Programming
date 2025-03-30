using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV3_SongAlbum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Monday", 5, 5.0f);
            Song song1 = new Song("Tuesday", 4, 2.8f);
            Song song2 = new Song("Wednesday", 3, 3.5f);
            Song song3 = new Song("Thursday", 2, 4.0f);
            List<Song> list = new List<Song>();

            Album album = new Album("Week", 2024, list);

            album.AddSong(song1);
            album.AddSong(song);
            album.AddSong(song2);
            album.AddSong(song3);

            Console.WriteLine(album.ToString());
            //Console.ReadKey();

            string nameOfSong = Console.ReadLine();
            
            Console.WriteLine(album.FindSong(nameOfSong));
            //Console.ReadKey();
        }
    }
}
