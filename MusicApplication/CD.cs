using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    class CD
    {
        private List<Songs> cd;

        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public string Price { get; set; }


        public CD()
        {
            cd = new List<Songs>(); 
        }

        public void AddSongs(Songs songs)
        {
            cd.Add(songs);
        }


        public void PrintCollection()
        {
            foreach(Songs songs in cd)
            {
                Console.WriteLine(songs.ToString());
            }
        }

    }
}
