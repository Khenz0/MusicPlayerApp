using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Library
    {
        public List<Song> Songs { get; set; }
        public List<Playlist> Playlists { get; set; }

        public Library(List<Song> songs, List<Playlist> playlists)
        {
            Songs = songs;
            Playlists = playlists;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }

        public void AddPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
        }

        public void RemovePlaylist(Playlist playlist)
        {
            Playlists.Remove(playlist);
        }
    }
}
