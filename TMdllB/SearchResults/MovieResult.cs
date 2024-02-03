using System.Text.Json.Serialization;

namespace TMdllB.SearchResults
{
    /*
     * The MovieResult class represents an object in the 'results' array returned when using the /search/movie endpoint in the TMDB API
     */
    public class MovieResult : TVMovieBaseResult
    {
        /*
         * The original title of the movie
         */
        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = string.Empty;

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
    }
}
