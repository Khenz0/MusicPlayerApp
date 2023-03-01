using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Artist
    {
        public string Name { get; set; }
        public string Biography { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }

        public Artist(string name, string biography, List<Album> albums, List<Song> songs)
        {
            Name = name;
            Biography = biography;
            Albums = albums;
            Songs = songs;
        }
    }
}
