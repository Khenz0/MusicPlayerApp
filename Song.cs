using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Song
    {
        public string Title { get; set; }  
        public string Artist { get; set; }  
        public string Album { get; set; }
        public string FilePath { get; set; }

        public Song(string title, string artist, string album, string filePath)
        {
            Title = title;
            Artist = artist;
            Album = album;
            FilePath = filePath;
        }
    }
}
