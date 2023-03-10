using System;

namespace Giraffe
{
    class Song
    {
        // These variables are called class attributes

        public string title;
        public string artist;
        public int duration;
        public static int count = 0;


        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            count++;

        }

        public Song()
        {

        }

        public int getSongCount()
        {
            return count;
        }
    }
}
