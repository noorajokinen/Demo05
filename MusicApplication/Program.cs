using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Songs song1 = new Songs
            {   Name = "Trampoliini",
                Length = "3:05"};
            Songs song2 = new Songs
            {
                Name = "2080-luvulla",
                Length = "4:35"
            };
            Songs song3 = new Songs
            {
                Name = "Supernova",
                Length = "4:53"
            };
            Songs song4 = new Songs
            {
                Name = "Lauantai-ilta",
                Length = "3:53"
            };

            CD ekacd = new CD()
            {Artist="SANNI", AlbumName="Lelu", Price="12.95€" };
            ekacd.AddSongs(song1);
            ekacd.AddSongs(song2);
            ekacd.AddSongs(song3);
            ekacd.AddSongs(song4);
            ekacd.PrintCollection();
             
        }
    }
}
