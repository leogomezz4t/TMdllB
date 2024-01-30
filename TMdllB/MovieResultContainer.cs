using System.Text.Json.Serialization;

namespace TMdllB
{
    public class MovieResultContainer : ResultContainer
    {
        /*
         * A list of type MovieResult that represents the results returned
         */
        [JsonPropertyName("results")]
        public List<MovieResult> Results { get; set; }
    }
}
