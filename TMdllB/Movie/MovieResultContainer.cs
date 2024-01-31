using System.Text.Json.Serialization;

namespace TMdllB.Movie
{
    /*
     * MovieResultContainer represents the object returned by the TMDB API when using the /search/movie endpoint
     */
    internal class MovieResultContainer : ResultContainer
    {
        /*
         * A list of type MovieResult that represents the results returned
         */
        [JsonPropertyName("results")]
        public List<MovieResult> Results { get; set; }
    }
}
