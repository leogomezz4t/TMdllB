using System.Text.Json.Serialization;

namespace TMdllB
{
    public class MovieResult
    {
        /*
         * A boolean representing whether this result is an adult film
         */
        public bool IsAdult { get; set; }

        /*
         * The relative image path to the backdrop for this movie
         */
        public string BackdropPath { get; set; } = string.Empty;

        /*
         * A list of ids that each correspond to a genre
         */
        public int[] GenreIds { get; set; }

        /*
         * The id given by TMDB for this movie
         */
        public int Id { get; set; }

        /*
         * The original language of the movie
         */
        public string OriginalLanguage { get; set; } = string.Empty;

        /*
         * The original title of the movie
         */
        public string OriginalTitle { get; set; } = string.Empty;

        /*
         * A brief overview of the movie
         */
        public string Overview {  get; set; } = string.Empty;

        /*
         * A popularity metric used by TMDB, more info here https://developer.themoviedb.org/docs/popularity-and-trending
         */
        public float Popularity { get; set; }

        /*
         * The relative image path of the poster for this movie
         */
        public string PosterPath { get; set; } = string.Empty;

        /*
         * The date this movie was released
         */
        public DateOnly ReleaseData { get; set; }

        /*
         * The title of the movie
         */
        public string Title { get; set; } = string.Empty;

        /*
         * TODO Not sure what this is honestly
         */
        public bool Video { get; set; }

        /*
         * The average votes received | Not sure of the timeframe
         */
        public float VoteAverage { get; set; }

        /*
         * How many votes this movie has recieved
         */
        public int VoteCount { get; set; }
    }
}
