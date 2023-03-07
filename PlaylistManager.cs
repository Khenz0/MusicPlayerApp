using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class PlaylistManager
    {
        public List<Playlist> Playlists { get; set; }

        public PlaylistManager() 
        {
            Playlists = new List<Playlist>();
        }

        public void CreatePlaylist(string playlistName)
        {
            Playlists.Add(new Playlist(playlistName));
        }

        public void DeletePlaylist(Playlist playlist) 
        {
            Playlists.Remove(playlist);
        }

        public void AddSongToPlaylist(Song song, Playlist playlist)
        {
            playlist.Songs.Add(song);
        }

        public void DeleteSongToPlaylist(Song song, Playlist playlist)
        {
            playlist.Songs.Remove(song);
        }
    }
}
