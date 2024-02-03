using System.Text.Json.Serialization;

namespace TMdllB.SearchResults
{
    public class TVResult
    {
        /*
         * List of the countries the tv show originated from
         */
        [JsonPropertyName("origin_country")]
        public string[] OriginCountries { get; }

        /*
         * The original name of the show
         */
        [JsonPropertyName("original_name")]
        public string OriginalName { get; }

        /*
         * The date the first episode aired
         */
        [JsonPropertyName("first_air_date")]
        public DateOnly FirstAirDate { get; }

        /*
         * The name fo the show
         */
        [JsonPropertyName("name")]
        public string Name { get; }
    }
}
