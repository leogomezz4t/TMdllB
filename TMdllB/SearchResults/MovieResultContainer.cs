using System.Text.Json.Serialization;

namespace TMdllB.SearchResults
{
    /*
     * MovieResultContainer represents the object returned by the TMDB API when using the /search/movie endpoint
     */
    public class MovieResultContainer : ResultContainer
    {
        /*
         * A list of type MovieResult that represents the results returned
         */
        [JsonPropertyName("results")]
        public List<MovieResult> Results { get; set; }
    }
}
