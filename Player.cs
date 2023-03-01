using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Player
    {
        public Song CurrentSong { get; set; }
        public Playlist CurrentPlaylist { get; set; }
        public bool IsPlaying { get; set; }

        public void Play()
        {
            // Play the current song
            Console.WriteLine("Now Playing: {0} by {1}", CurrentSong.Title, CurrentSong.Artist);
            IsPlaying = true;
        }

        public void Pause()
        {
            // Pause the current song
            Console.WriteLine("Current Song Paused...");
            IsPlaying = false;
        }

        public void Stop()
        {
            // Stop the current song
            Console.WriteLine("Song Stopped");
            IsPlaying = false;
            CurrentSong = null;
        }

        public void Next()
        {
            // Play the next song in the current playlist
            int currentIndex = CurrentPlaylist.Songs.IndexOf(CurrentSong);
            if (currentIndex < CurrentPlaylist.Songs.Count - 1)
            {
                CurrentSong = CurrentPlaylist.Songs[currentIndex + 1];
                Play();
            }
            else
            {
                Stop();
            }
        }

        public void Previous()
        {
            // Play the previous song in the current playlist
            int currentIndex = CurrentPlaylist.Songs.IndexOf(CurrentSong);
            if (currentIndex > 0)
            {
                CurrentSong = CurrentPlaylist.Songs[currentIndex - 1];
                Play();
            }
            else
            {
                Stop();
            }
        }
    }
}
