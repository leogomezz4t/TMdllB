using System.Text.Json.Serialization;

namespace TMdllB.SearchResults
{
    /*
     * TVResultContainer represents the object returned by the TMDB API when using the /search/tv endpoint
     */
    public class TVResultContainer : ResultContainer
    {
        /*
         *  A list of type TVResult that represents the results returned
         */
        [JsonPropertyName("result")]
        public List<TVResult> Results { get; }
    }
}
