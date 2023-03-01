using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string title, string artist, DateTime releaseDate, List<Song> songs)
        {
            Title = title;
            Artist = artist;
            ReleaseDate = releaseDate;
            Songs = songs;
        }
    }
}
