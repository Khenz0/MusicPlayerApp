using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Genre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Song> Songs { get; set; }

        public Genre(string name, string description, List<Artist> artists, List<Song> songs)
        {
            Name = name;
            Description = description;
            Artists = artists;
            Songs = songs;
        }
    }
}
