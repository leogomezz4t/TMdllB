using System.Text.Json.Serialization;

namespace TMdllB.Movie
{
    /*
     * The MovieResult class represents an object in the 'results' array returned when using the /search/movie endpoint in the TMDB API
     */
    internal class MovieResult
    {
        /*
         * A boolean representing whether this result is an adult film
         */
        [JsonPropertyName("adult")]
        public bool IsAdult { get; set; }

        /*
         * The relative image path to the backdrop for this movie
         */
        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = string.Empty;

        /*
         * A list of ids that each correspond to a genre
         */
        [JsonPropertyName("genre_ids")]
        public int[] GenreIds { get; set; }

        /*
         * The id given by TMDB for this movie
         */
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /*
         * The original language of the movie
         */
        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; } = string.Empty;

        /*
         * The original title of the movie
         */
        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = string.Empty;

        /*
         * A brief overview of the movie
         */
        [JsonPropertyName("overview")]
        public string Overview { get; set; } = string.Empty;

        /*
         * A popularity metric used by TMDB, more info here https://developer.themoviedb.org/docs/popularity-and-trending
         */
        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        /*
         * The relative image path of the poster for this movie
         */
        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = string.Empty;

        /*
         * The date this movie was released
         */
        [JsonPropertyName("release_date")]
        public DateOnly ReleaseDate { get; set; }

        /*
         * The title of the movie
         */
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /*
         * Promotional videos such as trailers
         */
        [JsonPropertyName("video")]
        public bool Video { get; set; }

        /*
         * The average votes received | Not sure of the timeframe
         */
        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        /*
         * How many votes this movie has recieved
         */
        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }
}
