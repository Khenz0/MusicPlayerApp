using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist(string PlaylistName)
        {
            Name = PlaylistName;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Song song) 
        {  
            Songs.Remove(song); 
        }
    }
}
