using System;

namespace Giraffe
{
    class Movie
    {
        // These variables are called class attributes

        public string title;
        public string director;
        private string rating;


        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            // Here we are trying to set the rating of the object by using the setter defined below
            Rating = aRating;

        }

        public Movie()
        {

        }

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
                
            }
        }
    }
}
