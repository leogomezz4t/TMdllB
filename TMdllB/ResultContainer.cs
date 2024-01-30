using System.Text.Json.Serialization;

namespace TMdllB
{
    public class MovieContainer
    {
        /*
         * An integer representing the current page
         */
        [JsonPropertyName("page")]
        public int Page { get; set; }

        /*
         * An integer representing how many pages of results were returned
         */
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /*
         * An integer representing how many results were returned
         */
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        /*
         * List of MovieResult that represent the results returned
         */
        [JsonPropertyName("results")]
        public List<MovieResult> Results { get; set; }
    }
}
